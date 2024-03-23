Imports System

Namespace AuroraServer
    Partial Class about
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(about))
            topPanel = New Windows.Forms.Panel()
            label1 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            closeBtn = New Windows.Forms.PictureBox()
            label4 = New Windows.Forms.Label()
            topPanel.SuspendLayout()
            groupBox1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' topPanel
            ' 
            topPanel.BackColor = Drawing.Color.Black
            topPanel.Controls.Add(closeBtn)
            topPanel.Controls.Add(label1)
            topPanel.Dock = Windows.Forms.DockStyle.Top
            topPanel.Location = New Drawing.Point(0, 0)
            topPanel.Name = "topPanel"
            topPanel.Size = New Drawing.Size(392, 22)
            topPanel.TabIndex = 0
            AddHandler topPanel.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf topPanel_MouseDown)
            AddHandler topPanel.MouseMove, New Windows.Forms.MouseEventHandler(AddressOf topPanel_MouseMove)
            AddHandler topPanel.MouseUp, New Windows.Forms.MouseEventHandler(AddressOf topPanel_MouseUp)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.Color.Transparent
            label1.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label1.ForeColor = Drawing.Color.White
            label1.Location = New Drawing.Point(5, 3)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(217, 14)
            label1.TabIndex = 1
            label1.Text = "[ Aurora Injector] - [ About ]"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(label2)
            groupBox1.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            groupBox1.ForeColor = Drawing.Color.White
            groupBox1.Location = New Drawing.Point(153, 28)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(235, 129)
            groupBox1.TabIndex = 2
            groupBox1.TabStop = False
            groupBox1.Text = "About Program"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.Color.Transparent
            label2.Font = New Drawing.Font("Consolas", 7.0F, Drawing.FontStyle.Bold)
            label2.ForeColor = Drawing.Color.White
            label2.Location = New Drawing.Point(6, 18)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(225, 96)
            label2.TabIndex = 3
            label2.Text = resources.GetString("label2.Text")
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.Transparent
            label3.Font = New Drawing.Font("Consolas", 7.0F, Drawing.FontStyle.Bold)
            label3.ForeColor = Drawing.Color.FromArgb(167, 167, 167)
            label3.Location = New Drawing.Point(311, 162)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(75, 12)
            label3.TabIndex = 4
            label3.Text = "Made in Russia"
            ' 
            ' pictureBox1
            ' 
            'pictureBox1.Image = Global.AuroraServer.Properties.Resources.elliot
            pictureBox1.Location = New Drawing.Point(9, 36)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(136, 106)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 1
            pictureBox1.TabStop = False
            ' 
            ' closeBtn
            ' 
            closeBtn.Cursor = Windows.Forms.Cursors.Hand
            'closeBtn.Image = Global.AuroraServer.Properties.Resources.close
            closeBtn.Location = New Drawing.Point(371, 1)
            closeBtn.Name = "closeBtn"
            closeBtn.Size = New Drawing.Size(19, 18)
            closeBtn.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            closeBtn.TabIndex = 2
            closeBtn.TabStop = False
            AddHandler closeBtn.Click, New EventHandler(AddressOf closeBtn_Click)
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.Transparent
            label4.Cursor = Windows.Forms.Cursors.Hand
            label4.Font = New Drawing.Font("Consolas", 7.0F, Drawing.FontStyle.Bold)
            label4.ForeColor = Drawing.Color.FromArgb(249, 215, 255)
            label4.Location = New Drawing.Point(15, 145)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(130, 12)
            label4.TabIndex = 5
            label4.Text = "Author Github: Kernel-Dev"
            AddHandler label4.Click, New EventHandler(AddressOf label4_Click)
            ' 
            ' about
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(44, 44, 44)
            ClientSize = New Drawing.Size(392, 179)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(groupBox1)
            Controls.Add(pictureBox1)
            Controls.Add(topPanel)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "about"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "[ Aurora-Injector ] - [ About ]"
            topPanel.ResumeLayout(False)
            topPanel.PerformLayout()
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private topPanel As Windows.Forms.Panel
        Private label1 As Windows.Forms.Label
        Private closeBtn As Windows.Forms.PictureBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private groupBox1 As Windows.Forms.GroupBox
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
    End Class
End Namespace
