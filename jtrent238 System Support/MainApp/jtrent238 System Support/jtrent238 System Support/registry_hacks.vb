Imports SharpRaven
Imports SharpRaven.Data

Public Class registry_hacks

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Dim remove_take_ownership = My.Computer.FileSystem.GetTempFileName
    Dim add_take_ownership = My.Computer.FileSystem.GetTempFileName

    Private Sub button_apply_Click(sender As Object, e As EventArgs) Handles button_apply.Click

        If checkbox_take_ownership.Checked = True Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                My.Computer.Network.DownloadFile("https://jtrent238.s-ul.eu/t0xzAv30", add_take_ownership + ".reg")
                startInfo.FileName = "add_take_ownership.reg"
                ''startInfo.FileName = add_take_ownership + ".reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If
        If checkbox_take_ownership.Checked = False Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                My.Computer.Network.DownloadFile("https://jtrent238.s-ul.eu/sqBqBmd7", remove_take_ownership + ".reg")
                startInfo.FileName = "remove_take_ownership.reg"
                ''startInfo.FileName = remove_take_ownership + ".reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If

        If checkbox_windows_update_auto_reboot.Checked = True Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "enable_auto_reboot.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If
        If checkbox_windows_update_auto_reboot.Checked = False Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "disable_auto_reboot.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If

        If checkbox_open_with_notepad.Checked = True Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "add_open_with_notepad.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If
        If checkbox_open_with_notepad.Checked = False Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "remove_open_with_notepad.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If

        If checkbox_add_registry_editor_to_control_panel.Checked = True Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "add_regedit_to_control_panel.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If
        If checkbox_add_registry_editor_to_control_panel.Checked = False Then
            Try
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = "remove_regedit_from_control_panel.reg"
                ''startInfo.Verb = "runas"
                ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
                myprocess.StartInfo = startInfo
                myprocess.Start()
            Catch exception As Exception
                ravenClient.Capture(New SentryEvent(exception))
            End Try
        End If
    End Sub
End Class