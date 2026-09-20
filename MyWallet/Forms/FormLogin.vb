Imports Microsoft.Data.SqlClient

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Using conn As SqlConnection = DatabaseManager.GetConnection()

                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM Users"

                Using cmd As New SqlCommand(query, conn)

                    Dim userCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    ' =====================================================
                    ' FIRST TIME
                    ' =====================================================
                    ' If there are no accounts, automatically open
                    ' the Create Account form.
                    If userCount = 0 Then

                        Me.Hide()

                        Dim reg As New RegisterForm()

                        reg.ShowDialog()

                        ' If the registration form was closed without
                        ' creating an account, show Login again.
                        Me.Show()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to connect to the MyWallet database." &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    ' =========================================================
    ' LOGIN
    ' =========================================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then

            MessageBox.Show("Enter username and password.")
            Exit Sub

        End If

        Dim userService As New UserService()

        If userService.Login(username, password) Then

            MessageBox.Show("Login successful!")

            Dim dashboard As New FormDashboardModern()

            dashboard.currentUser = username

            dashboard.Show()

            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password.")

        End If

    End Sub


    ' =========================================================
    ' CREATE ACCOUNT BUTTON
    ' =========================================================
    Private Sub btnGoRegister_Click(sender As Object, e As EventArgs) Handles btnGoRegister.Click

        Dim reg As New RegisterForm()

        reg.ShowDialog()

    End Sub

End Class

