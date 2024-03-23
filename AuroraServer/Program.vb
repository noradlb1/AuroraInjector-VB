Imports System
Imports System.Windows.Forms

Namespace AuroraServer
    Friend Module Program
        ''' <summary>
        ''' Главная точка входа для приложения.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New screen())
        End Sub
    End Module
End Namespace
