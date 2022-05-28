Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Module CRUDCONNECTION_Form2Attendance
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_attendance_database_system")

    End Function
    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable


    'CREATE OR INSERT FUNCTION
    Public Sub insert_data(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN SUCCESSFULY SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If


            End With
            strcon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
    End Sub

    'RETRIEVING DATA
    Public Sub refresh(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()

        End Try

    End Sub

    'THIS IS FOR UPDATING
    Public Sub edit(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show(" DATA FAILED TO EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN SUCCESSFULY EDITED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
            strcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    'FOR DELETING RECORD
    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then


                    MessageBox.Show(" FAILED TO DELETE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN SUCCESSFULY DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                strcon.Close()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub






End Module
