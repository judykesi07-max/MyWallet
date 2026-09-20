<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Username = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnRegister = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(285, 92)
        Username.Name = "Username"
        Username.Size = New Size(69, 17)
        Username.TabIndex = 0
        Username.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(430, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 17)
        Label1.TabIndex = 1
        Label1.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(285, 110)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(412, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(343, 176)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(111, 34)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Create Account"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(285, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 21)
        Label2.TabIndex = 5
        Label2.Text = "Create your MyWallet account"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(Username)
        Name = "RegisterForm"
        Text = "Create Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegUsername As TextBox
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
