Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports DevExpress.XtraEditors
Imports Window_Forms_Report
Public Class frm_eneagram_test : Implements I_eneagram_test

    Private _profil_id As Integer
    Private _nomor As Integer
    Private _Presenter As eneagram_test_Presenter
    Public Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        Inisialisasi()
        _Presenter = New eneagram_test_Presenter(Me)
        _Presenter.DisplayNomor()
    End Sub
    Private Sub Inisialisasi()
        For Each x In TableLayoutPanel1.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel2.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel3.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel4.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel5.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel6.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel7.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel8.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel9.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
        For Each x In TableLayoutPanel10.Controls
            If TypeOf (x) Is CheckEdit Then
                AddHandler CType(x, CheckEdit).GotFocus, AddressOf chk_Y1_GotFocus
            End If
        Next
    End Sub

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_eneagram_test.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_eneagram_test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property SetNomor As String Implements Window_Forms_View.I_eneagram_test.SetNomor
        Set(value As String)
            lblNomor.Text = "Nomor : " & value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_eneagram_test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public ReadOnly Property nomor As Integer Implements Window_Forms_View.I_eneagram_test.nomor
        Get
            Return _nomor
        End Get
    End Property

    Public WriteOnly Property SetSoal As String Implements Window_Forms_View.I_eneagram_test.SetSoal
        Set(value As String)
            SoalMemoEdit.Text = value
        End Set
    End Property

    Private Sub chk_Y1_GotFocus(sender As Object, e As System.EventArgs) Handles chk_Y1.GotFocus
        _nomor = CType(sender, DevExpress.XtraEditors.CheckEdit).Properties.RadioGroupIndex
        _Presenter.SetSoal()
    End Sub
    Private Function convBoleanToInt(b As Boolean) As Integer
        If b Then
            Return 1
        End If
        Return 0
    End Function
    Public ReadOnly Property _A As Integer Implements Window_Forms_View.I_eneagram_test._A
        Get
            Return convBoleanToInt(chk_Y1.Checked) + convBoleanToInt(chk_Y10.Checked) + convBoleanToInt(chk_Y19.Checked) + convBoleanToInt(chk_Y28.Checked) + convBoleanToInt(chk_Y37.Checked) + convBoleanToInt(chk_Y46.Checked) + convBoleanToInt(chk_Y55.Checked) + convBoleanToInt(chk_Y64.Checked) + convBoleanToInt(chk_Y73.Checked) + convBoleanToInt(chk_Y82.Checked) + convBoleanToInt(chk_Y91.Checked) + convBoleanToInt(chk_Y100.Checked) + convBoleanToInt(chk_Y109.Checked) + convBoleanToInt(chk_Y118.Checked) + convBoleanToInt(chk_Y127.Checked) + convBoleanToInt(chk_Y136.Checked) + convBoleanToInt(chk_Y145.Checked) + convBoleanToInt(chk_Y154.Checked) + convBoleanToInt(chk_Y163.Checked) + convBoleanToInt(chk_Y172.Checked)
        End Get
    End Property

    Public ReadOnly Property _B As Integer Implements Window_Forms_View.I_eneagram_test._B
        Get
            Return convBoleanToInt(chk_Y2.Checked) + convBoleanToInt(chk_Y11.Checked) + convBoleanToInt(chk_Y20.Checked) + convBoleanToInt(chk_Y29.Checked) + convBoleanToInt(chk_Y38.Checked) + convBoleanToInt(chk_Y47.Checked) + convBoleanToInt(chk_Y56.Checked) + convBoleanToInt(chk_Y65.Checked) + convBoleanToInt(chk_Y74.Checked) + convBoleanToInt(chk_Y83.Checked) + convBoleanToInt(chk_Y92.Checked) + convBoleanToInt(chk_Y101.Checked) + convBoleanToInt(chk_Y110.Checked) + convBoleanToInt(chk_Y119.Checked) + convBoleanToInt(chk_Y128.Checked) + convBoleanToInt(chk_Y137.Checked) + convBoleanToInt(chk_Y146.Checked) + convBoleanToInt(chk_Y155.Checked) + convBoleanToInt(chk_Y164.Checked) + convBoleanToInt(chk_Y173.Checked)
        End Get
    End Property

    Public ReadOnly Property _C As Integer Implements Window_Forms_View.I_eneagram_test._C
        Get
            Return convBoleanToInt(chk_Y3.Checked) + convBoleanToInt(chk_Y12.Checked) + convBoleanToInt(chk_Y21.Checked) + convBoleanToInt(chk_Y30.Checked) + convBoleanToInt(chk_Y39.Checked) + convBoleanToInt(chk_Y48.Checked) + convBoleanToInt(chk_Y57.Checked) + convBoleanToInt(chk_Y66.Checked) + convBoleanToInt(chk_Y75.Checked) + convBoleanToInt(chk_Y84.Checked) + convBoleanToInt(chk_Y93.Checked) + convBoleanToInt(chk_Y102.Checked) + convBoleanToInt(chk_Y111.Checked) + convBoleanToInt(chk_Y120.Checked) + convBoleanToInt(chk_Y129.Checked) + convBoleanToInt(chk_Y138.Checked) + convBoleanToInt(chk_Y147.Checked) + convBoleanToInt(chk_Y156.Checked) + convBoleanToInt(chk_Y165.Checked) + convBoleanToInt(chk_Y174.Checked)
        End Get
    End Property

    Public ReadOnly Property _D As Integer Implements Window_Forms_View.I_eneagram_test._D
        Get
            Return convBoleanToInt(chk_Y4.Checked) + convBoleanToInt(chk_Y13.Checked) + convBoleanToInt(chk_Y22.Checked) + convBoleanToInt(chk_Y31.Checked) + convBoleanToInt(chk_Y40.Checked) + convBoleanToInt(chk_Y49.Checked) + convBoleanToInt(chk_Y58.Checked) + convBoleanToInt(chk_Y67.Checked) + convBoleanToInt(chk_Y76.Checked) + convBoleanToInt(chk_Y85.Checked) + convBoleanToInt(chk_Y94.Checked) + convBoleanToInt(chk_Y103.Checked) + convBoleanToInt(chk_Y112.Checked) + convBoleanToInt(chk_Y121.Checked) + convBoleanToInt(chk_Y130.Checked) + convBoleanToInt(chk_Y139.Checked) + convBoleanToInt(chk_Y148.Checked) + convBoleanToInt(chk_Y157.Checked) + convBoleanToInt(chk_Y166.Checked) + convBoleanToInt(chk_Y175.Checked)
        End Get
    End Property

    Public ReadOnly Property _E As Integer Implements Window_Forms_View.I_eneagram_test._E
        Get
            Return convBoleanToInt(chk_Y5.Checked) + convBoleanToInt(chk_Y14.Checked) + convBoleanToInt(chk_Y23.Checked) + convBoleanToInt(chk_Y32.Checked) + convBoleanToInt(chk_Y41.Checked) + convBoleanToInt(chk_Y50.Checked) + convBoleanToInt(chk_Y59.Checked) + convBoleanToInt(chk_Y68.Checked) + convBoleanToInt(chk_Y77.Checked) + convBoleanToInt(chk_Y86.Checked) + convBoleanToInt(chk_Y95.Checked) + convBoleanToInt(chk_Y104.Checked) + convBoleanToInt(chk_Y113.Checked) + convBoleanToInt(chk_Y122.Checked) + convBoleanToInt(chk_Y131.Checked) + convBoleanToInt(chk_Y140.Checked) + convBoleanToInt(chk_Y149.Checked) + convBoleanToInt(chk_Y158.Checked) + convBoleanToInt(chk_Y167.Checked) + convBoleanToInt(chk_Y176.Checked)
        End Get
    End Property

    Public ReadOnly Property _F As Integer Implements Window_Forms_View.I_eneagram_test._F
        Get
            Return convBoleanToInt(chk_Y6.Checked) + convBoleanToInt(chk_Y15.Checked) + convBoleanToInt(chk_Y24.Checked) + convBoleanToInt(chk_Y33.Checked) + convBoleanToInt(chk_Y42.Checked) + convBoleanToInt(chk_Y51.Checked) + convBoleanToInt(chk_Y60.Checked) + convBoleanToInt(chk_Y69.Checked) + convBoleanToInt(chk_Y78.Checked) + convBoleanToInt(chk_Y87.Checked) + convBoleanToInt(chk_Y96.Checked) + convBoleanToInt(chk_Y105.Checked) + convBoleanToInt(chk_Y114.Checked) + convBoleanToInt(chk_Y123.Checked) + convBoleanToInt(chk_Y132.Checked) + convBoleanToInt(chk_Y141.Checked) + convBoleanToInt(chk_Y150.Checked) + convBoleanToInt(chk_Y159.Checked) + convBoleanToInt(chk_Y168.Checked) + convBoleanToInt(chk_Y177.Checked)
        End Get
    End Property

    Public ReadOnly Property _G As Integer Implements Window_Forms_View.I_eneagram_test._G
        Get
            Return convBoleanToInt(chk_Y7.Checked) + convBoleanToInt(chk_Y16.Checked) + convBoleanToInt(chk_Y25.Checked) + convBoleanToInt(chk_Y34.Checked) + convBoleanToInt(chk_Y43.Checked) + convBoleanToInt(chk_Y52.Checked) + convBoleanToInt(chk_Y61.Checked) + convBoleanToInt(chk_Y70.Checked) + convBoleanToInt(chk_Y79.Checked) + convBoleanToInt(chk_Y88.Checked) + convBoleanToInt(chk_Y97.Checked) + convBoleanToInt(chk_Y106.Checked) + convBoleanToInt(chk_Y115.Checked) + convBoleanToInt(chk_Y124.Checked) + convBoleanToInt(chk_Y133.Checked) + convBoleanToInt(chk_Y142.Checked) + convBoleanToInt(chk_Y151.Checked) + convBoleanToInt(chk_Y160.Checked) + convBoleanToInt(chk_Y169.Checked) + convBoleanToInt(chk_Y178.Checked)
        End Get
    End Property

    Public ReadOnly Property _H As Integer Implements Window_Forms_View.I_eneagram_test._H
        Get
            Return convBoleanToInt(chk_Y8.Checked) + convBoleanToInt(chk_Y17.Checked) + convBoleanToInt(chk_Y26.Checked) + convBoleanToInt(chk_Y35.Checked) + convBoleanToInt(chk_Y44.Checked) + convBoleanToInt(chk_Y53.Checked) + convBoleanToInt(chk_Y62.Checked) + convBoleanToInt(chk_Y71.Checked) + convBoleanToInt(chk_Y80.Checked) + convBoleanToInt(chk_Y89.Checked) + convBoleanToInt(chk_Y98.Checked) + convBoleanToInt(chk_Y107.Checked) + convBoleanToInt(chk_Y116.Checked) + convBoleanToInt(chk_Y125.Checked) + convBoleanToInt(chk_Y134.Checked) + convBoleanToInt(chk_Y143.Checked) + convBoleanToInt(chk_Y152.Checked) + convBoleanToInt(chk_Y161.Checked) + convBoleanToInt(chk_Y170.Checked) + convBoleanToInt(chk_Y179.Checked)
        End Get
    End Property

    Public ReadOnly Property _I As Integer Implements Window_Forms_View.I_eneagram_test._I
        Get
            Return convBoleanToInt(chk_Y9.Checked) + convBoleanToInt(chk_Y18.Checked) + convBoleanToInt(chk_Y27.Checked) + convBoleanToInt(chk_Y36.Checked) + convBoleanToInt(chk_Y45.Checked) + convBoleanToInt(chk_Y54.Checked) + convBoleanToInt(chk_Y63.Checked) + convBoleanToInt(chk_Y72.Checked) + convBoleanToInt(chk_Y81.Checked) + convBoleanToInt(chk_Y90.Checked) + convBoleanToInt(chk_Y99.Checked) + convBoleanToInt(chk_Y108.Checked) + convBoleanToInt(chk_Y117.Checked) + convBoleanToInt(chk_Y126.Checked) + convBoleanToInt(chk_Y135.Checked) + convBoleanToInt(chk_Y144.Checked) + convBoleanToInt(chk_Y153.Checked) + convBoleanToInt(chk_Y162.Checked) + convBoleanToInt(chk_Y171.Checked) + convBoleanToInt(chk_Y180.Checked)
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim j(180) As Integer
        For Each x In TableLayoutPanel1.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel2.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel3.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel4.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel5.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel6.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel7.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel8.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel9.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For Each x In TableLayoutPanel10.Controls
            If TypeOf (x) Is CheckEdit Then
                j(CType(x, CheckEdit).Properties.RadioGroupIndex) += convBoleanToInt(CType(x, CheckEdit).Checked)
            End If
        Next
        For i As Integer = 1 To 180
            If j(i) <= 0 Then
                errMessage = "Nomor : " & i & " Tidak boleh kosong"
                Return
            End If
        Next
        If _Presenter.save Then
            btnResult.Enabled = True
        End If
    End Sub

    Private Sub btnOut_Click(sender As Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub

    Private Sub btnResult_Click(sender As Object, e As System.EventArgs) Handles btnResult.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_eneagram(_Presenter.Get_Profil, _Presenter.Get_eneagram)
        rpt.ShowPreviewDialog()
    End Sub
End Class