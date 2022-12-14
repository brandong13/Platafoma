<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registro_maestros
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Id_claveLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.contraseña_maes = New System.Windows.Forms.TextBox()
        Me.correo_maes = New System.Windows.Forms.TextBox()
        Me.telefono_maes = New System.Windows.Forms.TextBox()
        Me.direccion_maes = New System.Windows.Forms.TextBox()
        Me.materno_maes = New System.Windows.Forms.TextBox()
        Me.paterno_maes = New System.Windows.Forms.TextBox()
        Me.nombre_maes = New System.Windows.Forms.TextBox()
        Me.matricula_maes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.registrar_maes = New System.Windows.Forms.Button()
        Me.date_maes = New System.Windows.Forms.DateTimePicker()
        Me.Actualizar_maes = New System.Windows.Forms.Button()
        Me.genero_maes = New System.Windows.Forms.ComboBox()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Id_claveLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        PaternoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label9.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label9.Location = New System.Drawing.Point(114, 397)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(90, 25)
        Label9.TabIndex = 226
        Label9.Text = "Genero:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(114, 334)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(191, 25)
        Label8.TabIndex = 225
        Label8.Text = "Apellido Materno:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(724, 273)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(130, 25)
        Label5.TabIndex = 224
        Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(724, 237)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(223, 25)
        Label6.TabIndex = 223
        Label6.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label7.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(114, 471)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(108, 25)
        Label7.TabIndex = 222
        Label7.Text = "Direccion:"
        '
        'Id_claveLabel
        '
        Id_claveLabel.AutoSize = True
        Id_claveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_claveLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_claveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Id_claveLabel.Location = New System.Drawing.Point(114, 239)
        Id_claveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_claveLabel.Name = "Id_claveLabel"
        Id_claveLabel.Size = New System.Drawing.Size(111, 25)
        Id_claveLabel.TabIndex = 217
        Id_claveLabel.Text = "Matricula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        NombreLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NombreLabel.Location = New System.Drawing.Point(114, 271)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 25)
        NombreLabel.TabIndex = 218
        NombreLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PaternoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaternoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PaternoLabel.Location = New System.Drawing.Point(114, 303)
        PaternoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(187, 25)
        PaternoLabel.TabIndex = 219
        PaternoLabel.Text = "Apellido Paterno:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        TelefonoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TelefonoLabel.Location = New System.Drawing.Point(114, 502)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(105, 25)
        TelefonoLabel.TabIndex = 220
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CorreoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CorreoLabel.Location = New System.Drawing.Point(114, 533)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(85, 25)
        CorreoLabel.TabIndex = 221
        CorreoLabel.Text = "Correo:"
        '
        'contraseña_maes
        '
        Me.contraseña_maes.Location = New System.Drawing.Point(971, 276)
        Me.contraseña_maes.Name = "contraseña_maes"
        Me.contraseña_maes.Size = New System.Drawing.Size(245, 22)
        Me.contraseña_maes.TabIndex = 234
        '
        'correo_maes
        '
        Me.correo_maes.Location = New System.Drawing.Point(361, 536)
        Me.correo_maes.Name = "correo_maes"
        Me.correo_maes.Size = New System.Drawing.Size(245, 22)
        Me.correo_maes.TabIndex = 233
        '
        'telefono_maes
        '
        Me.telefono_maes.Location = New System.Drawing.Point(361, 505)
        Me.telefono_maes.Name = "telefono_maes"
        Me.telefono_maes.Size = New System.Drawing.Size(245, 22)
        Me.telefono_maes.TabIndex = 232
        '
        'direccion_maes
        '
        Me.direccion_maes.Location = New System.Drawing.Point(361, 474)
        Me.direccion_maes.Name = "direccion_maes"
        Me.direccion_maes.Size = New System.Drawing.Size(245, 22)
        Me.direccion_maes.TabIndex = 231
        '
        'materno_maes
        '
        Me.materno_maes.BackColor = System.Drawing.Color.White
        Me.materno_maes.Location = New System.Drawing.Point(361, 337)
        Me.materno_maes.Name = "materno_maes"
        Me.materno_maes.Size = New System.Drawing.Size(245, 22)
        Me.materno_maes.TabIndex = 230
        '
        'paterno_maes
        '
        Me.paterno_maes.BackColor = System.Drawing.Color.White
        Me.paterno_maes.Location = New System.Drawing.Point(361, 306)
        Me.paterno_maes.Name = "paterno_maes"
        Me.paterno_maes.Size = New System.Drawing.Size(245, 22)
        Me.paterno_maes.TabIndex = 229
        '
        'nombre_maes
        '
        Me.nombre_maes.BackColor = System.Drawing.Color.White
        Me.nombre_maes.Location = New System.Drawing.Point(361, 274)
        Me.nombre_maes.Name = "nombre_maes"
        Me.nombre_maes.Size = New System.Drawing.Size(245, 22)
        Me.nombre_maes.TabIndex = 228
        '
        'matricula_maes
        '
        Me.matricula_maes.BackColor = System.Drawing.Color.White
        Me.matricula_maes.Location = New System.Drawing.Point(361, 242)
        Me.matricula_maes.Name = "matricula_maes"
        Me.matricula_maes.Size = New System.Drawing.Size(245, 22)
        Me.matricula_maes.TabIndex = 227
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(219, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 31)
        Me.Label4.TabIndex = 216
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(28, 625)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 214
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlaformaEstudiantil.My.Resources.Resources.LogoMakr_2Fs8pJ_300x300
        Me.PictureBox4.Location = New System.Drawing.Point(1309, 546)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 213
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlaformaEstudiantil.My.Resources.Resources.fb701f7e475d00d5038f9b904875ca40_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(1299, 613)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 212
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(524, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 44)
        Me.Label1.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(571, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 31)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "¡Avanza y Construye tu Futuro!"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(146, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1131, 44)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(640, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(220, 40)
        Me.Label12.TabIndex = 248
        Me.Label12.Text = "¡Bienvenidos!"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 83)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 250
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 249
        Me.PictureBox2.TabStop = False
        '
        'registrar_maes
        '
        Me.registrar_maes.BackColor = System.Drawing.Color.Gold
        Me.registrar_maes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.registrar_maes.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar_maes.ForeColor = System.Drawing.Color.Yellow
        Me.registrar_maes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.registrar_maes.Location = New System.Drawing.Point(565, 640)
        Me.registrar_maes.Name = "registrar_maes"
        Me.registrar_maes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.registrar_maes.Size = New System.Drawing.Size(148, 33)
        Me.registrar_maes.TabIndex = 255
        Me.registrar_maes.Text = "Registrar"
        Me.registrar_maes.UseVisualStyleBackColor = False
        '
        'date_maes
        '
        Me.date_maes.Location = New System.Drawing.Point(971, 240)
        Me.date_maes.Name = "date_maes"
        Me.date_maes.Size = New System.Drawing.Size(269, 22)
        Me.date_maes.TabIndex = 256
        '
        'Actualizar_maes
        '
        Me.Actualizar_maes.BackColor = System.Drawing.Color.Gold
        Me.Actualizar_maes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Actualizar_maes.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar_maes.ForeColor = System.Drawing.Color.Yellow
        Me.Actualizar_maes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Actualizar_maes.Location = New System.Drawing.Point(785, 640)
        Me.Actualizar_maes.Name = "Actualizar_maes"
        Me.Actualizar_maes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Actualizar_maes.Size = New System.Drawing.Size(148, 33)
        Me.Actualizar_maes.TabIndex = 259
        Me.Actualizar_maes.Text = "Actualizar"
        Me.Actualizar_maes.UseVisualStyleBackColor = False
        '
        'genero_maes
        '
        Me.genero_maes.FormattingEnabled = True
        Me.genero_maes.Location = New System.Drawing.Point(361, 396)
        Me.genero_maes.Name = "genero_maes"
        Me.genero_maes.Size = New System.Drawing.Size(245, 24)
        Me.genero_maes.TabIndex = 260
        '
        'registro_maestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1411, 725)
        Me.Controls.Add(Me.genero_maes)
        Me.Controls.Add(Me.Actualizar_maes)
        Me.Controls.Add(Me.date_maes)
        Me.Controls.Add(Me.registrar_maes)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.contraseña_maes)
        Me.Controls.Add(Me.correo_maes)
        Me.Controls.Add(Me.telefono_maes)
        Me.Controls.Add(Me.direccion_maes)
        Me.Controls.Add(Me.materno_maes)
        Me.Controls.Add(Me.paterno_maes)
        Me.Controls.Add(Me.nombre_maes)
        Me.Controls.Add(Me.matricula_maes)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Id_claveLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(PaternoLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registro_maestros"
        Me.Text = "registro_maestros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contraseña_maes As TextBox
    Friend WithEvents correo_maes As TextBox
    Friend WithEvents telefono_maes As TextBox
    Friend WithEvents direccion_maes As TextBox
    Friend WithEvents materno_maes As TextBox
    Friend WithEvents paterno_maes As TextBox
    Friend WithEvents nombre_maes As TextBox
    Friend WithEvents matricula_maes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents registrar_maes As Button
    Friend WithEvents date_maes As DateTimePicker
    Friend WithEvents Actualizar_maes As Button
    Friend WithEvents genero_maes As ComboBox
End Class
