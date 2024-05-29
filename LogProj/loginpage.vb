Public Class loginpage
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Entre username et mot de passe")
        ElseIf username.Text = "admin" And password.Text = "admin" Then
            Dim obj = New patient
            obj.Show()
        ElseIf username.Text = "adem" And password.Text = "1234" Then
            Dim obj = New patient
            obj.Show()
        ElseIf username.Text = "sec" And password.Text = "1234" Then
            Dim obj = New secretaire
            obj.Show()

        Else
            MsgBox("Username ou mot de pas incorrect")
        End If
        Me.Close()
    End Sub

End Class