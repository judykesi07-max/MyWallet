Imports Microsoft.Data.SqlClient

Public Class UserService

    Public Function Login(username As String, password As String) As Boolean

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT COUNT(*) FROM Users 
             WHERE Username=@Username 
             AND Password=@Password"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim result As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                Return result > 0

            End Using

        End Using

    End Function

End Class
