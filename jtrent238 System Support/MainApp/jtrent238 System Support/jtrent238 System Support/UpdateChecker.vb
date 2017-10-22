Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data
Public Class UpdateChecker

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Dim version_file As String = "https://jtrent238.github.io/jtrent238-System-Support/version_file"
    Dim UpdateFound As Boolean


    Private Sub UpdateChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim address As String = version_file
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label2.Text = My.Application.Info.Version.ToString
            Label3.Text = reader.ReadToEnd

            If Label2.Text.ToString IsNot Label3.Text.ToString Then Button2.Enabled.Equals(True)
            If Label2.Text.ToString Is Label3.Text.ToString Then Button2.Enabled.Equals(False)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Timer1.Start()
            ProgressBar1.Value() = 0

            Dim address As String = version_file
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label2.Text = My.Application.Info.Version.ToString
            Label3.Text = reader.ReadToEnd


            If Label2.Text.ToString = Label3.Text.ToString Then
                Button2.Enabled.Equals(False)
            End If

            If Label2.Text.ToString <> Label3.Text.ToString Then
                Button2.Enabled.Equals(True)
            End If
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value < 100 Then ProgressBar1.Value = ProgressBar1.Value + 1


            If Label2.Text.ToString = Label3.Text.ToString Then
                Dim UpdateFound As Boolean = False
            End If

            If Label2.Text.ToString <> Label3.Text.ToString Then
                Dim UpdateFound As Boolean = False
            End If
            If ProgressBar1.Value = 100 Then
                If UpdateFound = True Then
                    Dim address As String = version_file
                    Dim client As WebClient = New WebClient()
                    Dim reader As StreamReader = New StreamReader(client.OpenRead(address))

                    Dim UpdateFound_Msg = "Update Found: " + reader.ReadToEnd
                    MsgBox("Check Complete!" + UpdateFound_Msg)
                    Label5.Text = "Update Found: " + reader.ReadToEnd
                End If

                If UpdateFound = False Then
                    Dim address As String = version_file
                    Dim client As WebClient = New WebClient()
                    Dim reader As StreamReader = New StreamReader(client.OpenRead(address))

                    Dim UpdateFound_Msg = "No Update Found: You have latest!"
                    MsgBox("Check Complete!" + UpdateFound_Msg)
                    Label5.Text = "No Update found"
                End If

            End If
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = "manualupdate.bat"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class