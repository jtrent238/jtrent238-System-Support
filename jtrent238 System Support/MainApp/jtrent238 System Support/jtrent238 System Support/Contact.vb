Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class Contact

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try

    End Sub
End Class