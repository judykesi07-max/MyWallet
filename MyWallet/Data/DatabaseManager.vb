Imports Microsoft.Data.SqlClient

Public Class DatabaseManager

    Private Shared ReadOnly connectionString As String =
        "Data Source=WINDOWS\SQLEXPRESS;" &
        "Initial Catalog=MyWallet;" &
        "Integrated Security=True;" &
        "TrustServerCertificate=True"

    Public Shared Function GetConnection() As SqlConnection

        Return New SqlConnection(connectionString)

    End Function

End Class