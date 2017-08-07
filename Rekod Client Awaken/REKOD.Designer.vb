<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REKOD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REKOD))
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKosong = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PROGRAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblprogramDataSet = New Rekod_Client_Awaken.tblprogramDataSet()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTempat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPIC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTrainer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInvois = New System.Windows.Forms.TextBox()
        Me.btnBuang = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PROGRAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRAINERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIKHMULADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIKHTAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOINVOISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.PROGRAMTableAdapter = New Rekod_Client_Awaken.tblprogramDataSetTableAdapters.PROGRAMTableAdapter()
        Me.PROGRAMTableAdapterManager = New Rekod_Client_Awaken.tblprogramDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblprogramDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(580, 272)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 33)
        Me.btnSimpan.TabIndex = 16
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKosong
        '
        Me.btnKosong.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKosong.Location = New System.Drawing.Point(467, 322)
        Me.btnKosong.Name = "btnKosong"
        Me.btnKosong.Size = New System.Drawing.Size(89, 34)
        Me.btnKosong.TabIndex = 17
        Me.btnKosong.Text = "KOSONGKAN"
        Me.btnKosong.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(663, 31)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(88, 33)
        Me.btnKeluar.TabIndex = 24
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(161, 87)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(584, 28)
        Me.lbltitle.TabIndex = 26
        Me.lbltitle.Text = "AWAKEN TRAINING AND CONSULTANCY SDN BHD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(418, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TARIKH MULA :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(411, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "TARIKH TAMAT :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "TARIKH PROGRAM"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PROGRAMBindingSource, "TARIKH_MULA", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.DateTimePicker1.Location = New System.Drawing.Point(510, 173)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'PROGRAMBindingSource
        '
        Me.PROGRAMBindingSource.DataMember = "PROGRAM"
        Me.PROGRAMBindingSource.DataSource = Me.TblprogramDataSet
        '
        'TblprogramDataSet
        '
        Me.TblprogramDataSet.DataSetName = "tblprogramDataSet"
        Me.TblprogramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PROGRAMBindingSource, "TARIKH_TAMAT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.DateTimePicker2.Location = New System.Drawing.Point(510, 210)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(208, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(161, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 28)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "SISTEM REKOD PROGRAM"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(539, 31)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(108, 33)
        Me.btnMenu.TabIndex = 31
        Me.btnMenu.Text = "MENU UTAMA"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'txtClient
        '
        Me.txtClient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "ORGANISASI", True))
        Me.txtClient.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.Location = New System.Drawing.Point(155, 208)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(208, 21)
        Me.txtClient.TabIndex = 0
        '
        'txtProgram
        '
        Me.txtProgram.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "PROGRAM", True))
        Me.txtProgram.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.Location = New System.Drawing.Point(155, 177)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(208, 21)
        Me.txtProgram.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NAMA KLIEN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NAMA PROGRAM :"
        '
        'txtHarga
        '
        Me.txtHarga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "HARGA", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtHarga.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(155, 299)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(208, 21)
        Me.txtHarga.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "HARGA :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TEMPAT :"
        '
        'txtTempat
        '
        Me.txtTempat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "TEMPAT", True))
        Me.txtTempat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempat.Location = New System.Drawing.Point(155, 239)
        Me.txtTempat.Name = "txtTempat"
        Me.txtTempat.Size = New System.Drawing.Size(208, 21)
        Me.txtTempat.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PIC :"
        '
        'txtPIC
        '
        Me.txtPIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "PIC", True))
        Me.txtPIC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIC.Location = New System.Drawing.Point(155, 330)
        Me.txtPIC.Name = "txtPIC"
        Me.txtPIC.Size = New System.Drawing.Size(208, 21)
        Me.txtPIC.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TRAINER :"
        '
        'txtTrainer
        '
        Me.txtTrainer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "TRAINER", True))
        Me.txtTrainer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrainer.Location = New System.Drawing.Point(155, 269)
        Me.txtTrainer.Name = "txtTrainer"
        Me.txtTrainer.Size = New System.Drawing.Size(208, 21)
        Me.txtTrainer.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "NO INVOIS :"
        '
        'txtInvois
        '
        Me.txtInvois.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "NO_INVOIS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtInvois.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvois.Location = New System.Drawing.Point(155, 360)
        Me.txtInvois.Name = "txtInvois"
        Me.txtInvois.Size = New System.Drawing.Size(208, 21)
        Me.txtInvois.TabIndex = 28
        '
        'btnBuang
        '
        Me.btnBuang.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuang.Location = New System.Drawing.Point(580, 322)
        Me.btnBuang.Name = "btnBuang"
        Me.btnBuang.Size = New System.Drawing.Size(89, 34)
        Me.btnBuang.TabIndex = 32
        Me.btnBuang.Text = "BUANG"
        Me.btnBuang.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROGRAMDataGridViewTextBoxColumn, Me.TEMPATDataGridViewTextBoxColumn, Me.TRAINERDataGridViewTextBoxColumn, Me.HARGADataGridViewTextBoxColumn, Me.PICDataGridViewTextBoxColumn, Me.TARIKHMULADataGridViewTextBoxColumn, Me.TARIKHTAMATDataGridViewTextBoxColumn, Me.NOINVOISDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PROGRAMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 405)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 184)
        Me.DataGridView1.TabIndex = 33
        '
        'PROGRAMDataGridViewTextBoxColumn
        '
        Me.PROGRAMDataGridViewTextBoxColumn.DataPropertyName = "PROGRAM"
        Me.PROGRAMDataGridViewTextBoxColumn.HeaderText = "PROGRAM"
        Me.PROGRAMDataGridViewTextBoxColumn.Name = "PROGRAMDataGridViewTextBoxColumn"
        '
        'TEMPATDataGridViewTextBoxColumn
        '
        Me.TEMPATDataGridViewTextBoxColumn.DataPropertyName = "TEMPAT"
        Me.TEMPATDataGridViewTextBoxColumn.HeaderText = "TEMPAT"
        Me.TEMPATDataGridViewTextBoxColumn.Name = "TEMPATDataGridViewTextBoxColumn"
        '
        'TRAINERDataGridViewTextBoxColumn
        '
        Me.TRAINERDataGridViewTextBoxColumn.DataPropertyName = "TRAINER"
        Me.TRAINERDataGridViewTextBoxColumn.HeaderText = "TRAINER"
        Me.TRAINERDataGridViewTextBoxColumn.Name = "TRAINERDataGridViewTextBoxColumn"
        '
        'HARGADataGridViewTextBoxColumn
        '
        Me.HARGADataGridViewTextBoxColumn.DataPropertyName = "HARGA"
        Me.HARGADataGridViewTextBoxColumn.HeaderText = "HARGA"
        Me.HARGADataGridViewTextBoxColumn.Name = "HARGADataGridViewTextBoxColumn"
        '
        'PICDataGridViewTextBoxColumn
        '
        Me.PICDataGridViewTextBoxColumn.DataPropertyName = "PIC"
        Me.PICDataGridViewTextBoxColumn.HeaderText = "PIC"
        Me.PICDataGridViewTextBoxColumn.Name = "PICDataGridViewTextBoxColumn"
        '
        'TARIKHMULADataGridViewTextBoxColumn
        '
        Me.TARIKHMULADataGridViewTextBoxColumn.DataPropertyName = "TARIKH_MULA"
        Me.TARIKHMULADataGridViewTextBoxColumn.HeaderText = "TARIKH_MULA"
        Me.TARIKHMULADataGridViewTextBoxColumn.Name = "TARIKHMULADataGridViewTextBoxColumn"
        '
        'TARIKHTAMATDataGridViewTextBoxColumn
        '
        Me.TARIKHTAMATDataGridViewTextBoxColumn.DataPropertyName = "TARIKH_TAMAT"
        Me.TARIKHTAMATDataGridViewTextBoxColumn.HeaderText = "TARIKH_TAMAT"
        Me.TARIKHTAMATDataGridViewTextBoxColumn.Name = "TARIKHTAMATDataGridViewTextBoxColumn"
        '
        'NOINVOISDataGridViewTextBoxColumn
        '
        Me.NOINVOISDataGridViewTextBoxColumn.DataPropertyName = "NO_INVOIS"
        Me.NOINVOISDataGridViewTextBoxColumn.HeaderText = "NO_INVOIS"
        Me.NOINVOISDataGridViewTextBoxColumn.Name = "NOINVOISDataGridViewTextBoxColumn"
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(467, 272)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(89, 33)
        Me.btnTambah.TabIndex = 35
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'PROGRAMTableAdapter
        '
        Me.PROGRAMTableAdapter.ClearBeforeFill = True
        '
        'PROGRAMTableAdapterManager
        '
        Me.PROGRAMTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.PROGRAMTableAdapterManager.PROGRAMTableAdapter = Me.PROGRAMTableAdapter
        Me.PROGRAMTableAdapterManager.UpdateOrder = Rekod_Client_Awaken.tblprogramDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'REKOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(770, 601)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuang)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtInvois)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnKosong)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTrainer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPIC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTempat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.txtClient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "REKOD"
        Me.Text = "SISTEM REKOD PROGRAM AWAKEN TRAINING & CONSULTANCY SDN BHD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblprogramDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKosong As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTempat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPIC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTrainer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInvois As TextBox
    Friend WithEvents btnBuang As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblprogramDataSet As tblprogramDataSet
    Friend WithEvents PROGRAMBindingSource As BindingSource
    Friend WithEvents PROGRAMTableAdapter As tblprogramDataSetTableAdapters.PROGRAMTableAdapter
    Friend WithEvents PROGRAMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TEMPATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TRAINERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARIKHMULADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARIKHTAMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORGANISASIAGENSIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOINVOISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROGRAMTableAdapterManager As tblprogramDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnTambah As Button
End Class
