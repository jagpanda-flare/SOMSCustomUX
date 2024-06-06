﻿Public Class StandardButton
    Inherits System.Windows.Forms.Button

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here

    End Sub


    Public Sub New()

        'Making Existing Button Transparent
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.MouseDownBackColor = Color.Transparent
        Me.FlatAppearance.MouseOverBackColor = Color.Transparent
        Me.BackColor = Color.Transparent

        'ReDevelop the existing Button adding image to a transparent image
        Me.BackgroundImage = My.Resources.StandardButton

        Me.BackgroundImageLayout = ImageLayout.Stretch

        Me.ForeColor = Color.White
        'Me.Text = ""
        Me.Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)



    End Sub

End Class
