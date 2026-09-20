Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing
Public Class SummaryCard
    Inherits UserControl

    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub PnlCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlCard.Paint
        Using pen As New Pen(Color.FromArgb(210, 210, 210), 1)
            Dim rect As New Rectangle(
            0,
            0,
            pnlCard.ClientSize.Width - 1,
            pnlCard.ClientSize.Height - 1
        )

            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CardTitle As String
        Get
            Return lblTitle.Text
        End Get

        Set(value As String)
            lblTitle.Text = value
        End Set
    End Property
    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CardValue As String
        Get
            Return lblValue.Text
        End Get
        Set(value As String)
            lblValue.Text = value
        End Set
    End Property
    Private _cardSubtitle As String = ""
    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CardSubtitle As String
        Get
            Return _cardSubtitle
        End Get
        Set(value As String)
            _cardSubtitle = value
            lblSubtitle.Text = value
        End Set
    End Property

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CardIcon As Image
        Get
            Return picIcon.Image
        End Get
        Set(value As Image)
            picIcon.Image = value
        End Set
    End Property
    Private _iconBackColor As Color = Color.LightBlue

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property IconBackColor As Color
        Get
            Return _iconBackColor
        End Get
        Set(value As Color)
            _iconBackColor = value
            pnlIcon.BackColor = value
        End Set
    End Property

    Private _cardBackColor As Color = Color.White

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CardBackColor As Color
        Get
            Return _cardBackColor
        End Get
        Set(value As Color)
            _cardBackColor = value
            pnlCard.BackColor = value
            Me.Invalidate()
        End Set
    End Property


    Private _radius As Integer = 18
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        Using path As New GraphicsPath()

            path.AddArc(0, 0, _radius, _radius, 180, 90)
            path.AddArc(Me.Width - _radius - 1, 0, _radius, _radius, 270, 90)
            path.AddArc(Me.Width - _radius - 1, Me.Height - _radius - 1, _radius, _radius, 0, 90)
            path.AddArc(0, Me.Height - _radius - 1, _radius, _radius, 90, 90)
            path.CloseFigure()

            Me.Region = New Region(path)

            Using pen As New Pen(Color.FromArgb(235, 235, 235))
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                e.Graphics.DrawPath(pen, path)
            End Using

        End Using

    End Sub


    Private Sub pnlCard_MouseEnter(sender As Object, e As EventArgs) Handles pnlCard.MouseEnter
        pnlCard.BackColor = Color.FromArgb(245, 245, 245)
    End Sub

    Private Sub pnlCard_MouseLeave(sender As Object, e As EventArgs) Handles pnlCard.MouseLeave
        pnlCard.BackColor = _cardBackColor
    End Sub

    Private Sub SummaryCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pnlIcon IsNot Nothing Then

            MakeCircularIcon()

        End If

        pnlCard.BackColor = _cardBackColor
        pnlIcon.BackColor = _iconBackColor

        lblValue.ForeColor = _valueColor
        lblSubtitle.Text = _cardSubtitle

        MakeCircularIcon()

    End Sub
    Private Sub MakeCircularIcon()

        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, pnlIcon.Width, pnlIcon.Height)

        pnlIcon.Region = New Region(path)

    End Sub

    Private _valueColor As Color = Color.RoyalBlue

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property ValueColor As Color
        Get
            Return _valueColor
        End Get
        Set(value As Color)
            _valueColor = value
            lblValue.ForeColor = value
            Me.Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnResize(e As EventArgs)

        MyBase.OnResize(e)

        MakeCircularIcon()

    End Sub

End Class


