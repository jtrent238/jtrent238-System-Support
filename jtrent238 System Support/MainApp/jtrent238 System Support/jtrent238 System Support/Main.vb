Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class main

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Dim i2 As Integer = 0
            Dim i As Integer = 10 / i2
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try

        Try
            FileOpen(1, "version.ini", OpenMode.Output)
            Write(1, "Version=" + My.Application.Info.Version.ToString)
            FileClose(1)
            Dim Network As Boolean = My.Computer.Network.IsAvailable
            Dim address As String = "https://jtrent238.github.io/jtrent238-System-Support/version_file"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label2.Text = My.Application.Info.Version.ToString
            If My.Computer.Network.IsAvailable.Equals(True) Then Label3.Text = reader.ReadToEnd Else Label3.Text = "NO INTERNET!"
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try

    End Sub

    Private Sub main_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Try
            NotifyIcon1.BalloonTipTitle = My.Application.Info.ProductName
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Settings.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            About.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "sysinfo.bat"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "sysoutput.txt"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "installedapps.ps1"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "winver.exe"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            'Me.Hide()
            Tuneup.Show()
            'If Tuneup.IsDisposed Then Me.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            UpdateChecker.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/jtrent238/jtrent238-System-Support")
            'Github.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "BGInfo.bat"
            'startInfo.Verb = "runas"
            'startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            MoreTools_Basic.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub WELT_Click(sender As Object, e As EventArgs) Handles WELT.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "WELT.exe"
            'startInfo.Verb = "runas"
            'startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub LaunchTeamViewerButton_Click(sender As Object, e As EventArgs) Handles LaunchTeamViewerButton.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "TeamViewer.exe"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub ButtonContact_Click(sender As Object, e As EventArgs) Handles ButtonContact.Click
        Try
            Contact.Show()

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub ButtonBugReport_Click(sender As Object, e As EventArgs) Handles ButtonBugReport.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/jtrent238/jtrent238-System-Support/issues/new")
            'Github.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class
