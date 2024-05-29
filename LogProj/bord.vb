Imports System.Data.SqlClient
Public Class bord

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Public Sub BRI()
        Con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Select count(*) from PatientTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable()
        adapter.Fill(dt)
        patient.Text = dt.Rows(0)(0).ToString()
        Con.Close()
    End Sub
    Public Sub RSI()
        Con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Select count(*) from TreatmentTbl", Con)
        Dim treat As Integer = Convert.ToInt32(cmd.ExecuteScalar)
        traitment.Text = treat.ToString
        Con.Close()
    End Sub
    Public Sub BVAJ()
        Con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Select count(*) from ordonnanceTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable()
        adapter.Fill(dt)
        ordannance.Text = dt.Rows(0)(0).ToString()
        Con.Close()
    End Sub

    Public Sub TQG()
        Try
            Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adam Seliani\Documents\DentistDbVb.mdf;Integrated Security=True;Connect Timeout=30")
                Con.Open()

                ' الحصول على الشهر والسنة الحاليين
                Dim currentMonth As Integer = DateTime.Today.Month
                Dim currentYear As Integer = DateTime.Today.Year

                ' استعلام SQL لاسترجاع عدد السجلات في الشهر الحالي فقط
                Dim sql As String = $"SELECT COUNT(*) FROM ordonnanceTbl WHERE MONTH([Date]) = {currentMonth} AND YEAR([Date]) = {currentYear}"

                Dim cmd As New SqlCommand(sql, Con)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' عرض عدد السجلات في عنصر النص
                ordannance.Text = count.ToString()
            End Using
        Catch ex As SqlException
            MessageBox.Show("حدث خطأ في قاعدة البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("حدث خطأ غير متوقع: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub pn_bord_Paint(sender As Object, e As PaintEventArgs) Handles pn_bord.Paint
        BRI()
        BVAJ()
        RSI()
    End Sub
End Class