<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profil
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_teamProfile = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_positionStyleAnalysis = New DevExpress.XtraEditors.CheckEdit()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SkorCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TestCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JenisKelamin_ComboBoxEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NomorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TglLahirDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.TglTest_DateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.datakelompoktes_MemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.tujuan_MemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.Pendidikan_ComboBoxEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblWelcome = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_teamProfile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_positionStyleAnalysis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkorCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisKelamin_ComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglLahirDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglTest_DateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglTest_DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datakelompoktes_MemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tujuan_MemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pendidikan_ComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(900, 49)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 551)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(900, 31)
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.chk_teamProfile)
        Me.Panel1.Controls.Add(Me.chk_positionStyleAnalysis)
        Me.Panel1.Controls.Add(Me.SaveSimpleButton)
        Me.Panel1.Controls.Add(Me.SkorCheckEdit)
        Me.Panel1.Controls.Add(Me.TestCheckEdit)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.lblWelcome)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 502)
        Me.Panel1.TabIndex = 2
        '
        'chk_teamProfile
        '
        Me.chk_teamProfile.Location = New System.Drawing.Point(444, 428)
        Me.chk_teamProfile.Name = "chk_teamProfile"
        Me.chk_teamProfile.Properties.Caption = "Position Style Analysis"
        Me.chk_teamProfile.Properties.RadioGroupIndex = 1
        Me.chk_teamProfile.Size = New System.Drawing.Size(157, 19)
        Me.chk_teamProfile.TabIndex = 19
        Me.chk_teamProfile.TabStop = False
        Me.chk_teamProfile.Visible = False
        '
        'chk_positionStyleAnalysis
        '
        Me.chk_positionStyleAnalysis.Location = New System.Drawing.Point(444, 403)
        Me.chk_positionStyleAnalysis.Name = "chk_positionStyleAnalysis"
        Me.chk_positionStyleAnalysis.Properties.Caption = "Position Style Analysis"
        Me.chk_positionStyleAnalysis.Properties.RadioGroupIndex = 1
        Me.chk_positionStyleAnalysis.Size = New System.Drawing.Size(157, 19)
        Me.chk_positionStyleAnalysis.TabIndex = 18
        Me.chk_positionStyleAnalysis.TabStop = False
        Me.chk_positionStyleAnalysis.Visible = False
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Location = New System.Drawing.Point(669, 413)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveSimpleButton.TabIndex = 17
        Me.SaveSimpleButton.Text = "Save"
        '
        'SkorCheckEdit
        '
        Me.SkorCheckEdit.Location = New System.Drawing.Point(548, 378)
        Me.SkorCheckEdit.Name = "SkorCheckEdit"
        Me.SkorCheckEdit.Properties.Caption = "Skoring Tes MBTI"
        Me.SkorCheckEdit.Properties.RadioGroupIndex = 1
        Me.SkorCheckEdit.Size = New System.Drawing.Size(157, 19)
        Me.SkorCheckEdit.TabIndex = 16
        Me.SkorCheckEdit.TabStop = False
        '
        'TestCheckEdit
        '
        Me.TestCheckEdit.EditValue = True
        Me.TestCheckEdit.Location = New System.Drawing.Point(444, 378)
        Me.TestCheckEdit.Name = "TestCheckEdit"
        Me.TestCheckEdit.Properties.Caption = "Tes MBTI"
        Me.TestCheckEdit.Properties.RadioGroupIndex = 1
        Me.TestCheckEdit.Size = New System.Drawing.Size(98, 19)
        Me.TestCheckEdit.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.82895!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.17105!))
        Me.TableLayoutPanel1.Controls.Add(Me.NamaTextEdit, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.JenisKelamin_ComboBoxEdit, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.NomorTextEdit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TglLahirDateEdit, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TglTest_DateEdit, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.datakelompoktes_MemoEdit, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tujuan_MemoEdit, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Pendidikan_ComboBoxEdit, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(444, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 352)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'NamaTextEdit
        '
        Me.NamaTextEdit.Location = New System.Drawing.Point(119, 31)
        Me.NamaTextEdit.Name = "NamaTextEdit"
        Me.NamaTextEdit.Size = New System.Drawing.Size(182, 20)
        Me.NamaTextEdit.TabIndex = 9
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Tidak boleh kosong"
        Me.DxValidationProvider1.SetValidationRule(Me.NamaTextEdit, ConditionValidationRule1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tgl Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pendidikan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tgl Tes"
        '
        'JenisKelamin_ComboBoxEdit
        '
        Me.JenisKelamin_ComboBoxEdit.Location = New System.Drawing.Point(119, 85)
        Me.JenisKelamin_ComboBoxEdit.Name = "JenisKelamin_ComboBoxEdit"
        Me.JenisKelamin_ComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JenisKelamin_ComboBoxEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Jenis_kelamin1", "Jenis Kelamin")})
        Me.JenisKelamin_ComboBoxEdit.Properties.DisplayMember = "Jenis_kelamin1"
        Me.JenisKelamin_ComboBoxEdit.Properties.NullText = ""
        Me.JenisKelamin_ComboBoxEdit.Properties.PopupSizeable = False
        Me.JenisKelamin_ComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.JenisKelamin_ComboBoxEdit.Properties.ValueMember = "id"
        Me.JenisKelamin_ComboBoxEdit.Size = New System.Drawing.Size(126, 20)
        Me.JenisKelamin_ComboBoxEdit.TabIndex = 11
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater
        ConditionValidationRule2.ErrorText = "Tidak boleh kosong"
        ConditionValidationRule2.Value1 = 0
        Me.DxValidationProvider1.SetValidationRule(Me.JenisKelamin_ComboBoxEdit, ConditionValidationRule2)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Data Kelompok Tes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tujuan"
        '
        'NomorTextEdit
        '
        Me.NomorTextEdit.Location = New System.Drawing.Point(119, 4)
        Me.NomorTextEdit.Name = "NomorTextEdit"
        Me.NomorTextEdit.Properties.NullText = "Automatic"
        Me.NomorTextEdit.Properties.ReadOnly = True
        Me.NomorTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NomorTextEdit.TabIndex = 8
        '
        'TglLahirDateEdit
        '
        Me.TglLahirDateEdit.EditValue = Nothing
        Me.TglLahirDateEdit.Location = New System.Drawing.Point(119, 60)
        Me.TglLahirDateEdit.Name = "TglLahirDateEdit"
        Me.TglLahirDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglLahirDateEdit.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.TglLahirDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TglLahirDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TglLahirDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.TglLahirDateEdit.TabIndex = 10
        '
        'TglTest_DateEdit
        '
        Me.TglTest_DateEdit.EditValue = Nothing
        Me.TglTest_DateEdit.Location = New System.Drawing.Point(119, 140)
        Me.TglTest_DateEdit.Name = "TglTest_DateEdit"
        Me.TglTest_DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglTest_DateEdit.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.TglTest_DateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TglTest_DateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TglTest_DateEdit.Size = New System.Drawing.Size(100, 20)
        Me.TglTest_DateEdit.TabIndex = 13
        '
        'datakelompoktes_MemoEdit
        '
        Me.datakelompoktes_MemoEdit.Location = New System.Drawing.Point(119, 168)
        Me.datakelompoktes_MemoEdit.Name = "datakelompoktes_MemoEdit"
        Me.datakelompoktes_MemoEdit.Size = New System.Drawing.Size(182, 96)
        Me.datakelompoktes_MemoEdit.TabIndex = 14
        '
        'tujuan_MemoEdit
        '
        Me.tujuan_MemoEdit.Location = New System.Drawing.Point(119, 275)
        Me.tujuan_MemoEdit.Name = "tujuan_MemoEdit"
        Me.tujuan_MemoEdit.Size = New System.Drawing.Size(182, 73)
        Me.tujuan_MemoEdit.TabIndex = 15
        '
        'Pendidikan_ComboBoxEdit
        '
        Me.Pendidikan_ComboBoxEdit.Location = New System.Drawing.Point(119, 113)
        Me.Pendidikan_ComboBoxEdit.Name = "Pendidikan_ComboBoxEdit"
        Me.Pendidikan_ComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Pendidikan_ComboBoxEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pendidikan", "Pendidikan")})
        Me.Pendidikan_ComboBoxEdit.Properties.DisplayMember = "Pendidikan"
        Me.Pendidikan_ComboBoxEdit.Properties.NullText = ""
        Me.Pendidikan_ComboBoxEdit.Properties.PopupSizeable = False
        Me.Pendidikan_ComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Pendidikan_ComboBoxEdit.Properties.ValueMember = "id"
        Me.Pendidikan_ComboBoxEdit.Size = New System.Drawing.Size(126, 20)
        Me.Pendidikan_ComboBoxEdit.TabIndex = 12
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater
        ConditionValidationRule3.ErrorText = "Tidak boleh kosong"
        ConditionValidationRule3.Value1 = 0
        Me.DxValidationProvider1.SetValidationRule(Me.Pendidikan_ComboBoxEdit, ConditionValidationRule3)
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(13, 292)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(325, 21)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "LIGHT SPIRIT TECHNOLOGY Versi 1.0"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(32, 202)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(306, 36)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Enter your data to begin"
        '
        'lblWelcome
        '
        Me.lblWelcome.Appearance.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(125, 125)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(213, 55)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Test MBTI"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(86, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(252, 73)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Welcome"
        '
        'frm_profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_profil"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Profil"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chk_teamProfile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_positionStyleAnalysis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkorCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisKelamin_ComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglLahirDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglTest_DateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglTest_DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datakelompoktes_MemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tujuan_MemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pendidikan_ComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SkorCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TestCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JenisKelamin_ComboBoxEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NomorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TglLahirDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TglTest_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents datakelompoktes_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tujuan_MemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Pendidikan_ComboBoxEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblWelcome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents chk_teamProfile As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_positionStyleAnalysis As DevExpress.XtraEditors.CheckEdit


End Class
