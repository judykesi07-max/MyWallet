Imports Microsoft.Data.SqlClient

Public Class RegisterForm

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter a username and password.")
            Exit Sub
        End If

        Try

            Using conn As SqlConnection = DatabaseManager.GetConnection()

                conn.Open()

                ' Check if username already exists
                Dim checkQuery As String =
                    "SELECT COUNT(*) FROM Users WHERE Username=@Username"

                Using checkCmd As New SqlCommand(checkQuery, conn)

                    checkCmd.Parameters.AddWithValue("@Username", username)

                    Dim userExists As Integer =
                        Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show(
                            "That username already exists. Please choose another username.")
                        Exit Sub
                    End If

                End Using


                ' Create the account
                Dim userQuery As String =
                    "INSERT INTO Users (Username, Password) " &
                    "VALUES (@Username, @Password)"

                Using userCmd As New SqlCommand(userQuery, conn)

                    userCmd.Parameters.AddWithValue("@Username", username)
                    userCmd.Parameters.AddWithValue("@Password", password)

                    userCmd.ExecuteNonQuery()

                End Using


                ' Create wallet with zero balance
                Dim walletQuery As String =
                    "INSERT INTO Wallet (Username, Balance) " &
                    "VALUES (@Username, 0)"

                Using walletCmd As New SqlCommand(walletQuery, conn)

                    walletCmd.Parameters.AddWithValue("@Username", username)

                    walletCmd.ExecuteNonQuery()

                End Using

            End Using


            MessageBox.Show(
                "Account created successfully!",
                "Welcome to MyWallet",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            ' Automatically log the new user into the dashboard
            Dim dashboard As New FormDashboardModern()

            dashboard.currentUser = username

            dashboard.Show()

            ' Close the Create Account form
            Me.Close()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to create account." &
                Environment.NewLine &
                ex.Message,
                "Registration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

End Class
