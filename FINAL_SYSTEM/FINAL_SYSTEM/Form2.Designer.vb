<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.tbox_AttendanceID = New System.Windows.Forms.TextBox()
        Me.tbox_job_name = New System.Windows.Forms.TextBox()
        Me.tbox_EmployeeID = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.tbox_search = New System.Windows.Forms.TextBox()
        Me.lbl_filter = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbox_AttendanceID
        '
        Me.tbox_AttendanceID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbox_AttendanceID.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbox_AttendanceID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tbox_AttendanceID.Location = New System.Drawing.Point(35, 148)
        Me.tbox_AttendanceID.Name = "tbox_AttendanceID"
        Me.tbox_AttendanceID.PlaceholderText = "attendance_id"
        Me.tbox_AttendanceID.Size = New System.Drawing.Size(218, 23)
        Me.tbox_AttendanceID.TabIndex = 0
        '
        'tbox_job_name
        '
        Me.tbox_job_name.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbox_job_name.Location = New System.Drawing.Point(35, 240)
        Me.tbox_job_name.Name = "tbox_job_name"
        Me.tbox_job_name.PlaceholderText = "job_name"
        Me.tbox_job_name.Size = New System.Drawing.Size(218, 23)
        Me.tbox_job_name.TabIndex = 2
        '
        'tbox_EmployeeID
        '
        Me.tbox_EmployeeID.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbox_EmployeeID.Location = New System.Drawing.Point(35, 197)
        Me.tbox_EmployeeID.Name = "tbox_EmployeeID"
        Me.tbox_EmployeeID.PlaceholderText = "employee_id"
        Me.tbox_EmployeeID.Size = New System.Drawing.Size(218, 23)
        Me.tbox_EmployeeID.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(35, 355)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNew.Location = New System.Drawing.Point(137, 355)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.Location = New System.Drawing.Point(35, 398)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(137, 398)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DTGLIST
        '
        Me.DTGLIST.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DTGLIST.Location = New System.Drawing.Point(327, 112)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.RowTemplate.Height = 25
        Me.DTGLIST.Size = New System.Drawing.Size(444, 254)
        Me.DTGLIST.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "attendance_id"
        Me.Column1.HeaderText = "attendance_id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "employee_id"
        Me.Column2.HeaderText = "employee_id"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "job_name"
        Me.Column3.HeaderText = "job_name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "date"
        Me.Column4.HeaderText = "DATE"
        Me.Column4.Name = "Column4"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.Location = New System.Drawing.Point(661, 391)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 30)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTime.Location = New System.Drawing.Point(35, 278)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(218, 23)
        Me.dtpDateTime.TabIndex = 11
        Me.dtpDateTime.Value = New Date(2022, 5, 16, 12, 27, 4, 0)
        '
        'tbox_search
        '
        Me.tbox_search.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbox_search.Location = New System.Drawing.Point(562, 64)
        Me.tbox_search.Name = "tbox_search"
        Me.tbox_search.PlaceholderText = "SEARCH"
        Me.tbox_search.Size = New System.Drawing.Size(226, 23)
        Me.tbox_search.TabIndex = 12
        '
        'lbl_filter
        '
        Me.lbl_filter.AutoSize = True
        Me.lbl_filter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_filter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_filter.Location = New System.Drawing.Point(419, 67)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(137, 17)
        Me.lbl_filter.TabIndex = 13
        Me.lbl_filter.Text = "Search By attendance_id"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(90, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(93, 77)
        Me.Panel1.TabIndex = 14
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeader.Location = New System.Drawing.Point(295, 19)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(252, 28)
        Me.lblHeader.TabIndex = 15
        Me.lblHeader.Text = "EMPLOYEE ATTENDANCE"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_filter)
        Me.Controls.Add(Me.tbox_search)
        Me.Controls.Add(Me.dtpDateTime)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DTGLIST)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbox_EmployeeID)
        Me.Controls.Add(Me.tbox_job_name)
        Me.Controls.Add(Me.tbox_AttendanceID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form2"
        Me.Text = "EMPLOYEE ATTENDANCE"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbox_AttendanceID As TextBox
    Friend WithEvents tbox_job_name As TextBox
    Friend WithEvents tbox_EmployeeID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dtpDateTime As DateTimePicker
    Friend WithEvents tbox_search As TextBox
    Friend WithEvents lbl_filter As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeader As Label
End Class
