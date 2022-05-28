<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLOYEE_INFORMATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLOYEE_INFORMATION))
        Me.tbox_email_address = New System.Windows.Forms.TextBox()
        Me.tbox_employee_id = New System.Windows.Forms.TextBox()
        Me.tbox_firstname = New System.Windows.Forms.TextBox()
        Me.tbox_middle_name = New System.Windows.Forms.TextBox()
        Me.tbox_lastname = New System.Windows.Forms.TextBox()
        Me.tbox_extension_name = New System.Windows.Forms.TextBox()
        Me.tbox_age = New System.Windows.Forms.TextBox()
        Me.tbox_gender = New System.Windows.Forms.TextBox()
        Me.tbox_contact_number = New System.Windows.Forms.TextBox()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tboxSearch = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbox_email_address
        '
        Me.tbox_email_address.Location = New System.Drawing.Point(12, 320)
        Me.tbox_email_address.Name = "tbox_email_address"
        Me.tbox_email_address.PlaceholderText = "email_address"
        Me.tbox_email_address.Size = New System.Drawing.Size(183, 23)
        Me.tbox_email_address.TabIndex = 0
        '
        'tbox_employee_id
        '
        Me.tbox_employee_id.Location = New System.Drawing.Point(12, 88)
        Me.tbox_employee_id.Name = "tbox_employee_id"
        Me.tbox_employee_id.PlaceholderText = "employee_id"
        Me.tbox_employee_id.Size = New System.Drawing.Size(183, 23)
        Me.tbox_employee_id.TabIndex = 1
        '
        'tbox_firstname
        '
        Me.tbox_firstname.Location = New System.Drawing.Point(12, 117)
        Me.tbox_firstname.Name = "tbox_firstname"
        Me.tbox_firstname.PlaceholderText = "firstname"
        Me.tbox_firstname.Size = New System.Drawing.Size(183, 23)
        Me.tbox_firstname.TabIndex = 2
        '
        'tbox_middle_name
        '
        Me.tbox_middle_name.Location = New System.Drawing.Point(12, 146)
        Me.tbox_middle_name.Name = "tbox_middle_name"
        Me.tbox_middle_name.PlaceholderText = "middle_name"
        Me.tbox_middle_name.Size = New System.Drawing.Size(183, 23)
        Me.tbox_middle_name.TabIndex = 3
        '
        'tbox_lastname
        '
        Me.tbox_lastname.Location = New System.Drawing.Point(12, 175)
        Me.tbox_lastname.Name = "tbox_lastname"
        Me.tbox_lastname.PlaceholderText = "lastname"
        Me.tbox_lastname.Size = New System.Drawing.Size(183, 23)
        Me.tbox_lastname.TabIndex = 4
        '
        'tbox_extension_name
        '
        Me.tbox_extension_name.Location = New System.Drawing.Point(12, 204)
        Me.tbox_extension_name.Name = "tbox_extension_name"
        Me.tbox_extension_name.PlaceholderText = "extension_name"
        Me.tbox_extension_name.Size = New System.Drawing.Size(183, 23)
        Me.tbox_extension_name.TabIndex = 5
        '
        'tbox_age
        '
        Me.tbox_age.Location = New System.Drawing.Point(12, 233)
        Me.tbox_age.Name = "tbox_age"
        Me.tbox_age.PlaceholderText = "age"
        Me.tbox_age.Size = New System.Drawing.Size(183, 23)
        Me.tbox_age.TabIndex = 6
        '
        'tbox_gender
        '
        Me.tbox_gender.Location = New System.Drawing.Point(12, 262)
        Me.tbox_gender.Name = "tbox_gender"
        Me.tbox_gender.PlaceholderText = "gender"
        Me.tbox_gender.Size = New System.Drawing.Size(183, 23)
        Me.tbox_gender.TabIndex = 7
        '
        'tbox_contact_number
        '
        Me.tbox_contact_number.Location = New System.Drawing.Point(12, 291)
        Me.tbox_contact_number.Name = "tbox_contact_number"
        Me.tbox_contact_number.PlaceholderText = "contact_number"
        Me.tbox_contact_number.Size = New System.Drawing.Size(183, 23)
        Me.tbox_contact_number.TabIndex = 8
        '
        'DTGLIST
        '
        Me.DTGLIST.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DTGLIST.GridColor = System.Drawing.SystemColors.WindowFrame
        Me.DTGLIST.Location = New System.Drawing.Point(201, 51)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.RowTemplate.Height = 25
        Me.DTGLIST.Size = New System.Drawing.Size(592, 306)
        Me.DTGLIST.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "employee_id"
        Me.Column1.HeaderText = "employee_id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "first_name"
        Me.Column2.HeaderText = "firstname"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "middle_name"
        Me.Column3.HeaderText = "middle_name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "last_name"
        Me.Column4.HeaderText = "lastname"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "extension_name"
        Me.Column5.HeaderText = "extension_name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "age"
        Me.Column6.HeaderText = "age"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "gender"
        Me.Column7.HeaderText = "gender"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "contact_number"
        Me.Column8.HeaderText = "contact_number"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "email_address"
        Me.Column9.HeaderText = "email_address"
        Me.Column9.Name = "Column9"
        '
        'tboxSearch
        '
        Me.tboxSearch.Location = New System.Drawing.Point(576, 12)
        Me.tboxSearch.Name = "tboxSearch"
        Me.tboxSearch.PlaceholderText = "SEARCH"
        Me.tboxSearch.Size = New System.Drawing.Size(212, 23)
        Me.tboxSearch.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 371)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(120, 371)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 12
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 418)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(120, 418)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(662, 389)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(111, 32)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(376, 12)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(183, 23)
        Me.TextBox11.TabIndex = 16
        Me.TextBox11.Text = "search by firstname/lastname/ID"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(56, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 66)
        Me.Panel1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EMPLOYEE_INFORMATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tboxSearch)
        Me.Controls.Add(Me.DTGLIST)
        Me.Controls.Add(Me.tbox_contact_number)
        Me.Controls.Add(Me.tbox_gender)
        Me.Controls.Add(Me.tbox_age)
        Me.Controls.Add(Me.tbox_extension_name)
        Me.Controls.Add(Me.tbox_lastname)
        Me.Controls.Add(Me.tbox_middle_name)
        Me.Controls.Add(Me.tbox_firstname)
        Me.Controls.Add(Me.tbox_employee_id)
        Me.Controls.Add(Me.tbox_email_address)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EMPLOYEE_INFORMATION"
        Me.Text = "EMPLOYEE_INFORMATION"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbox_email_address As TextBox
    Friend WithEvents tbox_employee_id As TextBox
    Friend WithEvents tbox_firstname As TextBox
    Friend WithEvents tbox_middle_name As TextBox
    Friend WithEvents tbox_lastname As TextBox
    Friend WithEvents tbox_extension_name As TextBox
    Friend WithEvents tbox_age As TextBox
    Friend WithEvents tbox_gender As TextBox
    Friend WithEvents tbox_contact_number As TextBox
    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents tboxSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
