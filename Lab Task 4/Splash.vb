Imports System.Threading
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Splash
    Private Sub loadTimer_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick
        pbLoading.Value += 1

        'Timer coding to show the login form after the progress bar is full
        If pbLoading.Value = 100 Then
            loadTimer.Dispose()
            Me.Hide()
            Login.ShowDialog()
            Me.Close()
        End If

    End Sub
End Class