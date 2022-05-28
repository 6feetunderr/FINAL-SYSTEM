Public Class EMPLOYEE_INFORMATION
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            add_data("INSERT INTO `tb_employee`(`employee_id`, `first_name`, `middle_name`, `last_name`, `extension_name`, `age`, `gender`, `contact_number`, `email_address`) 
                        VALUES ('" & tbox_employee_id.Text & "',
                                '" & tbox_firstname.Text & "',
                                '" & tbox_middle_name.Text & "',
                                '" & tbox_lastname.Text & "',
                                '" & tbox_extension_name.Text & "',
                                '" & tbox_age.Text & "',
                                '" & tbox_gender.Text & "',
                                '" & tbox_contact_number.Text & "',
                                '" & tbox_email_address.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)



        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM tb_employee", DTGLIST)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            edit_data("UPDATE tb_employee SET first_name= '" & tbox_firstname.Text & "',
                                            middle_name= '" & tbox_middle_name.Text & "',
                                            last_name= '" & tbox_lastname.Text & "', 
                                            extension_name='" & tbox_extension_name.Text & "', 
                                            age= '" & tbox_age.Text & "', 
                                            gender='" & tbox_gender.Text & "', 
                                            contact_number= '" & tbox_contact_number.Text & "',
                                            email_address='" & tbox_email_address.Text & "'
                                            WHERE employee_id='" & tbox_employee_id.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DTGLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLIST.CellContentClick
        tbox_employee_id.Text = DTGLIST.CurrentRow.Cells(0).Value
        tbox_firstname.Text = DTGLIST.CurrentRow.Cells(1).Value
        tbox_middle_name.Text = DTGLIST.CurrentRow.Cells(2).Value
        tbox_lastname.Text = DTGLIST.CurrentRow.Cells(3).Value
        tbox_extension_name.Text = DTGLIST.CurrentRow.Cells(4).Value
        tbox_age.Text = DTGLIST.CurrentRow.Cells(5).Value
        tbox_gender.Text = DTGLIST.CurrentRow.Cells(6).Value
        tbox_contact_number.Text = DTGLIST.CurrentRow.Cells(7).Value
        tbox_email_address.Text = DTGLIST.CurrentRow.Cells(8).Value

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM tb_employee WHERE employee_id='" & tbox_employee_id.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        tbox_employee_id.Text = ""
        tbox_firstname.Clear()
        tbox_middle_name.Clear()
        tbox_lastname.Clear()
        tbox_extension_name.Clear()
        tbox_age.Clear()
        tbox_gender.Clear()
        tbox_contact_number.Clear()
        tbox_email_address.Clear()

    End Sub

    Private Sub tboxSearch_TextChanged(sender As Object, e As EventArgs) Handles tboxSearch.TextChanged

        Try
            refresh_data("SELECT * FROM tb_employee WHERE first_name LIKE '%" & tboxSearch.Text & "%'
                            OR last_name LIKE '%" & tboxSearch.Text & "%' 
                            OR employee_id LIKE '%" & tboxSearch.Text & "%' ", DTGLIST)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hiding form once triggered by designated button
        Me.Hide()
        Form2.Show()
    End Sub
End Class