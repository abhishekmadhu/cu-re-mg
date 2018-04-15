﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldCustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OldCustomerForm))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet11 = New crm10.DataSet1()
        Me.grdProperties = New System.Windows.Forms.DataGrid()
        Me.CustomerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.productID = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT customerList.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     customerList"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\customers.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `customerList` (`First_Name`, `Last_Name`, `Product_Category`, `Produ" &
    "ct_ID`) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "First_Name"), New System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Last_Name"), New System.Data.OleDb.OleDbParameter("Product_Category", System.Data.OleDb.OleDbType.VarWChar, 0, "Product_Category"), New System.Data.OleDb.OleDbParameter("Product_ID", System.Data.OleDb.OleDbType.VarWChar, 0, "Product_ID")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "First_Name"), New System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Last_Name"), New System.Data.OleDb.OleDbParameter("Product_Category", System.Data.OleDb.OleDbType.VarWChar, 0, "Product_Category"), New System.Data.OleDb.OleDbParameter("Product_ID", System.Data.OleDb.OleDbType.VarWChar, 0, "Product_ID"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_First_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "First_Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First_Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Last_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Last_Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Product_Category", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Product_Category", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Product_Category", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product_Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Product_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Product_ID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Product_ID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product_ID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_First_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "First_Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First_Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Last_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Last_Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Product_Category", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Product_Category", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Product_Category", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product_Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Product_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Product_ID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Product_ID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Product_ID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "customerList", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("First_Name", "First_Name"), New System.Data.Common.DataColumnMapping("Last_Name", "Last_Name"), New System.Data.Common.DataColumnMapping("Product_Category", "Product_Category"), New System.Data.Common.DataColumnMapping("Product_ID", "Product_ID")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdProperties
        '
        Me.grdProperties.DataMember = ""
        Me.grdProperties.DataSource = Me.CustomerListBindingSource
        Me.grdProperties.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProperties.Location = New System.Drawing.Point(66, 159)
        Me.grdProperties.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grdProperties.Name = "grdProperties"
        Me.grdProperties.Size = New System.Drawing.Size(497, 194)
        Me.grdProperties.TabIndex = 0
        '
        'CustomerListBindingSource
        '
        Me.CustomerListBindingSource.DataMember = "customerList"
        Me.CustomerListBindingSource.DataSource = Me.DataSet11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 74)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 119)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 2
        '
        'productID
        '
        Me.productID.Location = New System.Drawing.Point(334, 74)
        Me.productID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.productID.Name = "productID"
        Me.productID.Size = New System.Drawing.Size(147, 34)
        Me.productID.TabIndex = 3
        Me.productID.Text = "SEARCH BY PRODUCT ID"
        Me.productID.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'OldCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 549)
        Me.Controls.Add(Me.productID)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.grdProperties)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "OldCustomerForm"
        Me.Text = "OldCustomerForm"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents grdProperties As DataGrid
    Friend WithEvents CustomerListBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents productID As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
