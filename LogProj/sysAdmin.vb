Imports LogProj.SysClient
Public Class sysAdmin
    Public Shared cpt As Integer = 0
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SysClient.icr()
        nbr.Text = cpt.ToString
        cpt = cpt + 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Video Files (*.mp4;*.avi;*.wmv;*.mov)|*.mp4;*.avi;*.wmv;*.mov",
            .Title = "Select a Video File"
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the URL property of the Windows Media Player control to the selected file's path
            AxWindowsMediaPlayer1.URL = openFileDialog1.FileName

        End If
    End Sub


End Class