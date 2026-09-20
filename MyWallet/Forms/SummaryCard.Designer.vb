<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        picIcon = New PictureBox()
        lblTitle = New Label()
        lblValue = New Label()
        pnlCard = New Panel()
        lblSubtitle = New Label()
        pnlIcon = New Panel()
        CType(picIcon, ComponentModel.ISupportInitialize).BeginInit()
        pnlCard.SuspendLayout()
        pnlIcon.SuspendLayout()
        SuspendLayout()
        ' 
        ' picIcon
        ' 
        picIcon.BackColor = Color.Transparent
        picIcon.Dock = DockStyle.Fill
        picIcon.Location = New Point(0, 0)
        picIcon.Name = "picIcon"
        picIcon.Padding = New Padding(10)
        picIcon.Size = New Size(48, 48)
        picIcon.SizeMode = PictureBoxSizeMode.Zoom
        picIcon.TabIndex = 0
        picIcon.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 8.5F)
        lblTitle.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        lblTitle.Location = New Point(72, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(91, 15)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Current Balance"
        ' 
        ' lblValue
        ' 
        lblValue.AutoSize = True
        lblValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblValue.ForeColor = Color.RoyalBlue
        lblValue.Location = New Point(72, 31)
        lblValue.Name = "lblValue"
        lblValue.Size = New Size(88, 25)
        lblValue.TabIndex = 2
        lblValue.Text = "KES 0.00"
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(lblValue)
        pnlCard.Controls.Add(lblSubtitle)
        pnlCard.Controls.Add(pnlIcon)
        pnlCard.Controls.Add(lblTitle)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Margin = New Padding(0)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(220, 90)
        pnlCard.TabIndex = 5
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.ForeColor = Color.Gray
        lblSubtitle.Location = New Point(69, 58)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(99, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Available Balance"
        ' 
        ' pnlIcon
        ' 
        pnlIcon.BackColor = Color.LightBlue
        pnlIcon.Controls.Add(picIcon)
        pnlIcon.Location = New Point(16, 14)
        pnlIcon.Name = "pnlIcon"
        pnlIcon.Size = New Size(48, 48)
        pnlIcon.TabIndex = 0
        ' 
        ' SummaryCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(pnlCard)
        Margin = New Padding(15)
        Name = "SummaryCard"
        Size = New Size(220, 90)
        CType(picIcon, ComponentModel.ISupportInitialize).EndInit()
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlIcon.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents pnlCard As Panel
    Friend WithEvents pnlIcon As Panel
    Friend WithEvents lblSubtitle As Label


End Class
