Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class home
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Public Sub populate()
        Con.Close()
        Dim query = "Select * From PatientTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        patientdyg.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        PatName.Text = ""
        PatAddr.Text = ""
        PatPhone.Text = ""
        Allergies.Text = ""
        DOBDate.Value = "01/01/1962"
    End Sub


    Private Sub patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub
    Dim Key = 0
    Private Sub gridControl1_Click(sender As Object, e As EventArgs) Handles patientdyg.Click
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(patientdyg.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRowView = CType(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        If row IsNot Nothing Then
            PatName.Text = row(1).ToString()
            PatPhone.Text = row(2).ToString()
            PatAddr.Text = row(3).ToString()
            DOBDate.Value = DateTime.Parse(row(4).ToString())
            Gen.SelectedItem = row(5).ToString()
            Allergies.Text = row(6).ToString()

            If PatName.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row(0))
            End If
        End If
        btn_edit.Visible = True
        btn_del.Visible = True
        btn_save.Visible = False
        btn_annulee.Visible = True
    End Sub


    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        If PatName.Text = "" Or PatAddr.Text = "" Or PatPhone.Text = "" Or Allergies.Text = "" Or Gen.SelectedIndex = -1 Then
            MsgBox("Les informations ne sont pas complètes")
        Else
            Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
                Con.Open()
                Dim query As String = "INSERT INTO PatientTbl (PatName, PatPhone, PatAdd, PatDOB, PatGen, PatAll) VALUES (@PatName, @PatPhone, @PatAddr, @DOB, @Gen, @Allergies)"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@PatName", PatName.Text)
                cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text)
                cmd.Parameters.AddWithValue("@PatAddr", PatAddr.Text)
                cmd.Parameters.AddWithValue("@DOB", DOBDate.Value.Date)
                cmd.Parameters.AddWithValue("@Gen", Gen.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Allergies", Allergies.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Patient enregistré avec succès!")
                populate()
                Reset()
            End Using
        End If
    End Sub


    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btn_edit.Click
        If PatName.Text = "" Or PatAddr.Text = "" Or PatPhone.Text = "" Or Allergies.Text = "" Or Gen.SelectedIndex = -1 Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Update PatientTbl set PatName='" & PatName.Text & "',PatPhone='" & PatPhone.Text & "',PatAdd='" & PatAddr.Text & "',PatDOB='" & DOBDate.Value.Date.ToString("yyyy-MM-dd") & "',PatGen='" & Gen.SelectedItem.ToString & "',PatAll='" & Allergies.Text & "' where PatId=" & Key & " "
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient information mise a jour avec succes!")
            Con.Close()
            populate()
            Reset()
        End If
        btn_del.Visible = False
        btn_edit.Visible = False
        btn_save.Visible = True


    End Sub

    Private Sub btn_del_Click_1(sender As Object, e As EventArgs) Handles btn_del.Click
        If Key = 0 Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "Delete from PatientTbl where PatId=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient supprime avec succes!")
            Con.Close()
            populate()
            Reset()
        End If
        btn_del.Visible = False
        btn_edit.Visible = False
        btn_save.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Log As New sysAdmin()
        Log.Show()
        Dim dz As New SysClient()
        dz.Show()

    End Sub

    Private Sub pn_home_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pn_home_Paint_1(sender As Object, e As PaintEventArgs) Handles pn_home.Paint

    End Sub

    Private Sub btn_annulee_Click(sender As Object, e As EventArgs) Handles btn_annulee.Click
        Reset()
    End Sub


End Class