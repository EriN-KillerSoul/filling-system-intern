<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CETAK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CETAK))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PROGRAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRAINERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIKHMULADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIKHTAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOINVOISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROGRAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblprogramDataSet = New Rekod_Client_Awaken.tblprogramDataSet()
        Me.PROGRAMTableAdapter = New Rekod_Client_Awaken.tblprogramDataSetTableAdapters.PROGRAMTableAdapter()
        Me.PROGRAMTableAdapterManager = New Rekod_Client_Awaken.tblprogramDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnKosong = New System.Windows.Forms.Button()
        Me.cmCari = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblprogramDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(162, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 28)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "SISTEM REKOD PROGRAM"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(162, 95)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(584, 28)
        Me.lbltitle.TabIndex = 31
        Me.lbltitle.Text = "AWAKEN TRAINING AND CONSULTANCY SDN BHD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(839, 47)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(101, 33)
        Me.btnMenu.TabIndex = 34
        Me.btnMenu.Text = "MENU UTAMA"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(839, 90)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(101, 33)
        Me.btnKeluar.TabIndex = 33
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(839, 134)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(101, 33)
        Me.btnCetak.TabIndex = 36
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(839, 179)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(101, 33)
        Me.btnView.TabIndex = 35
        Me.btnView.Text = "PREVIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROGRAMDataGridViewTextBoxColumn, Me.TEMPATDataGridViewTextBoxColumn, Me.TRAINERDataGridViewTextBoxColumn, Me.HARGADataGridViewTextBoxColumn, Me.PICDataGridViewTextBoxColumn, Me.TARIKHMULADataGridViewTextBoxColumn, Me.TARIKHTAMATDataGridViewTextBoxColumn, Me.NOINVOISDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PROGRAMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(947, 342)
        Me.DataGridView1.TabIndex = 37
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
        'PROGRAMTableAdapter
        '
        Me.PROGRAMTableAdapter.ClearBeforeFill = True
        '
        'PROGRAMTableAdapterManager
        '
        Me.PROGRAMTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.PROGRAMTableAdapterManager.Connection = Nothing
        Me.PROGRAMTableAdapterManager.PROGRAMTableAdapter = Nothing
        Me.PROGRAMTableAdapterManager.UpdateOrder = Rekod_Client_Awaken.tblprogramDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(993, 25)
        Me.BindingNavigator1.TabIndex = 38
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCari.Location = New System.Drawing.Point(242, 160)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(55, 16)
        Me.lblCari.TabIndex = 39
        Me.lblCari.Text = "CARIAN :"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(507, 155)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 41
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnKosong
        '
        Me.btnKosong.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKosong.Location = New System.Drawing.Point(592, 155)
        Me.btnKosong.Name = "btnKosong"
        Me.btnKosong.Size = New System.Drawing.Size(102, 23)
        Me.btnKosong.TabIndex = 42
        Me.btnKosong.Text = "KOSONGKAN"
        Me.btnKosong.UseVisualStyleBackColor = True
        '
        'cmCari
        '
        Me.cmCari.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROGRAMBindingSource, "PROGRAM", True))
        Me.cmCari.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROGRAMBindingSource, "PROGRAM", True))
        Me.cmCari.DataSource = Me.PROGRAMBindingSource
        Me.cmCari.DisplayMember = "PROGRAM"
        Me.cmCari.FormattingEnabled = True
        Me.cmCari.Location = New System.Drawing.Point(301, 157)
        Me.cmCari.Name = "cmCari"
        Me.cmCari.Size = New System.Drawing.Size(185, 21)
        Me.cmCari.TabIndex = 43
        Me.cmCari.ValueMember = "PROGRAM"
        '
        'CETAK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(993, 609)
        Me.Controls.Add(Me.cmCari)
        Me.Controls.Add(Me.btnKosong)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CETAK"
        Me.Text = "SISTEM REKOD PROGRAM AWAKEN TRAINING&CONSULTANCY SDN BHD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblprogramDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnView As Button
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
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents lblCari As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnKosong As Button
    Friend WithEvents cmCari As ComboBox
End Class
