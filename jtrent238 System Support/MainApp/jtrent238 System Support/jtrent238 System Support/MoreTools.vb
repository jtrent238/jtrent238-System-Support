Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class MoreTools

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Private Sub MoreTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "cpuz_x32.exe"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "GPU-Z.exe"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            ' Get the currently selected item in the ListBox.
            Dim curItem As String = ListBox1.SelectedItem.ToString()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub ListBox1_Clicked(sender As Object, e As EventArgs) Handles ListBox1.Click
        Try
            TextBox1.Text.Equals(ListBox1.SelectedItem.ToString() + "TEST")
            If ListBox1.SelectedIndex.Equals("1") Then
                TextBox1.Text.Equals("TEST CPU-Z INFORMATION! ZZZZZZZ")
                'Else : MessageBox.Show("ERROR! Please Contact jtrent238!")
            End If
            If ListBox1.SelectedItem.ToString().Equals("GPU-Z") Then
                TextBox1.Text.Equals("TEST GPU-Z INFORMATION! XXXXXXX")
                'Else : MessageBox.Show("ERROR! Please Contact jtrent238!")
            End If

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
    
    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click, Button2.Click, Button1.Click
        
    End Sub
End Class