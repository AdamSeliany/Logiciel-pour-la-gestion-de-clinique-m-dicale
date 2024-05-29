Imports System.ComponentModel
Imports System.Text


Partial Public Class start
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressbar.Value < progressbar.Maximum Then
            progressbar.Increment(1)

        Else

            pn_start.Controls.Clear()
            loginpage.pn_login.Dock = DockStyle.Fill
            pn_start.Controls.Add(loginpage.pn_login)


            Timer1.Enabled = False

        End If
    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the maximum value of the ProgressBar to the number of ticks you want
        progressbar.Maximum = 10
        ' Start the timer
        Timer1.Start()

    End Sub
End Class
