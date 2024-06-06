Imports System.Drawing.Drawing2D


Public Class GroupPanel
    Inherits Panel

    Private _borderColor As Color
    Private _borderWidth As Integer
    Private _borderStyle As ButtonBorderStyle
    Private _backColor As Color

    Public Sub New()
        MyBase.New
        Me._borderColor = Color.Aqua

        _borderWidth = 3

        _borderStyle = ButtonBorderStyle.Solid

        _backColor = Color.LightGray

    End Sub

    Public Property BorderColour() As Color
        Get
            Return Me._borderColor

        End Get

        Set(ByVal value As Color)
            Me._borderColor = value
        End Set

    End Property

    'Public Property BorderWidth() As Integer
    'Get
    'Return Me._borderWidth
    '
    'End Get
    '
    'Set(ByVal value As Integer)
    'Me._borderWidth = value
    'End Set
    '
    'End Property

    Public Property BackColour() As Color
        Get
            Return Me._backColor

        End Get

        Set(ByVal value As Color)
            Me._backColor = value
        End Set

    End Property


    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)

        MyBase.OnPaintBackground(e)

        Dim g As Graphics = e.Graphics

        g.SmoothingMode = SmoothingMode.AntiAlias



        Dim brush As New LinearGradientBrush(New Point(Me.Width / 2, 0), New Point(Me.Width / 2, Me.Height), SystemColors.GradientInactiveCaption, ControlPaint.Dark(SystemColors.GradientActiveCaption, 0.5F))

        'g.FillRoundedRectangle(brush, 0, 0, Me.Width - 1, Me.Height, 10)

        'g.FillRoundedRectangle(New SolidBrush(Color.FromArgb(100, 118, 173, 218)), 0, 0, Me.Width, Me.Height, 10)

        'g.DrawRoundedRectangle(New Pen(ControlPaint.Light(SystemColors.InactiveBorder, 5.0F)), 0, 0, Me.Width - 1, Me.Height - 1, 10)
        g.DrawRoundedRectangle(New Pen(_borderColor, _borderWidth), 0 + 1, 0 + 1, Me.Width - 3, Me.Height - 3, 20)

    End Sub

End Class
