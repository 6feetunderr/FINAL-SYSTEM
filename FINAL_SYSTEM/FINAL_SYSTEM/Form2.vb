Public Class Form2
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            insert_data("INSERT INTO `tb_attendance2`(`attendance_ID`, `employee_ID`, `job_name`, `date`) 
                        VALUES ('" & tbox_AttendanceID.Text & "',
                                '" & tbox_EmployeeID.Text & "',
                                '" & tbox_job_name.Text & "',
                                '" & dtpDateTime.Value & "'
                                )")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM tb_attendance2", DTGLIST)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            edit_data("UPDATE tb_attendance2 SET attendance_ID= '" & tbox_AttendanceID.Text & "',
                                            employee_ID= '" & tbox_EmployeeID.Text & "',
                                            job_name= '" & tbox_job_name.Text & "', 
                                            date='" & dtpDateTime.Value & "'
                                            WHERE attendance_ID='" & tbox_AttendanceID.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DTGLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLIST.CellContentClick
        tbox_AttendanceID.Text = DTGLIST.CurrentRow.Cells(0).Value
        tbox_EmployeeID.Text = DTGLIST.CurrentRow.Cells(1).Value
        tbox_job_name.Text = DTGLIST.CurrentRow.Cells(2).Value
        dtpDateTime.Value = DTGLIST.CurrentRow.Cells(3).Value

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tb_attendance2 WHERE attendance_ID='" & tbox_AttendanceID.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        tbox_AttendanceID.Text = ""
        tbox_EmployeeID.Clear()
        tbox_job_name.Clear()



    End Sub

    Private Sub tbox_search_TextChanged(sender As Object, e As EventArgs) Handles tbox_search.TextChanged
        Try
            refresh_data("SELECT * FROM tb_attendance2 WHERE attendance_ID LIKE '%" & tbox_search.Text & "%'", DTGLIST)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpDateTime_ValueChanged(sender As Object, e As EventArgs)
        MessageBox.Show(dtpDateTime.Value.ToShortDateString())
        MessageBox.Show(dtpDateTime.Value.ToLongTimeString())



    End Sub
End Class