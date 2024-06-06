Public Class AppBar
    Inherits System.Windows.Forms.Label

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
        Me.AutoSize = False
        'Me.MaximumSize = (FixedWidthInteger, 0)
        Me.Anchor = AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
        Me.Location = New Point(0, 0)
        Me.Height = 50
        Me.Width = 3000


        Me.Text = ""

    End Sub


    Public Sub New()

        'Making Existing Button Transparent
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = Color.Transparent

        'ReDevelop the existing Button adding image to a transparent image
        'Me.BackgroundImage = My.Resources.StandardButton
        'Me.BackgroundImageLayout = ImageLayout.Stretch

        Me.BackColor = Color.DimGray

        'Me.Text = ""
        'Me.Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)

        Me.AutoSize = False

        Me.Anchor = AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
        Me.Height = 50

    End Sub
End Class
