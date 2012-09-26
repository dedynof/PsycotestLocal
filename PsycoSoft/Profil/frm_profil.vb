Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports DevExpress.XtraSplashScreen

Public Class frm_profil : Implements I_Profil


    Private _Presenter As Profil_Presenter
    Dim _id As Integer
    Sub New(module_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Presenter = New Profil_Presenter(Me)
        _module_id = module_id
        _Presenter.DisplayJenisKelamins()
        _Presenter.DisplayPendidikans()
        _Presenter.Display()
        _Presenter.Set_CaptionKodeModul()
    End Sub
    Public WriteOnly Property errMsg As String Implements Window_Forms_View.I_Profil.errMsg
        Set(value As String)
            MessageBox.Show(value, "Error.....", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public WriteOnly Property JenisKelamins As System.Collections.Generic.IList(Of Window_Forms_Model.jenis_kelamin_entity) Implements Window_Forms_View.I_Profil.JenisKelamins
        Set(value As System.Collections.Generic.IList(Of Window_Forms_Model.jenis_kelamin_entity))
            JenisKelamin_ComboBoxEdit.Properties.DataSource = value
        End Set
    End Property

    Public WriteOnly Property suksesMsg As String Implements Window_Forms_View.I_Profil.suksesMsg
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property
    Dim _module_id As Integer
    Public ReadOnly Property module_id As Integer Implements Window_Forms_View.I_Profil.module_id
        Get
            Return _module_id
        End Get
    End Property

    Public WriteOnly Property Pendidikans As System.Collections.Generic.IList(Of Window_Forms_Model.Pendidikan_entity) Implements Window_Forms_View.I_Profil.Pendidikans
        Set(value As System.Collections.Generic.IList(Of Window_Forms_Model.Pendidikan_entity))
            Pendidikan_ComboBoxEdit.Properties.DataSource = value
        End Set
    End Property

    Private Sub SaveSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveSimpleButton.Click

        If Not DxValidationProvider1.Validate Then
            Return
        End If
        If _Presenter.Save Then
            If TestCheckEdit.Checked Then
                Show_Tes()
            Else
                Show_Skor()
            End If
        End If
    End Sub
    Private Sub Show_Tes()
        SplashScreenManager.ShowForm(Me, GetType(frm_WaitForm), True, True, False)
        Select Case module_id
            Case 1
                Dim f As New frm_test_mbti(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 2
                Dim f As New frm_disc_test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 4
                Dim f As New frm_SDS_Test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 5
                Dim f As New frm_belbin_test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 6
                Dim f As New frm_bigfive_test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 7
                Dim f As New frm_FiroB_Test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 8
                Dim f As New frm_eneagram_test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
            Case 9
                Dim f As New frm_MI_test(id)
                f.WindowState = FormWindowState.Maximized
                f.ShowDialog()
        End Select
        SplashScreenManager.CloseForm(False)
    End Sub
    Private Sub Show_Skor()
        Select Case module_id
            Case 1
                Dim f As New frm_mbti_skoring(id)
                f.ShowDialog()
        End Select
    End Sub
    Public Property data_kelompok As String Implements Window_Forms_View.I_Profil.data_kelompok
        Get
            Return datakelompoktes_MemoEdit.Text
        End Get
        Set(value As String)
            datakelompoktes_MemoEdit.Text = value
        End Set
    End Property

    Public Property id As Integer Implements Window_Forms_View.I_Profil.id
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property jenis_kelamin As Integer Implements Window_Forms_View.I_Profil.jenis_kelamin
        Get
            Return JenisKelamin_ComboBoxEdit.EditValue
        End Get
        Set(value As Integer)
            JenisKelamin_ComboBoxEdit.EditValue = value
        End Set
    End Property

    Public Property nama As String Implements Window_Forms_View.I_Profil.nama
        Get
            Return NamaTextEdit.Text
        End Get
        Set(value As String)
            NamaTextEdit.Text = value
        End Set
    End Property

    Public Property nomor As String Implements Window_Forms_View.I_Profil.nomor
        Get
            Return NomorTextEdit.Text
        End Get
        Set(value As String)
            NomorTextEdit.Text = value
        End Set
    End Property

    Public Property pendidikan As Integer Implements Window_Forms_View.I_Profil.pendidikan
        Get
            Return Pendidikan_ComboBoxEdit.EditValue
        End Get
        Set(value As Integer)
            Pendidikan_ComboBoxEdit.EditValue = value
        End Set
    End Property

    Public Property tgl_lahir As Date Implements Window_Forms_View.I_Profil.tgl_lahir
        Get
            Return TglLahirDateEdit.EditValue
        End Get
        Set(value As Date)
            TglLahirDateEdit.EditValue = value
        End Set
    End Property

    Public Property tgl_tes As Date Implements Window_Forms_View.I_Profil.tgl_tes
        Get
            Return TglTest_DateEdit.EditValue
        End Get
        Set(value As Date)
            TglTest_DateEdit.EditValue = value
        End Set
    End Property

    Public Property tujuan As String Implements Window_Forms_View.I_Profil.tujuan
        Get
            Return tujuan_MemoEdit.Text
        End Get
        Set(value As String)
            tujuan_MemoEdit.Text = value
        End Set
    End Property

    Private Sub frm_profil_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        NamaTextEdit.Focus()
    End Sub

    Public WriteOnly Property KodeModul As String Implements Window_Forms_View.I_Profil.KodeModul
        Set(value As String)
            lblWelcome.Text = "Tes " & value
            TestCheckEdit.Text = "Tes " & value
            SkorCheckEdit.Text = "Skoring Tes " & value
        End Set
    End Property
End Class