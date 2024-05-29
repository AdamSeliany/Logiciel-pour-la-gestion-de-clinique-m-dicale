Imports System.Data.SqlClient
Public Class rendez_vous
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Public Sub Filedepatients()
        Con.Open()
        Dim sql = "select * from PatientTbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        patient_btn.DataSource = Tbl
        patient_btn.DisplayMember = "PatName"
        patient_btn.ValueMember = "PatName"
        Con.Close()
    End Sub
    Public Sub Filltraitment()
        Con.Open()
        Dim sql = "select * from TreatmentTbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        treat_btn.DataSource = Tbl
        treat_btn.DisplayMember = "TrName"
        treat_btn.ValueMember = "TrName"
        Con.Close()
    End Sub
    Public Sub populate()
        Con.Close()
        Dim query = "Select * From RendezVousRbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        rendervous.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        patient_btn.SelectedIndex = -1
        treat_btn.SelectedIndex = -1

    End Sub


    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If treat_btn.SelectedIndex = -1 Or patient_btn.SelectedIndex = -1 Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "insert into RendezVousRbl values('" + patient_btn.SelectedValue.ToString() + "','" + treat_btn.SelectedValue.ToString() + "','" + date_btn.Value.Date.ToString("yyyy-MM-dd") + "','" + time_btn.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Rendez-Vous enregistre avec succes!")
            Con.Close()
            populate()
            Reset()
        End If
    End Sub
    Dim Key = 0

    Private Sub rendervous_Click(sender As Object, e As EventArgs) Handles rendervous.Click
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(rendervous.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRowView = CType(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        If row IsNot Nothing Then
            patient_btn.SelectedValue = row(1).ToString()
            treat_btn.SelectedValue = row(2).ToString()
            date_btn.Text = row(3).ToString()
            time_btn.Text = row(4).ToString()


            If patient_btn.SelectedIndex = -1 Then
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
            Dim query = "Delete from RendezVousRbl where ApId=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Rendez Vous supprime avec succes!")
            Con.Close()
            populate()
            Reset()
        End If
    End Sub


    Private Sub modifier_btn_Click(sender As Object, e As EventArgs) Handles modifier_btn.Click
        If treat_btn.SelectedIndex = -1 Or patient_btn.SelectedIndex = -1 Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Update RendezVousRbl set ApPat='" & patient_btn.SelectedValue.ToString() & "',ApTreat='" & treat_btn.SelectedValue.ToString() & "',ApDate='" & date_btn.Value.Date.ToString("yyyy-MM-dd") & "',ApTime='" & time_btn.Text & "'where ApId=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Rendez Vous mise a jour avec succes!")
            Con.Close()
            populate()
            Reset()
        End If
    End Sub
End Class