Public Class TuneupComplete


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TuneupComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tuneup.Enabled.Equals(False)
        Tuneup.CanFocus.Equals(False)

    End Sub
End Class