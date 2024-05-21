Imports MySql.Data.MySqlClient

Public Class Form1
    Dim str As String
    Private Sub LoadDgv()
        str = "Select product_code, customer_supplier, qty, action from product_purchase_order"
        Try
            CustomerTable.Rows.Clear()
            readquery(str)
            With cmdread
                While .Read
                    Dim product_code As String = "" & .GetValue(0).ToString()
                    Dim customer_supplier As String = .GetValue(1).ToString()
                    Dim qty As String = .GetValue(2).ToString()
                    Dim action As String = .GetValue(3).ToString()
                    CustomerTable.Rows.Add(product_code, customer_supplier, qty, action)
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PopulateName(type As String)
        cboName.Items.Clear()
        If type = "Customer" Then
            str = "Select cust_name from customer"
        ElseIf type = "Supplier" Then
            str = "Select supplier_name from supplier"
        End If

        Try
            readquery(str)
            With cmdread
                While .Read
                    If type = "Customer" Then
                        cboName.Items.Add(New NameInfo(.GetValue(0).ToString(), "Customer"))
                    ElseIf type = "Supplier" Then
                        cboName.Items.Add(New NameInfo(.GetValue(0).ToString(), "Supplier"))
                    End If
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PopulateProd()
        str = "Select prod_name from product"
        Try
            cboProducName.Items.Clear()
            readquery(str)
            With cmdread
                While .Read
                    cboProducName.Items.Add(.GetValue(0).ToString())
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rbtSold.Checked Then
            PopulateName("Customer")
        ElseIf rbtDeliver.Checked Then
            PopulateName("Supplier")
        End If
        PopulateProd()
    End Sub

    Private Sub rbtSold_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSold.CheckedChanged
        If rbtSold.Checked Then
            PopulateName("Customer")
        End If
    End Sub

    Private Sub rbtDeliver_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDeliver.CheckedChanged
        If rbtDeliver.Checked Then
            PopulateName("Supplier")
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim selectedNameInfo As NameInfo = CType(cboName.SelectedItem, NameInfo)
        If selectedNameInfo IsNot Nothing Then
            Dim nameType As String = selectedNameInfo.Type
            Dim name As String = selectedNameInfo.Name
            Dim product As String = cboProducName.SelectedItem.ToString()
            Dim product_code As String = String.Empty
            Dim customer_supplier As String = String.Empty
            Dim qty As Integer = Integer.Parse(txtQty.Text())
            Dim action As String = If(rbtSold.Checked, "Sold", If(rbtDeliver.Checked, "Deliver", ""))

            str = "Select product_code from product where prod_name= '" & product & "'"
            Try
                readquery(str)
                If cmdread.Read() Then
                    product_code = "" & cmdread.GetValue(0).ToString()
                End If
            Catch ex As Exception
            End Try
            If nameType = "Customer" Then
                str = "Select customer_code from customer where cust_name= '" & name & "'"
            ElseIf nameType = "Supplier" Then
                str = "Select supplier_id from supplier where supplier_name= '" & name & "'"
            End If

            Try
                readquery(str)
                If cmdread.Read() Then
                    If nameType = "Customer" Then
                        customer_supplier = "" & cmdread.GetValue(0).ToString()
                    ElseIf nameType = "Supplier" Then
                        customer_supplier = "" & cmdread.GetValue(0).ToString()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

            If Not String.IsNullOrEmpty(product_code) AndAlso Not String.IsNullOrEmpty(customer_supplier) Then
                CustomerTable.Rows.Add(product_code, customer_supplier, qty, action)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim transaction As MySqlTransaction = Nothing
        Try
            conn.Close()
            conn.Open()

            transaction = conn.BeginTransaction()

            For Each row As DataGridViewRow In CustomerTable.Rows
                If Not row.IsNewRow Then
                    Dim product_code As String = row.Cells("dgvProductCode").Value.ToString()
                    Dim customer_supplier As String = row.Cells("dgvSuppCustID").Value.ToString()
                    Dim qty As Integer = Integer.Parse(row.Cells("dgvQty").Value.ToString())
                    Dim action As String = row.Cells("dgvAction").Value.ToString()

                    Dim insertOrUpdateQuery As String = "INSERT INTO product_purchase_order (product_code, customer_supplier, transaction, qty)
                                                        VALUES (@product_code, @customer_supplier, @action, @qty)"
                    cmd = New MySqlCommand(insertOrUpdateQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@product_code", product_code)
                    cmd.Parameters.AddWithValue("@customer_supplier", customer_supplier)
                    cmd.Parameters.AddWithValue("@action", action)
                    cmd.Parameters.AddWithValue("@qty", qty)
                    cmd.ExecuteNonQuery()

                    Dim updateProductQuery As String = ""
                    conn.Close()
                    conn.Open()
                    If action = "Sold" Then
                        updateProductQuery = "UPDATE product SET prod_qty = prod_qty - @qty WHERE product_code = @product_code"
                    ElseIf action = "Deliver" Then
                        updateProductQuery = "UPDATE product SET prod_qty = prod_qty + @qty WHERE product_code = @product_code"
                    End If

                    If Not String.IsNullOrEmpty(updateProductQuery) Then
                        cmd = New MySqlCommand(updateProductQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@qty", qty)
                        cmd.Parameters.AddWithValue("@product_code", product_code)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next
            MsgBox("Success")

            CustomerTable.Rows.Clear()
            transaction.Commit()
        Catch ex As Exception

            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Class NameInfo
        Public Property Name As String
        Public Property Type As String
        Public Sub New(name As String, type As String)
            Me.Name = name
            Me.Type = type
        End Sub
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Class
