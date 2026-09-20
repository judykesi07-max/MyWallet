<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeposit
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
        txtAmount = New TextBox()
        Label1 = New Label()
        btnSaveDeposit = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblTitle.Location = New Point(130, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(161, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Deposit money"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(160, 82)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(190, 23)
        txtAmount.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label1.Location = New Point(70, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 2
        Label1.Text = "Amount:"
        ' 
        ' btnSaveDeposit
        ' 
        btnSaveDeposit.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSaveDeposit.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveDeposit.ForeColor = Color.White
        btnSaveDeposit.Location = New Point(120, 145)
        btnSaveDeposit.Name = "btnSaveDeposit"
        btnSaveDeposit.Size = New Size(85, 32)
        btnSaveDeposit.TabIndex = 3
        btnSaveDeposit.Text = "Deposit"
        btnSaveDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnCancel.Location = New Point(220, 145)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(85, 32)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FormDeposit
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(404, 211)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveDeposit)
        Controls.Add(Label1)
        Controls.Add(txtAmount)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormDeposit"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormDeposit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveDeposit As Button
    Friend WithEvents btnCancel As Button
End Class
