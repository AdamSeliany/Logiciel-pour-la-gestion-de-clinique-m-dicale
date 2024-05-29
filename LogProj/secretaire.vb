Public Class secretaire
    Private Sub btn_pat_Click(sender As Object, e As EventArgs) Handles btn_pat.Click
        pn_container.Controls.Clear()
        home.pn_home.Dock = DockStyle.Fill
        home.populate()
        pn_container.Controls.Add(home.pn_home)
    End Sub


    Private Sub btn_rendez_Click(sender As Object, e As EventArgs) Handles btn_rendez.Click
        pn_container.Controls.Clear()
        rendez_vous.pn_rendezvous.Dock = DockStyle.Fill
        pn_container.Controls.Add(rendez_vous.pn_rendezvous)
        rendez_vous.Filedepatients()
        rendez_vous.Filltraitment()
        rendez_vous.populate()
    End Sub
    Private Sub btn_ordonnance_Click(sender As Object, e As EventArgs) Handles btn_ordonnance.Click
        pn_container.Controls.Clear()
        ordannance.pn_ordanance.Dock = DockStyle.Fill
        ordannance.Filedepatients()
        pn_container.Controls.Add(ordannance.pn_ordanance)
    End Sub

    Private Sub patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pn_container.Controls.Clear()
        home.pn_home.Dock = DockStyle.Fill
        home.populate()
        pn_container.Controls.Add(home.pn_home)
    End Sub

    Private Sub pn_container_Paint(sender As Object, e As PaintEventArgs) Handles pn_container.Paint

    End Sub
End Class
