Public Class Header
    Inherits System.Windows.Forms.Label


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
        'Me.AutoSize = False
        'Me.MaximumSize = (FixedWidthInteger, 0)
        'Me.Anchor = AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
        Me.Location = New Point(20, 10)

    End Sub


    Public Sub New()

        'Making Existing Button Transparent
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = Color.DarkGray


        'ReDevelop the existing Button adding image to a transparent image
        Me.BackgroundImage = My.Resources.Header
        Me.BackgroundImageLayout = ImageLayout.Stretch


        Me.ForeColor = Color.Black
        Me.Font = New Drawing.Font("Segoe UI", 10, FontStyle.Bold)
        'Me.Margin = New Padding(5)
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.Padding = New Padding(5)



    End Sub

End Class
