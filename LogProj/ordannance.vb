Imports System.Data.SqlClient
Public Class ordannance
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Public Sub Filedepatients()
        Con.Open()
        Dim sql = "select * from RendezVousRbl "
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        patient_btn.DataSource = Tbl
        patient_btn.DisplayMember = "ApPat"
        patient_btn.ValueMember = "ApPat"
        Con.Close()
    End Sub
    Public Sub populate()
        Con.Close()
        Dim query = "Select * From ordonnanceTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ordo.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub reset()
        patient_btn.SelectedIndex = -1
        TreatNameTb.Text = ""
        Qty.Text = ""

        btn_prix.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TreatNameTb.Text = "" Or Qty.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query = "insert into ordonnanceTbl values('" + patient_btn.SelectedValue.ToString() + "','" + TreatNameTb.Text + "','" + btn_prix.Text + "','" + MedChc.Text + "','" + Qty.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ordonnance enregistre avec succes!")
            Con.Close()
            populate()
            reset()
        End If
    End Sub
    Private Sub univ()
        Con.Open()
        Dim query = "Select * from RendezVousRbl where ApPat='" + patient_btn.SelectedValue.ToString() + "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            TreatNameTb.Text = reader(2).ToString
        End While
        Con.Close()
        Con.Open()
        Dim query1 = "Select * from TreatmentTbl where TrName='" + TreatNameTb.Text + "'"
        Dim cmd1 As New SqlCommand(query1, Con)
        Dim dt1 As New DataTable
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader()
        While reader1.Read
            btn_prix.Text = reader1(2).ToString
        End While
        Con.Close()
    End Sub


    Private Sub patient_btn_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles patient_btn.SelectionChangeCommitted
        univ()
        deva()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
    Dim Key = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TreatNameTb.Text = "" Or Qty.Text = "" Or btn_prix.Text = "" Then
            MsgBox("Les Information n'est pas complet")
        Else
            Con.Open()
            Dim query As String = "UPDATE ordonnanceTbl SET PatName='" & patient_btn.SelectedValue.ToString() & "', TreatName='" & TreatNameTb.Text & "', TreatPrix='" & btn_prix.Text & "', Medicament='" & MedChc.Text & "', Qty=" & Qty.Text & " WHERE PId=" & Key

            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ordonnance modifie avec succes!")
            Con.Close()
            populate()
            reset()
        End If
    End Sub

    Private Sub ordo_Click(sender As Object, e As EventArgs) Handles ordo.Click
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(ordo.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRowView = CType(gridView.GetRow(gridView.FocusedRowHandle), DataRowView)

        If row IsNot Nothing Then
            patient_btn.SelectedValue = row(1).ToString()
            TreatNameTb.Text = row(2).ToString()
            btn_prix.Text = row(3).ToString()
            MedChc.Text = row(4).ToString()
            Qty.Text = row(5).ToString()


            If TreatNameTb.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row(0))
            End If
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("List de Rendez Vous", New Font("Century Gothic", 25), Brushes.MidnightBlue, 300, 40)
        e.Graphics.DrawString("====Clinic Annaba====", New Font("Century Gothic", 16), Brushes.MidnightBlue, 320, 85)
        Dim bm As New Bitmap(Me.ordo.Width, Me.ordo.Height)
        ordo.DrawToBitmap(bm, New Rectangle(0, 0, Me.ordo.Width, Me.ordo.Height))
        e.Graphics.DrawImage(bm, 2, 120)
        e.Graphics.DrawString("===============================================", New Font("Century Gothic", 15), Brushes.Crimson, 48, 1100)

    End Sub

    Private Sub deva()
        ' Set up connection string
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30"

        ' Create connection
        Using connection As New SqlConnection(connectionString)
            Try
                ' Open connection
                connection.Open()

                ' SQL query to retrieve medication names from MedTbl
                Dim query As String = "SELECT MedName FROM MedTbl"

                ' Create command
                Using command As New SqlCommand(query, connection)
                    ' Execute command and read data
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Clear CheckedListBox items
                        MedChc.Items.Clear()

                        ' Loop through the data and add medication names to the CheckedListBox
                        While reader.Read()
                            MedChc.Items.Add(reader("MedName").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Handle exceptions
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


End Class