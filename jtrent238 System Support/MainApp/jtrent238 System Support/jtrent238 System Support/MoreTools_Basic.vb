Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class MoreTools_Basic

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")


    Private Sub CPUZ_Click(sender As Object, e As EventArgs) Handles CPUZ.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "CPU-Z.exe"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub GPUZ_Click(sender As Object, e As EventArgs) Handles GPUZ.Click
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
    Private Sub RapidCRC_Click(sender As Object, e As EventArgs) Handles RapidCRC.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "RapidCRC.exe"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class