Public Class admin
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        childform(Form3)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        ElseIf result = DialogResult.No Then

        End If


    End Sub
    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        childform(Form4)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        childform(Form5)
    End Sub
End Class