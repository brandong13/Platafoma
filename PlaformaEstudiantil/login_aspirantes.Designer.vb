<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_aspirantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sesion_asp = New System.Windows.Forms.Button()
        Me.contraseña_asp = New System.Windows.Forms.TextBox()
        Me.no_solicitud = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.generar_ficha = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(1183, 638)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 46)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Contactanos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'sesion_asp
        '
        Me.sesion_asp.BackColor = System.Drawing.Color.Gold
        Me.sesion_asp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sesion_asp.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sesion_asp.ForeColor = System.Drawing.Color.White
        Me.sesion_asp.Location = New System.Drawing.Point(626, 553)
        Me.sesion_asp.Name = "sesion_asp"
        Me.sesion_asp.Size = New System.Drawing.Size(237, 40)
        Me.sesion_asp.TabIndex = 35
        Me.sesion_asp.Text = "Iniciar Sesión"
        Me.sesion_asp.UseVisualStyleBackColor = False
        '
        'contraseña_asp
        '
        Me.contraseña_asp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contraseña_asp.Location = New System.Drawing.Point(610, 487)
        Me.contraseña_asp.MaxLength = 15
        Me.contraseña_asp.Name = "contraseña_asp"
        Me.contraseña_asp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña_asp.Size = New System.Drawing.Size(262, 24)
        Me.contraseña_asp.TabIndex = 34
        Me.contraseña_asp.Text = "Password"
        Me.contraseña_asp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'no_solicitud
        '
        Me.no_solicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_solicitud.Location = New System.Drawing.Point(610, 381)
        Me.no_solicitud.MaxLength = 8
        Me.no_solicitud.Name = "no_solicitud"
        Me.no_solicitud.Size = New System.Drawing.Size(262, 24)
        Me.no_solicitud.TabIndex = 33
        Me.no_solicitud.Text = "Numero de solicitud"
        Me.no_solicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(666, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(609, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 31)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Numero de Solicitud"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(401, 200)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(658, 484)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(76, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 40)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "¡Bienvenidos!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(542, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "¡Avanza y Construye tu Futuro!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(109, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 44)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(551, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 27)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Ingresa con tu número de solicitud"
        '
        'generar_ficha
        '
        Me.generar_ficha.BackColor = System.Drawing.Color.Gold
        Me.generar_ficha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.generar_ficha.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generar_ficha.ForeColor = System.Drawing.Color.White
        Me.generar_ficha.Location = New System.Drawing.Point(626, 615)
        Me.generar_ficha.Name = "generar_ficha"
        Me.generar_ficha.Size = New System.Drawing.Size(237, 40)
        Me.generar_ficha.TabIndex = 40
        Me.generar_ficha.Text = "Resgistro"
        Me.generar_ficha.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlaformaEstudiantil.My.Resources.Resources.LogoMakr_2Fs8pJ_300x300
        Me.PictureBox4.Location = New System.Drawing.Point(1299, 553)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlaformaEstudiantil.My.Resources.Resources.fb701f7e475d00d5038f9b904875ca40_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(1286, 464)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(661, 243)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(40, 538)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'login_aspirantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1411, 725)
        Me.Controls.Add(Me.generar_ficha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.sesion_asp)
        Me.Controls.Add(Me.contraseña_asp)
        Me.Controls.Add(Me.no_solicitud)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "login_aspirantes"
        Me.Text = "login_aspirantes"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents sesion_asp As Button
    Friend WithEvents contraseña_asp As TextBox
    Friend WithEvents no_solicitud As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents generar_ficha As Button
End Class
