Imports System
Imports System.Windows.Forms

Namespace AuroraServer
    Public Partial Class screen
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub timer1_Tick(sender As Object, e As EventArgs)
            timer1.Enabled = True
            progressBar1.Increment(2)
            If progressBar1.Value = 100 Then
                timer1.Enabled = False
                Dim form As Form1 = New Form1()
                form.Show()
                Hide()
            End If
        End Sub
    End Class
End Namespace
