Public Class SysClient

    Dim cpt1 = 0
    Public Sub icr()

        lab_client.Text = cpt1.ToString
        cpt1 = cpt1 + 1
        InitializeComponent()
    End Sub
    Public Sub video()
        AxWindowsMediaPlayer2.URL = "D:\New\ZIP Disk Music Recorder, the BOSS BR-8.mp4"

    End Sub

End Class