<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWithdraw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        Label1 = New Label()
        txtAmount = New TextBox()
        cmbCategory = New ComboBox()
        btnSaveWithdraw = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(130, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(184, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Withdraw Money"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 17)
        Label1.TabIndex = 1
        Label1.Text = "Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(130, 84)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(155, 23)
        txtAmount.TabIndex = 2
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Food", "Transport", "Airtime", "Rent", "Shopping", "Entertainment", "Education", "Health", "Other"})
        cmbCategory.Location = New Point(291, 85)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(121, 23)
        cmbCategory.TabIndex = 3
        ' 
        ' btnSaveWithdraw
        ' 
        btnSaveWithdraw.BackColor = Color.Green
        btnSaveWithdraw.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveWithdraw.ForeColor = Color.White
        btnSaveWithdraw.Location = New Point(120, 145)
        btnSaveWithdraw.Name = "btnSaveWithdraw"
        btnSaveWithdraw.Size = New Size(85, 32)
        btnSaveWithdraw.TabIndex = 4
        btnSaveWithdraw.Text = "Withdraw"
        btnSaveWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(220, 145)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(85, 32)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FormWithdraw
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 211)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveWithdraw)
        Controls.Add(cmbCategory)
        Controls.Add(txtAmount)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "FormWithdraw"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormWithdraw"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnSaveWithdraw As Button
    Friend WithEvents btnCancel As Button
End Class
