
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic


Module Module1
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_attendance_database_system")

    End Function

    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub login(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO LOGIN!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("LOGIN SUCCESSFULY!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If


            End With
            strcon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try

    End Sub




End Module
