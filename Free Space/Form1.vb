Public Class Login

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged

    End Sub


    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Close()

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim AdminUsername As String = "admin"
        Dim AdminPassword As String = "password"
        If usertxt.Text = AdminUsername AndAlso passtxt.Text = AdminPassword Then
            admin.Show()
            Me.Hide()

        End If ' 
        ' End Sub
    End Sub


End Class
