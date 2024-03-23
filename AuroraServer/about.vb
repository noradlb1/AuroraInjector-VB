Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace AuroraServer
    Public Partial Class about
        Inherits Form
        Private isDragging As Boolean = False
        Private lastCursor As Point
        Private lastForm As Point

        Public Sub New()
            InitializeComponent()
            label4.Font = New Font(label4.Font, FontStyle.Underline)
        End Sub

        Private Sub topPanel_MouseDown(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                isDragging = True
                lastCursor = Cursor.Position
                lastForm = Location
            End If
        End Sub

        Private Sub topPanel_MouseMove(sender As Object, e As MouseEventArgs)
            If isDragging Then
                Dim deltaX = Cursor.Position.X - lastCursor.X
                Dim deltaY = Cursor.Position.Y - lastCursor.Y
                Location = New Point(lastForm.X + deltaX, lastForm.Y + deltaY)
            End If
        End Sub

        Private Sub topPanel_MouseUp(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                isDragging = False
            End If
        End Sub

        Private Sub closeBtn_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub label4_Click(sender As Object, e As EventArgs)
            Process.Start("https://github.com/k3rnel-dev")
        End Sub
    End Class
End Namespace
