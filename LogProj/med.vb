Imports System.Data.SqlClient
Public Class med
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Public Sub Trpopulate()
        Con.Close()
        Dim query = "Select * From MedTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        medyg.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        medName.Text = ""
        MedPrix.Text = ""
        MedDesc.Text = ""
        Key = 0
    End Sub
    Private Sub enregister_btn_Click(sender As Object, e As EventArgs) Handles enregister_btn.Click
        If medName.Text = "" Or MedPrix.Text = "" Or MedDesc.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "insert into MedTbl values('" + medName.Text + "','" + MedPrix.Text + "','" + MedDesc.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicament enregistre avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub


    Dim Key = 0
    Private Sub Medyg_Click(sender As Object, e As EventArgs) Handles medyg.Click
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(medyg.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRowView = CType(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        If row IsNot Nothing Then
            medName.Text = row(1).ToString()
            MedPrix.Text = row(2).ToString()
            MedDesc.Text = row(3).ToString()


            If medName.Text = "" Then
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
            Dim query = "Delete from MedTbl where MedId=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("medicament supprime avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub

    Private Sub modifier_btn_Click(sender As Object, e As EventArgs) Handles modifier_btn.Click
        If medName.Text = "" Or MedPrix.Text = "" Or MedDesc.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Update MedTbl set medName='" & medName.Text & "',MedPrix='" & MedPrix.Text & "',MedDesc='" & MedDesc.Text & "' where MedId=" & Key & " "
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("le medicament information mise a jour avec succes!")
            Con.Close()
            Trpopulate()
            Reset()
        End If
    End Sub

End Class