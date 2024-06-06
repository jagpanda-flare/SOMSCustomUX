Public Class GroupBox
    Inherits System.Windows.Forms.GroupBox


    Private _borderColor As Color
    Private _borderWidth As Integer
    Private _borderStyle As ButtonBorderStyle
    Private _headerColor As Color


    Public Sub New()
        MyBase.New
        Me._borderColor = Color.Blue      '-- In here code your default VB.net colour name

        _borderWidth = 3

        _borderStyle = ButtonBorderStyle.Solid

        _headerColor = Color.DeepSkyBlue


        Me.FlatStyle = FlatStyle.Flat

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent





    End Sub

    Public Property BorderColour() As Color
        Get
            Return Me._borderColor

        End Get

        Set(ByVal value As Color)
            Me._borderColor = value
        End Set

    End Property

    Public Property HeaderColour() As Color
        Get
            Return Me._headerColor

        End Get

        Set(ByVal value As Color)
            Me._headerColor = value
        End Set

    End Property


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)

        'Dim borderRect As Rectangle = e.ClipRectangle
        'borderRect.Y = CInt((borderRect.Y + (tSize.Height / 2)) + 10)
        'borderRect.Height = CInt((borderRect.Height - (tSize.Height / 2)) - 20)
        'ControlPaint.DrawBorder(e.Graphics, borderRect, _borderColor, _borderWidth, _borderStyle, _borderColor, _borderWidth, _borderStyle, _borderColor, _borderWidth, _borderStyle, _borderColor, _borderWidth, _borderStyle)

        Dim g As Graphics = e.Graphics
        g.DrawRoundedRectangle(New Pen(_borderColor, _borderWidth), 0 + 1, 20, Me.Width - 4, Me.Height - 30, 20)

        Dim textRect As Rectangle = e.ClipRectangle
        textRect.Y = (textRect.Y + 10)
        textRect.X = (textRect.X + 10)
        textRect.Width = tSize.Width + 10
        textRect.Height = tSize.Height
        'e.Graphics.FillRectangle(New SolidBrush(_backColor), textRect)
        g.FillRoundedRectangle(New SolidBrush(_headerColor), textRect.X, textRect.Y, textRect.Width, textRect.Height, 10)

        textRect.X = (textRect.X + 5)
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect)
    End Sub

End Class
