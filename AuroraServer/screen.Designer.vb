Imports System

Namespace AuroraServer
    Partial Class screen
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            pictureBox1 = New Windows.Forms.PictureBox()
            progressBar1 = New Windows.Forms.ProgressBar()
            timer1 = New Windows.Forms.Timer(components)
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            'pictureBox1.Image = Global.AuroraServer.Properties.Resources.Без_имени_1
            pictureBox1.Location = New Drawing.Point(0, 0)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(800, 452)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' progressBar1
            ' 
            progressBar1.BackColor = Drawing.Color.FromArgb(247, 247, 247)
            progressBar1.ForeColor = Drawing.Color.FromArgb(96, 35, 138)
            progressBar1.Location = New Drawing.Point(186, 373)
            progressBar1.Name = "progressBar1"
            progressBar1.Size = New Drawing.Size(414, 23)
            progressBar1.Style = Windows.Forms.ProgressBarStyle.Continuous
            progressBar1.TabIndex = 1
            ' 
            ' timer1
            ' 
            timer1.Enabled = True
            AddHandler timer1.Tick, New EventHandler(AddressOf timer1_Tick)
            ' 
            ' screen
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(800, 450)
            Controls.Add(progressBar1)
            Controls.Add(pictureBox1)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Name = "screen"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "screen"
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private pictureBox1 As Windows.Forms.PictureBox
        Private progressBar1 As Windows.Forms.ProgressBar
        Private timer1 As Windows.Forms.Timer
    End Class
End Namespace
