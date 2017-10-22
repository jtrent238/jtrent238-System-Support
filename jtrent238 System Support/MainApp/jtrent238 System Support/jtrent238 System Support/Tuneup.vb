Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class Tuneup

    Dim ravenClient = New RavenClient("https://0bdbb829bf4e4efda08bbeba411c7795:5982d8734a024c58bf5b96f1c60dcf9f@sentry.io/214296")


    Private Sub Tuneup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Stop()
            Timer2.Stop()
            If My.MySettings.Default.RecycleBinCB.Equals(True) Then CheckBox1.Checked.Equals(True)
            If My.MySettings.Default.RecycleBinCB.Equals(False) Then CheckBox1.Checked.Equals(False)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tuneup_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Try
            Me.Hide()
            main.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Console.WriteLine("Preparing Tuneup...")
            If CheckBox1.Checked Then System.Console.WriteLine("Recycle Bin will be emptied!") Else System.Console.WriteLine("Recycle Bin will be NOT be emptied!")
            If CheckBox1.Checked Then EmptyRecycleBin()
            Timer1.Start()
            Timer2.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Timer1.Stop()
            Timer2.Stop()
            ProgressBar1.Value = 0
            'ProgressBar2.Value = 0
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'If ProgressBar2.Value < 100 Then ProgressBar2.Value = ProgressBar2.Value + 1
            If ProgressBar1.Value = 100 Then TuneupComplete.Show()
            TextBox1.Text = Console.Read.ToString
            TextBox1.Update()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32

    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32

    Private Const SHERB_NOCONFIRMATION = &H1

    Private Const SHERB_NOPROGRESSUI = &H2

    Private Const SHERB_NOSOUND = &H4

    Private Sub EmptyRecycleBin()
        Try
            SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)

            SHUpdateRecycleBinIcon()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TuneupComplete.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            SaveSetting(My.Application.Info.ProductName.ToString, 0, My.MySettings.Default.RecycleBinCB, CheckBox1.CheckState.ToString)
            System.Console.WriteLine("Settings Saved!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            System.Console.ReadLine()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If ProgressBar1.Value < 100 Then ProgressBar1.Value = ProgressBar1.Value + 1
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class