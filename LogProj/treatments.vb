Imports System.Data.SqlClient

Public Class treatments
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Public Sub Trpopulate()
        Con.Close()
        Dim query = "Select * From TreatmentTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        treatmentdyg.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        TrName.Text = ""
        TrPrix.Text = ""
        TrDesc.Text = ""
        Key = 0
    End Sub
    Private Sub enregister_btn_Click(sender As Object, e As EventArgs) Handles enregister_btn.Click
        If TrName.Text = "" Or TrPrix.Text = "" Or TrDesc.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "insert into TreatmentTbl values('" + TrName.Text + "','" + TrPrix.Text + "','" + TrDesc.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Traitment enregistre avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub


    Dim Key = 0
    Private Sub treatmentdyg_Click(sender As Object, e As EventArgs) Handles treatmentdyg.Click
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(treatmentdyg.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRowView = CType(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        If row IsNot Nothing Then
            TrName.Text = row(1).ToString()
            TrPrix.Text = row(2).ToString()
            TrDesc.Text = row(3).ToString()


            If TrName.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row(0))
            End If
        End If
    End Sub

    Private Sub supp_btn_Click(sender As Object, e As EventArgs) Handles supp_btn.Click
        If Key = 0 Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Delete from TreatmentTbl where TrId=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Traitment supprime avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub

    Private Sub modifier_btn_Click(sender As Object, e As EventArgs) Handles modifier_btn.Click
        If TrName.Text = "" Or TrPrix.Text = "" Or TrDesc.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Update TreatmentTbl set TrName='" & TrName.Text & "',TrPrix='" & TrPrix.Text & "',TrDesc='" & TrDesc.Text & "' where TrId=" & Key & " "
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Traitment information mise a jour avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub

    Private Sub pn_traitment_Paint(sender As Object, e As PaintEventArgs) Handles pn_traitment.Paint

    End Sub
End Class