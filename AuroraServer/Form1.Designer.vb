Imports System

Namespace AuroraServer
    Partial Class Form1
        ''' <summary>
        ''' Обязательная переменная конструктора.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Освободить все используемые ресурсы.
        ''' </summary>
        ''' <paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Код, автоматически созданный конструктором форм Windows"

        ''' <summary>
        ''' Требуемый метод для поддержки конструктора — не изменяйте 
        ''' содержимое этого метода с помощью редактора кода.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            panel1 = New Windows.Forms.Panel()
            panel2 = New Windows.Forms.Panel()
            textBox1 = New Windows.Forms.TextBox()
            comboBox1 = New Windows.Forms.ComboBox()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            button4 = New Windows.Forms.Button()
            button3 = New Windows.Forms.Button()
            button1 = New Windows.Forms.Button()
            pictureBox2 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            button2 = New Windows.Forms.Button()
            panel1.SuspendLayout()
            panel2.SuspendLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.FromArgb(26, 23, 40)
            panel1.Controls.Add(button2)
            panel1.Location = New Drawing.Point(1, 46)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(188, 178)
            panel1.TabIndex = 0
            ' 
            ' panel2
            ' 
            panel2.BackColor = Drawing.Color.FromArgb(26, 23, 40)
            panel2.Controls.Add(pictureBox2)
            panel2.Controls.Add(pictureBox1)
            panel2.Dock = Windows.Forms.DockStyle.Top
            panel2.Location = New Drawing.Point(0, 0)
            panel2.Name = "panel2"
            panel2.Size = New Drawing.Size(506, 49)
            panel2.TabIndex = 1
            ' 
            ' textBox1
            ' 
            textBox1.BackColor = Drawing.Color.FromArgb(18, 18, 32)
            textBox1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            textBox1.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            textBox1.Location = New Drawing.Point(260, 107)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(164, 20)
            textBox1.TabIndex = 3
            AddHandler textBox1.TextChanged, New EventHandler(AddressOf textBox1_TextChanged)
            ' 
            ' comboBox1
            ' 
            comboBox1.BackColor = Drawing.Color.FromArgb(18, 18, 32)
            comboBox1.FlatStyle = Windows.Forms.FlatStyle.Flat
            comboBox1.ForeColor = Drawing.Color.Aqua
            comboBox1.FormattingEnabled = True
            comboBox1.Location = New Drawing.Point(260, 133)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(208, 21)
            comboBox1.TabIndex = 4
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.Color.Transparent
            label1.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            label1.Location = New Drawing.Point(195, 109)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(62, 17)
            label1.TabIndex = 6
            label1.Text = "DLL-FILE"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.Color.Transparent
            label2.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            label2.Location = New Drawing.Point(195, 136)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(63, 17)
            label2.TabIndex = 7
            label2.Text = "PROCESS"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.Color.Transparent
            label3.Font = New Drawing.Font("Nirmala UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label3.ForeColor = Drawing.SystemColors.Window
            label3.Location = New Drawing.Point(283, 76)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(116, 21)
            label3.TabIndex = 8
            label3.Text = "DLL INJECTOR"
            ' 
            ' button4
            ' 
            button4.FlatAppearance.BorderSize = 0
            button4.FlatStyle = Windows.Forms.FlatStyle.Flat
            button4.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button4.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            'button4.Image = Global.AuroraServer.Properties.Resources.setting
            button4.Location = New Drawing.Point(260, 189)
            button4.Name = "button4"
            button4.Size = New Drawing.Size(208, 25)
            button4.TabIndex = 9
            button4.Text = "Refresh"
            button4.TextImageRelation = Windows.Forms.TextImageRelation.TextBeforeImage
            button4.UseVisualStyleBackColor = True
            AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
            ' 
            ' button3
            ' 
            button3.FlatAppearance.BorderSize = 0
            button3.FlatStyle = Windows.Forms.FlatStyle.Flat
            button3.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button3.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            'button3.Image = Global.AuroraServer.Properties.Resources.employee
            button3.Location = New Drawing.Point(260, 160)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(208, 25)
            button3.TabIndex = 5
            button3.Text = "Inject"
            button3.TextImageRelation = Windows.Forms.TextImageRelation.TextBeforeImage
            button3.UseVisualStyleBackColor = True
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' button1
            ' 
            button1.FlatAppearance.BorderSize = 0
            button1.FlatStyle = Windows.Forms.FlatStyle.Flat
            button1.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button1.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            'button1.Image = Global.AuroraServer.Properties.Resources.setting
            button1.Location = New Drawing.Point(430, 102)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(64, 25)
            button1.TabIndex = 2
            button1.Text = "open"
            button1.TextImageRelation = Windows.Forms.TextImageRelation.TextBeforeImage
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' pictureBox2
            ' 
            pictureBox2.BackColor = Drawing.Color.Transparent
            'pictureBox2.Image = Global.AuroraServer.Properties.Resources.aurora
            pictureBox2.Location = New Drawing.Point(0, 0)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(221, 51)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox2.TabIndex = 0
            pictureBox2.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Cursor = Windows.Forms.Cursors.Hand
            'pictureBox1.Image = Global.AuroraServer.Properties.Resources.close
            pictureBox1.Location = New Drawing.Point(484, 1)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(21, 22)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.CenterImage
            pictureBox1.TabIndex = 1
            pictureBox1.TabStop = False
            AddHandler pictureBox1.Click, New EventHandler(AddressOf pictureBox1_Click)
            ' 
            ' button2
            ' 
            button2.Dock = Windows.Forms.DockStyle.Top
            button2.FlatAppearance.BorderSize = 0
            button2.FlatStyle = Windows.Forms.FlatStyle.Flat
            button2.Font = New Drawing.Font("Nirmala UI", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button2.ForeColor = Drawing.Color.FromArgb(127, 124, 146)
            'button2.Image = Global.AuroraServer.Properties.Resources.home
            button2.Location = New Drawing.Point(0, 0)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(188, 23)
            button2.TabIndex = 1
            button2.Text = "A B O U T"
            button2.TextImageRelation = Windows.Forms.TextImageRelation.TextBeforeImage
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(18, 18, 32)
            ClientSize = New Drawing.Size(506, 226)
            Controls.Add(button4)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(label1)
            Controls.Add(button3)
            Controls.Add(comboBox1)
            Controls.Add(textBox1)
            Controls.Add(button1)
            Controls.Add(panel2)
            Controls.Add(panel1)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Form1"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Aurora Server"
            AddHandler MouseDown, New Windows.Forms.MouseEventHandler(AddressOf Form1_MouseDown)
            panel1.ResumeLayout(False)
            panel2.ResumeLayout(False)
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private panel1 As Windows.Forms.Panel
        Private pictureBox1 As Windows.Forms.PictureBox
        Private panel2 As Windows.Forms.Panel
        Private pictureBox2 As Windows.Forms.PictureBox
        Private button2 As Windows.Forms.Button
        Private button1 As Windows.Forms.Button
        Private textBox1 As Windows.Forms.TextBox
        Private comboBox1 As Windows.Forms.ComboBox
        Private button3 As Windows.Forms.Button
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private button4 As Windows.Forms.Button
    End Class
End Namespace
