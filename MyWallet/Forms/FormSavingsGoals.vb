Public Class FormSavingsGoals

    Public currentUser As String


    Private Sub FormSavingsGoals_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgvGoals.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGoals.MultiSelect = False

        LoadGoals()

    End Sub


    Private Sub LoadGoals()

        Try

            Dim service As New SavingsGoalService()

            dgvGoals.DataSource = service.GetGoals(currentUser)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub btnSaveGoal_Click(sender As Object, e As EventArgs) Handles btnSaveGoal.Click

        If txtGoalName.Text.Trim() = "" Then

            MessageBox.Show("Enter a goal name.")
            Exit Sub

        End If


        Dim target As Decimal

        If Not Decimal.TryParse(txtTargetAmount.Text, target) Then

            MessageBox.Show("Enter a valid target amount.")
            Exit Sub

        End If


        Try

            Dim service As New SavingsGoalService()

            service.CreateGoal(currentUser,
                               txtGoalName.Text.Trim(),
                               target)


            MessageBox.Show("Savings goal created successfully!")


            txtGoalName.Clear()
            txtTargetAmount.Clear()


            LoadGoals()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub btnAddMoney_Click(sender As Object, e As EventArgs) Handles btnAddMoney.Click

        If dgvGoals.SelectedRows.Count = 0 Then

            MessageBox.Show("Select a savings goal first.")
            Exit Sub

        End If


        Dim amount As Decimal

        If Not Decimal.TryParse(txtContributionAmount.Text, amount) Then

            MessageBox.Show("Enter a valid amount.")
            Exit Sub

        End If


        Dim goalID As Integer =
        Convert.ToInt32(dgvGoals.SelectedRows(0).Cells("GoalID").Value)


        Try

            Dim service As New SavingsGoalService()

            service.AddMoney(goalID, amount)


            MessageBox.Show("Money added successfully!")


            txtContributionAmount.Clear()

            LoadGoals()

            ShowProgress()

            CheckGoalCompletion()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub ShowProgress()

        If dgvGoals.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        Dim target As Decimal =
            Convert.ToDecimal(dgvGoals.SelectedRows(0).Cells("TargetAmount").Value)


        Dim saved As Decimal =
            Convert.ToDecimal(dgvGoals.SelectedRows(0).Cells("SavedAmount").Value)


        If target > 0 Then

            Dim percentage As Integer =
                CInt((saved / target) * 100)


            If percentage > 100 Then
                percentage = 100
            End If


            ProgressGoal.Value = percentage

            lblProgress.Text = "Progress: " & percentage & "%"


        End If

    End Sub

    Private Sub dgvGoals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGoals.CellContentClick
        ShowProgress()
    End Sub
    Private Sub CheckGoalCompletion()

        If dgvGoals.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        Dim goalName As String =
            dgvGoals.SelectedRows(0).Cells("GoalName").Value.ToString()


        Dim target As Decimal =
            Convert.ToDecimal(dgvGoals.SelectedRows(0).Cells("TargetAmount").Value)


        Dim saved As Decimal =
            Convert.ToDecimal(dgvGoals.SelectedRows(0).Cells("SavedAmount").Value)


        If saved >= target Then

            MessageBox.Show(
                "🎉 Congratulations!" & vbCrLf &
                "You have completed your " & goalName & " savings goal!",
                "Goal Completed"
            )

        End If

    End Sub
End Class