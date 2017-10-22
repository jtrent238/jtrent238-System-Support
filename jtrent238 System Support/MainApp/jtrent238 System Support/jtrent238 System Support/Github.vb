Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data
Public Class Github

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")

    Private Sub Github_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = "https://github.com/jtrent238/jtrent238-System-Support"
            'WebBrowser1.Navigate("https://github.com/jtrent238/jtrent238-System-Support")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim webPage As String = TextBox1.Text.Trim
            WebBrowser1.Navigate(webPage)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            WebBrowser1.Refresh()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If WebBrowser1.CanGoBack Then WebBrowser1.GoBack()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then WebBrowser1.GoForward()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            WebBrowser1.Stop()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            WebBrowser1.GoHome()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class