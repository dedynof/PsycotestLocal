Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports Window_Forms_Report

Public Class frm_MI_test : Implements I_MI_test
    Private _profil_id As Integer
    Private _Presenter As mi_test_Presenter

    Public Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New mi_test_Presenter(Me)
        _Presenter.DisplayNomorPreserta()
    End Sub

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_MI_test.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public WriteOnly Property NomorPeserta As String Implements Window_Forms_View.I_MI_test.NomorPeserta
        Set(value As String)
            lblnomor.Text = "Nomor : " & value
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_MI_test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_MI_test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public ReadOnly Property K1 As Integer Implements Window_Forms_View.I_MI_test.K1
        Get
            Return If(chk_1_3.Checked, 3, 0) + If(chk_9_4.Checked, 4, 0) + If(chk_17_4.Checked, 4, 0) + If(chk_25_4.Checked, 4, 0) + If(chk_33_4.Checked, 4, 0) + If(chk_41_5.Checked, 5, 0) + If(chk_49_1.Checked, 1, 0) + If(chk_58_1.Checked, 1, 0) + If(chk_65_5.Checked, 5, 0) + If(chk_73_3.Checked, 3, 0)
        End Get
    End Property

    Public ReadOnly Property K2 As Integer Implements Window_Forms_View.I_MI_test.K2
        Get
            Return If(chk_2_2.Checked, 2, 0) + If(chk_10_3.Checked, 3, 0) + If(chk_18_5.Checked, 5, 0) + If(chk_26_3.Checked, 3, 0) + If(chk_34_4.Checked, 4, 0) + If(chk_42_5.Checked, 5, 0) + If(chk_50_2.Checked, 2, 0) + If(chk_58_2.Checked, 2, 0) + If(chk_66_4.Checked, 4, 0) + If(chk_74_4.Checked, 4, 0)
        End Get
    End Property

    Public ReadOnly Property K3 As Integer Implements Window_Forms_View.I_MI_test.K3
        Get
            Return If(chk_3_4.Checked, 4, 0) + If(chk_11_2.Checked, 2, 0) + If(chk_19_4.Checked, 4, 0) + If(chk_27_2.Checked, 2, 0) + If(chk_35_5.Checked, 5, 0) + If(chk_43_3.Checked, 3, 0) + If(chk_51_2.Checked, 2, 0) + If(chk_59_3.Checked, 3, 0) + If(chk_67_4.Checked, 4, 0) + If(chk_75_4.Checked, 4, 0)
        End Get
    End Property

    Public ReadOnly Property K4 As Integer Implements Window_Forms_View.I_MI_test.K4
        Get
            Return If(chk_4_5.Checked, 5, 0) + If(chk_12_2.Checked, 2, 0) + If(chk_20_3.Checked, 3, 0) + If(chk_28_5.Checked, 5, 0) + If(chk_36_3.Checked, 3, 0) + If(chk_44_4.Checked, 4, 0) + If(chk_52_2.Checked, 2, 0) + If(chk_60_3.Checked, 3, 0) + If(chk_68_4.Checked, 4, 0) + If(chk_76_5.Checked, 5, 0)
        End Get
    End Property

    Public ReadOnly Property K5 As Integer Implements Window_Forms_View.I_MI_test.K5
        Get
            Return If(chk_5_2.Checked, 2, 0) + If(chk_13_1.Checked, 1, 0) + If(chk_21_2.Checked, 2, 0) + If(chk_28_3.Checked, 3, 0) + If(chk_37_4.Checked, 4, 0) + If(chk_48_2.Checked, 2, 0) + If(chk_53_3.Checked, 3, 0) + If(chk_61_4.Checked, 4, 0) + If(chk_69_5.Checked, 5, 0) + If(chk_77_4.Checked, 4, 0)
        End Get
    End Property

    Public ReadOnly Property K6 As Integer Implements Window_Forms_View.I_MI_test.K6
        Get
            Return If(chk_6_1.Checked, 1, 0) + If(chk_14_3.Checked, 3, 0) + If(chk_22_1.Checked, 1, 0) + If(chk_30_5.Checked, 5, 0) + If(chk_38_2.Checked, 2, 0) + If(chk_46_1.Checked, 1, 0) + If(chk_54_3.Checked, 3, 0) + If(chk_62_1.Checked, 1, 0) + If(chk_70_4.Checked, 4, 0) + If(chk_78_3.Checked, 3, 0)
        End Get
    End Property

    Public ReadOnly Property K7 As Integer Implements Window_Forms_View.I_MI_test.K7
        Get
            Return If(chk_7_2.Checked, 2, 0) + If(chk_15_4.Checked, 4, 0) + If(chk_23_3.Checked, 3, 0) + If(chk_31_5.Checked, 5, 0) + If(chk_39_3.Checked, 3, 0) + If(chk_47_2.Checked, 2, 0) + If(chk_55_5.Checked, 5, 0) + If(chk_63_2.Checked, 2, 0) + If(chk_71_5.Checked, 5, 0) + If(chk_79_2.Checked, 2, 0)
        End Get
    End Property

    Public ReadOnly Property K8 As Integer Implements Window_Forms_View.I_MI_test.K8
        Get
            Return If(chk_8_3.Checked, 3, 0) + If(chk_16_3.Checked, 3, 0) + If(chk_24_4.Checked, 4, 0) + If(chk_32_4.Checked, 4, 0) + If(chk_40_2.Checked, 2, 0) + If(chk_48_3.Checked, 3, 0) + If(chk_56_4.Checked, 4, 0) + If(chk_64_3.Checked, 3, 0) + If(chk_72_4.Checked, 4, 0) + If(chk_80_1.Checked, 1, 0)
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim arrNomor(80) As Integer
        For Each Control In Me.TableLayoutPanel1.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel3.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex + 20) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel4.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex + 40) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel5.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex + 60) += If(x.Checked, 1, 0)
            End If

        Next
        For i As Integer = 1 To 80
            If arrNomor(i) = 0 Then
                errMessage = "No " & i & " harus diisi!"
                Return
            End If
        Next
        If _Presenter.save Then
            btnResult.Enabled = True
        End If
    End Sub

    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub

    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MI(_Presenter.Get_Profil, _Presenter.Get_MI_jawaban)
        rpt.ShowPreviewDialog()
    End Sub
End Class