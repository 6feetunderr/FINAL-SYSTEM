Public Class login_form
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = tbox_username.Text
        password = tbox_password.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            'AUTO HIDE IF LOGIN SUCCESSFULLY
            Me.Hide()
            EMPLOYEE_INFORMATION.Show()

            MessageBox.Show("YOU ARE LOGIN!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("FAILED TO LOGIN!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If



    End Sub
End Class
