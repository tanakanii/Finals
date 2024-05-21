<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CustomerTable = New DataGridView()
        txtQty = New TextBox()
        lblName = New Label()
        btnAdd = New Button()
        cboProducName = New ComboBox()
        rbtSold = New RadioButton()
        rbtDeliver = New RadioButton()
        Label1 = New Label()
        cboName = New ComboBox()
        Label2 = New Label()
        btnSave = New Button()
        dgvProductCode = New DataGridViewTextBoxColumn()
        dgvSuppCustID = New DataGridViewTextBoxColumn()
        dgvQty = New DataGridViewTextBoxColumn()
        dgvAction = New DataGridViewTextBoxColumn()
        CType(CustomerTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CustomerTable
        ' 
        CustomerTable.AllowUserToAddRows = False
        CustomerTable.AllowUserToDeleteRows = False
        CustomerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerTable.Columns.AddRange(New DataGridViewColumn() {dgvProductCode, dgvSuppCustID, dgvQty, dgvAction})
        CustomerTable.Location = New Point(116, 333)
        CustomerTable.Margin = New Padding(3, 4, 3, 4)
        CustomerTable.Name = "CustomerTable"
        CustomerTable.ReadOnly = True
        CustomerTable.RowHeadersWidth = 51
        CustomerTable.Size = New Size(511, 300)
        CustomerTable.TabIndex = 0
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(268, 216)
        txtQty.Margin = New Padding(3, 4, 3, 4)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(322, 27)
        txtQty.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(135, 108)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 2
        lblName.Text = "Name"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(685, 108)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(163, 80)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' cboProducName
        ' 
        cboProducName.FormattingEnabled = True
        cboProducName.Location = New Point(268, 157)
        cboProducName.Margin = New Padding(3, 4, 3, 4)
        cboProducName.Name = "cboProducName"
        cboProducName.Size = New Size(322, 28)
        cboProducName.TabIndex = 4
        ' 
        ' rbtSold
        ' 
        rbtSold.AutoSize = True
        rbtSold.Location = New Point(152, 48)
        rbtSold.Name = "rbtSold"
        rbtSold.Size = New Size(60, 24)
        rbtSold.TabIndex = 5
        rbtSold.TabStop = True
        rbtSold.Text = "Sold"
        rbtSold.UseVisualStyleBackColor = True
        ' 
        ' rbtDeliver
        ' 
        rbtDeliver.AutoSize = True
        rbtDeliver.Location = New Point(251, 48)
        rbtDeliver.Name = "rbtDeliver"
        rbtDeliver.Size = New Size(77, 24)
        rbtDeliver.TabIndex = 6
        rbtDeliver.TabStop = True
        rbtDeliver.Text = "Deliver"
        rbtDeliver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(135, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 7
        Label1.Text = "Product Name"
        ' 
        ' cboName
        ' 
        cboName.FormattingEnabled = True
        cboName.Location = New Point(268, 108)
        cboName.Margin = New Padding(3, 4, 3, 4)
        cboName.Name = "cboName"
        cboName.Size = New Size(322, 28)
        cboName.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(135, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 20)
        Label2.TabIndex = 9
        Label2.Text = "Qty"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(660, 349)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(163, 80)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dgvProductCode
        ' 
        dgvProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        dgvProductCode.Frozen = True
        dgvProductCode.HeaderText = "Product_Code"
        dgvProductCode.MinimumWidth = 6
        dgvProductCode.Name = "dgvProductCode"
        dgvProductCode.ReadOnly = True
        dgvProductCode.Width = 130
        ' 
        ' dgvSuppCustID
        ' 
        dgvSuppCustID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        dgvSuppCustID.HeaderText = "Supplier_ID/Customer_ID"
        dgvSuppCustID.MinimumWidth = 6
        dgvSuppCustID.Name = "dgvSuppCustID"
        dgvSuppCustID.ReadOnly = True
        dgvSuppCustID.Width = 204
        ' 
        ' dgvQty
        ' 
        dgvQty.HeaderText = "Qty"
        dgvQty.MinimumWidth = 6
        dgvQty.Name = "dgvQty"
        dgvQty.ReadOnly = True
        dgvQty.Width = 125
        ' 
        ' dgvAction
        ' 
        dgvAction.HeaderText = ""
        dgvAction.MinimumWidth = 6
        dgvAction.Name = "dgvAction"
        dgvAction.ReadOnly = True
        dgvAction.Visible = False
        dgvAction.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 777)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(cboName)
        Controls.Add(Label1)
        Controls.Add(rbtDeliver)
        Controls.Add(rbtSold)
        Controls.Add(cboProducName)
        Controls.Add(btnAdd)
        Controls.Add(lblName)
        Controls.Add(txtQty)
        Controls.Add(CustomerTable)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(CustomerTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomerTable As DataGridView
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboProducName As ComboBox
    Friend WithEvents rbtSold As RadioButton
    Friend WithEvents rbtDeliver As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvProductCode As DataGridViewTextBoxColumn
    Friend WithEvents dgvSuppCustID As DataGridViewTextBoxColumn
    Friend WithEvents dgvQty As DataGridViewTextBoxColumn
    Friend WithEvents dgvAction As DataGridViewTextBoxColumn

End Class
