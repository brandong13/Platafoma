<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_aspirantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Id_claveLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.especialidad_asp = New System.Windows.Forms.ComboBox()
        Me.contraseña_asp = New System.Windows.Forms.TextBox()
        Me.correo_asp = New System.Windows.Forms.TextBox()
        Me.telefono_asp = New System.Windows.Forms.TextBox()
        Me.direccion_asp = New System.Windows.Forms.TextBox()
        Me.materno_asp = New System.Windows.Forms.TextBox()
        Me.paterno_asp = New System.Windows.Forms.TextBox()
        Me.nombre_asp = New System.Windows.Forms.TextBox()
        Me.no_control_asp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.registro_asp = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_asp = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NosolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechanacaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaaspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AspirantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlataformaDataSetAsp = New PlaformaEstudiantil.PlataformaDataSetAsp()
        Me.AspirantesTableAdapter = New PlaformaEstudiantil.PlataformaDataSetAspTableAdapters.AspirantesTableAdapter()
        Me.genero_asp = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Id_claveLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        PaternoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspirantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlataformaDataSetAsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(764, 325)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(141, 25)
        Label4.TabIndex = 265
        Label4.Text = "Especialidad:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(155, 325)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(191, 25)
        Label8.TabIndex = 254
        Label8.Text = "Apellido Materno:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(764, 265)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(130, 25)
        Label5.TabIndex = 253
        Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(764, 228)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(223, 25)
        Label6.TabIndex = 252
        Label6.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label7.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(155, 437)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(108, 25)
        Label7.TabIndex = 251
        Label7.Text = "Direccion:"
        '
        'Id_claveLabel
        '
        Id_claveLabel.AutoSize = True
        Id_claveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_claveLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_claveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Id_claveLabel.Location = New System.Drawing.Point(155, 230)
        Id_claveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_claveLabel.Name = "Id_claveLabel"
        Id_claveLabel.Size = New System.Drawing.Size(141, 25)
        Id_claveLabel.TabIndex = 246
        Id_claveLabel.Text = "No. Solicitud:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        NombreLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NombreLabel.Location = New System.Drawing.Point(155, 262)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 25)
        NombreLabel.TabIndex = 247
        NombreLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PaternoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaternoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PaternoLabel.Location = New System.Drawing.Point(155, 294)
        PaternoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(187, 25)
        PaternoLabel.TabIndex = 248
        PaternoLabel.Text = "Apellido Paterno:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        TelefonoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TelefonoLabel.Location = New System.Drawing.Point(155, 468)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(105, 25)
        TelefonoLabel.TabIndex = 249
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CorreoLabel.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CorreoLabel.Location = New System.Drawing.Point(155, 498)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(85, 25)
        CorreoLabel.TabIndex = 250
        CorreoLabel.Text = "Correo:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Label11.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label11.Location = New System.Drawing.Point(154, 374)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(90, 25)
        Label11.TabIndex = 274
        Label11.Text = "Genero:"
        '
        'especialidad_asp
        '
        Me.especialidad_asp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.especialidad_asp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.especialidad_asp.FormattingEnabled = True
        Me.especialidad_asp.Location = New System.Drawing.Point(1011, 330)
        Me.especialidad_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.especialidad_asp.Name = "especialidad_asp"
        Me.especialidad_asp.Size = New System.Drawing.Size(245, 24)
        Me.especialidad_asp.TabIndex = 266
        '
        'contraseña_asp
        '
        Me.contraseña_asp.Location = New System.Drawing.Point(1011, 268)
        Me.contraseña_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contraseña_asp.Name = "contraseña_asp"
        Me.contraseña_asp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña_asp.Size = New System.Drawing.Size(245, 22)
        Me.contraseña_asp.TabIndex = 262
        '
        'correo_asp
        '
        Me.correo_asp.Location = New System.Drawing.Point(401, 502)
        Me.correo_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.correo_asp.Name = "correo_asp"
        Me.correo_asp.Size = New System.Drawing.Size(245, 22)
        Me.correo_asp.TabIndex = 261
        '
        'telefono_asp
        '
        Me.telefono_asp.Location = New System.Drawing.Point(401, 471)
        Me.telefono_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.telefono_asp.MaxLength = 10
        Me.telefono_asp.Name = "telefono_asp"
        Me.telefono_asp.Size = New System.Drawing.Size(245, 22)
        Me.telefono_asp.TabIndex = 260
        '
        'direccion_asp
        '
        Me.direccion_asp.Location = New System.Drawing.Point(401, 441)
        Me.direccion_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.direccion_asp.Name = "direccion_asp"
        Me.direccion_asp.Size = New System.Drawing.Size(245, 22)
        Me.direccion_asp.TabIndex = 259
        '
        'materno_asp
        '
        Me.materno_asp.BackColor = System.Drawing.Color.White
        Me.materno_asp.Location = New System.Drawing.Point(401, 327)
        Me.materno_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.materno_asp.Name = "materno_asp"
        Me.materno_asp.Size = New System.Drawing.Size(245, 22)
        Me.materno_asp.TabIndex = 258
        '
        'paterno_asp
        '
        Me.paterno_asp.BackColor = System.Drawing.Color.White
        Me.paterno_asp.Location = New System.Drawing.Point(401, 297)
        Me.paterno_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paterno_asp.Name = "paterno_asp"
        Me.paterno_asp.Size = New System.Drawing.Size(245, 22)
        Me.paterno_asp.TabIndex = 257
        '
        'nombre_asp
        '
        Me.nombre_asp.BackColor = System.Drawing.Color.White
        Me.nombre_asp.Location = New System.Drawing.Point(401, 265)
        Me.nombre_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nombre_asp.Name = "nombre_asp"
        Me.nombre_asp.Size = New System.Drawing.Size(245, 22)
        Me.nombre_asp.TabIndex = 256
        '
        'no_control_asp
        '
        Me.no_control_asp.BackColor = System.Drawing.Color.White
        Me.no_control_asp.Location = New System.Drawing.Point(401, 233)
        Me.no_control_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.no_control_asp.MaxLength = 8
        Me.no_control_asp.Name = "no_control_asp"
        Me.no_control_asp.Size = New System.Drawing.Size(245, 22)
        Me.no_control_asp.TabIndex = 255
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(259, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 31)
        Me.Label9.TabIndex = 245
        '
        'registro_asp
        '
        Me.registro_asp.BackColor = System.Drawing.Color.Gold
        Me.registro_asp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.registro_asp.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registro_asp.ForeColor = System.Drawing.Color.Yellow
        Me.registro_asp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.registro_asp.Location = New System.Drawing.Point(823, 646)
        Me.registro_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registro_asp.Name = "registro_asp"
        Me.registro_asp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.registro_asp.Size = New System.Drawing.Size(148, 33)
        Me.registro_asp.TabIndex = 244
        Me.registro_asp.Text = "Registrar"
        Me.registro_asp.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(1211, 639)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 46)
        Me.Button4.TabIndex = 239
        Me.Button4.Text = "Contactanos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(881, 484)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 40)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "¡Bienvenidos!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(557, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 31)
        Me.Label2.TabIndex = 236
        Me.Label2.Text = "¡Avanza y Construye tu Futuro!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(160, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1131, 44)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios N° 236"
        '
        'date_asp
        '
        Me.date_asp.Location = New System.Drawing.Point(1011, 231)
        Me.date_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_asp.Name = "date_asp"
        Me.date_asp.Size = New System.Drawing.Size(267, 22)
        Me.date_asp.TabIndex = 272
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NosolicitudDataGridViewTextBoxColumn, Me.NombreaspDataGridViewTextBoxColumn, Me.PaternoaspDataGridViewTextBoxColumn, Me.MaternoaspDataGridViewTextBoxColumn, Me.GeneroaspDataGridViewTextBoxColumn, Me.DireccionaspDataGridViewTextBoxColumn, Me.TelefonoaspDataGridViewTextBoxColumn, Me.CorreoaspDataGridViewTextBoxColumn, Me.FechanacaspDataGridViewTextBoxColumn, Me.ContraseñaaspDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AspirantesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1571, 379)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 273
        '
        'NosolicitudDataGridViewTextBoxColumn
        '
        Me.NosolicitudDataGridViewTextBoxColumn.DataPropertyName = "no_solicitud"
        Me.NosolicitudDataGridViewTextBoxColumn.HeaderText = "no_solicitud"
        Me.NosolicitudDataGridViewTextBoxColumn.Name = "NosolicitudDataGridViewTextBoxColumn"
        '
        'NombreaspDataGridViewTextBoxColumn
        '
        Me.NombreaspDataGridViewTextBoxColumn.DataPropertyName = "nombre_asp"
        Me.NombreaspDataGridViewTextBoxColumn.HeaderText = "nombre_asp"
        Me.NombreaspDataGridViewTextBoxColumn.Name = "NombreaspDataGridViewTextBoxColumn"
        '
        'PaternoaspDataGridViewTextBoxColumn
        '
        Me.PaternoaspDataGridViewTextBoxColumn.DataPropertyName = "paterno_asp"
        Me.PaternoaspDataGridViewTextBoxColumn.HeaderText = "paterno_asp"
        Me.PaternoaspDataGridViewTextBoxColumn.Name = "PaternoaspDataGridViewTextBoxColumn"
        '
        'MaternoaspDataGridViewTextBoxColumn
        '
        Me.MaternoaspDataGridViewTextBoxColumn.DataPropertyName = "materno_asp"
        Me.MaternoaspDataGridViewTextBoxColumn.HeaderText = "materno_asp"
        Me.MaternoaspDataGridViewTextBoxColumn.Name = "MaternoaspDataGridViewTextBoxColumn"
        '
        'GeneroaspDataGridViewTextBoxColumn
        '
        Me.GeneroaspDataGridViewTextBoxColumn.DataPropertyName = "genero_asp"
        Me.GeneroaspDataGridViewTextBoxColumn.HeaderText = "genero_asp"
        Me.GeneroaspDataGridViewTextBoxColumn.Name = "GeneroaspDataGridViewTextBoxColumn"
        '
        'DireccionaspDataGridViewTextBoxColumn
        '
        Me.DireccionaspDataGridViewTextBoxColumn.DataPropertyName = "direccion_asp"
        Me.DireccionaspDataGridViewTextBoxColumn.HeaderText = "direccion_asp"
        Me.DireccionaspDataGridViewTextBoxColumn.Name = "DireccionaspDataGridViewTextBoxColumn"
        '
        'TelefonoaspDataGridViewTextBoxColumn
        '
        Me.TelefonoaspDataGridViewTextBoxColumn.DataPropertyName = "telefono_asp"
        Me.TelefonoaspDataGridViewTextBoxColumn.HeaderText = "telefono_asp"
        Me.TelefonoaspDataGridViewTextBoxColumn.Name = "TelefonoaspDataGridViewTextBoxColumn"
        '
        'CorreoaspDataGridViewTextBoxColumn
        '
        Me.CorreoaspDataGridViewTextBoxColumn.DataPropertyName = "correo_asp"
        Me.CorreoaspDataGridViewTextBoxColumn.HeaderText = "correo_asp"
        Me.CorreoaspDataGridViewTextBoxColumn.Name = "CorreoaspDataGridViewTextBoxColumn"
        '
        'FechanacaspDataGridViewTextBoxColumn
        '
        Me.FechanacaspDataGridViewTextBoxColumn.DataPropertyName = "fecha_nac_asp"
        Me.FechanacaspDataGridViewTextBoxColumn.HeaderText = "fecha_nac_asp"
        Me.FechanacaspDataGridViewTextBoxColumn.Name = "FechanacaspDataGridViewTextBoxColumn"
        '
        'ContraseñaaspDataGridViewTextBoxColumn
        '
        Me.ContraseñaaspDataGridViewTextBoxColumn.DataPropertyName = "contraseña_asp"
        Me.ContraseñaaspDataGridViewTextBoxColumn.HeaderText = "contraseña_asp"
        Me.ContraseñaaspDataGridViewTextBoxColumn.Name = "ContraseñaaspDataGridViewTextBoxColumn"
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'AspirantesBindingSource
        '
        Me.AspirantesBindingSource.DataMember = "Aspirantes"
        Me.AspirantesBindingSource.DataSource = Me.PlataformaDataSetAsp
        '
        'PlataformaDataSetAsp
        '
        Me.PlataformaDataSetAsp.DataSetName = "PlataformaDataSetAsp"
        Me.PlataformaDataSetAsp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AspirantesTableAdapter
        '
        Me.AspirantesTableAdapter.ClearBeforeFill = True
        '
        'genero_asp
        '
        Me.genero_asp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.genero_asp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.genero_asp.FormattingEnabled = True
        Me.genero_asp.Location = New System.Drawing.Point(401, 379)
        Me.genero_asp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.genero_asp.Name = "genero_asp"
        Me.genero_asp.Size = New System.Drawing.Size(245, 24)
        Me.genero_asp.TabIndex = 275
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(613, 646)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(148, 33)
        Me.Button1.TabIndex = 276
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Opciones_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(0, 89)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 243
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlaformaEstudiantil.My.Resources.Resources._2018_why_chevrolet_08_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 210)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 242
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlaformaEstudiantil.My.Resources.Resources.LogoMakr_2Fs8pJ_300x300
        Me.PictureBox4.Location = New System.Drawing.Point(1327, 554)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 241
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlaformaEstudiantil.My.Resources.Resources.fb701f7e475d00d5038f9b904875ca40_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(1315, 465)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 240
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlaformaEstudiantil.My.Resources.Resources.Logo_Cbtis
        Me.PictureBox1.Location = New System.Drawing.Point(36, 618)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 237
        Me.PictureBox1.TabStop = False
        '
        'registro_aspirantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1429, 722)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.genero_asp)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.date_asp)
        Me.Controls.Add(Me.especialidad_asp)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.contraseña_asp)
        Me.Controls.Add(Me.correo_asp)
        Me.Controls.Add(Me.telefono_asp)
        Me.Controls.Add(Me.direccion_asp)
        Me.Controls.Add(Me.materno_asp)
        Me.Controls.Add(Me.paterno_asp)
        Me.Controls.Add(Me.nombre_asp)
        Me.Controls.Add(Me.no_control_asp)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Id_claveLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(PaternoLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.registro_asp)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "registro_aspirantes"
        Me.Text = "registro_aspirantes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspirantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlataformaDataSetAsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents especialidad_asp As ComboBox
    Friend WithEvents contraseña_asp As TextBox
    Friend WithEvents correo_asp As TextBox
    Friend WithEvents telefono_asp As TextBox
    Friend WithEvents direccion_asp As TextBox
    Friend WithEvents materno_asp As TextBox
    Friend WithEvents paterno_asp As TextBox
    Friend WithEvents nombre_asp As TextBox
    Friend WithEvents no_control_asp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents registro_asp As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents date_asp As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PlataformaDataSetAsp As PlataformaDataSetAsp
    Friend WithEvents AspirantesBindingSource As BindingSource
    Friend WithEvents AspirantesTableAdapter As PlataformaDataSetAspTableAdapters.AspirantesTableAdapter
    Friend WithEvents NosolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaternoaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaternoaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechanacaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaaspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents genero_asp As ComboBox
    Friend WithEvents Button1 As Button
End Class
