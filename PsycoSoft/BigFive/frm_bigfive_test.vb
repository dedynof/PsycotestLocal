Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_Report
Imports Window_Forms_View
Imports DevExpress.XtraEditors

Public Class frm_bigfive_test : Implements I_BigFive_Test

    Private _Presenter As BigFive_Test_Presenter
    Private _profil_id As Integer
    Public Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New BigFive_Test_Presenter(Me)
        _Presenter.DisplayNomor()
    End Sub

    Public WriteOnly Property errorMessage As String Implements Window_Forms_View.I_BigFive_Test.errorMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_BigFive_Test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property SetNomor As String Implements Window_Forms_View.I_BigFive_Test.SetNomor
        Set(value As String)
            lblnomor.Text = "Nomor : " & value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_BigFive_Test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property
  
    Public ReadOnly Property _a As Integer Implements Window_Forms_View.I_BigFive_Test._a
        Get
            Dim x As Integer = 0
            x = chk_2_1.EditValue + chk_2_2.EditValue + chk_2_3.EditValue + chk_2_4.EditValue + chk_2_5.EditValue
            x += chk_7_1.EditValue + chk_7_2.EditValue + chk_7_3.EditValue + chk_7_4.EditValue + chk_7_5.EditValue
            x += chk_12_1.EditValue + chk_12_2.EditValue + chk_12_3.EditValue + chk_12_4.EditValue + chk_12_5.EditValue
            x += chk_17_1.EditValue + chk_17_2.EditValue + chk_17_3.EditValue + chk_17_4.EditValue + chk_17_5.EditValue
            x += chk_22_1.EditValue + chk_22_2.EditValue + chk_22_3.EditValue + chk_22_4.EditValue + chk_22_5.EditValue
            x += chk_27_1.EditValue + chk_27_2.EditValue + chk_27_3.EditValue + chk_27_4.EditValue + chk_27_5.EditValue
            x += chk_32_1.EditValue + chk_32_2.EditValue + chk_32_3.EditValue + chk_32_4.EditValue + chk_32_5.EditValue
            x += chk_37_1.EditValue + chk_37_2.EditValue + chk_37_3.EditValue + chk_37_4.EditValue + chk_37_5.EditValue
            x += chk_42_1.EditValue + chk_42_2.EditValue + chk_42_3.EditValue + chk_42_4.EditValue + chk_42_5.EditValue

            Return x
        End Get
    End Property

    Public ReadOnly Property _c As Integer Implements Window_Forms_View.I_BigFive_Test._c
        Get
            Dim x As Integer = 0
            x = chk_3_1.EditValue + chk_3_2.EditValue + chk_3_3.EditValue + chk_3_4.EditValue + chk_3_5.EditValue
            x += chk_8_1.EditValue + chk_8_2.EditValue + chk_8_3.EditValue + chk_8_4.EditValue + chk_8_5.EditValue
            x += chk_13_1.EditValue + chk_13_2.EditValue + chk_13_3.EditValue + chk_13_4.EditValue + chk_13_5.EditValue
            x += chk_18_1.EditValue + chk_18_2.EditValue + chk_18_3.EditValue + chk_18_4.EditValue + chk_18_5.EditValue
            x += chk_23_1.EditValue + chk_23_2.EditValue + chk_23_3.EditValue + chk_23_4.EditValue + chk_23_5.EditValue
            x += chk_28_1.EditValue + chk_28_2.EditValue + chk_28_3.EditValue + chk_28_4.EditValue + chk_28_5.EditValue
            x += chk_33_1.EditValue + chk_33_2.EditValue + chk_33_3.EditValue + chk_33_4.EditValue + chk_33_5.EditValue
            x += chk_38_1.EditValue + chk_38_2.EditValue + chk_38_3.EditValue + chk_38_4.EditValue + chk_38_5.EditValue
            x += chk_43_1.EditValue + chk_43_2.EditValue + chk_43_3.EditValue + chk_43_4.EditValue + chk_43_5.EditValue

            Return x
        End Get
    End Property

    Public ReadOnly Property _e As Integer Implements Window_Forms_View.I_BigFive_Test._e
        Get
            Dim x As Integer = 0
            x = chk_1_1.EditValue + chk_1_2.EditValue + chk_1_3.EditValue + chk_1_4.EditValue + chk_1_5.EditValue
            x += chk_6_1.EditValue + chk_6_2.EditValue + chk_6_3.EditValue + chk_6_4.EditValue + chk_6_5.EditValue
            x += chk_11_1.EditValue + chk_11_2.EditValue + chk_11_3.EditValue + chk_11_4.EditValue + chk_11_5.EditValue
            x += chk_16_1.EditValue + chk_16_2.EditValue + chk_16_3.EditValue + chk_16_4.EditValue + chk_16_5.EditValue
            x += chk_21_1.EditValue + chk_21_2.EditValue + chk_21_3.EditValue + chk_21_4.EditValue + chk_21_5.EditValue
            x += chk_26_1.EditValue + chk_26_2.EditValue + chk_26_3.EditValue + chk_26_4.EditValue + chk_26_5.EditValue
            x += chk_31_1.EditValue + chk_31_2.EditValue + chk_31_3.EditValue + chk_31_4.EditValue + chk_31_5.EditValue
            x += chk_36_1.EditValue + chk_36_2.EditValue + chk_36_3.EditValue + chk_36_4.EditValue + chk_36_5.EditValue

            Return x
        End Get
    End Property

    Public ReadOnly Property _n As Integer Implements Window_Forms_View.I_BigFive_Test._n
        Get
            Dim x As Integer = 0
            x = chk_4_1.EditValue + chk_4_2.EditValue + chk_4_3.EditValue + chk_4_4.EditValue + chk_4_5.EditValue
            x += chk_9_1.EditValue + chk_9_2.EditValue + chk_9_3.EditValue + chk_9_4.EditValue + chk_9_5.EditValue
            x += chk_14_1.EditValue + chk_14_2.EditValue + chk_14_3.EditValue + chk_14_4.EditValue + chk_14_5.EditValue
            x += chk_19_1.EditValue + chk_19_2.EditValue + chk_19_3.EditValue + chk_19_4.EditValue + chk_19_5.EditValue
            x += chk_24_1.EditValue + chk_24_2.EditValue + chk_24_3.EditValue + chk_24_4.EditValue + chk_24_5.EditValue
            x += chk_29_1.EditValue + chk_29_2.EditValue + chk_29_3.EditValue + chk_29_4.EditValue + chk_29_5.EditValue
            x += chk_34_1.EditValue + chk_34_2.EditValue + chk_34_3.EditValue + chk_34_4.EditValue + chk_34_5.EditValue
            x += chk_39_1.EditValue + chk_39_2.EditValue + chk_39_3.EditValue + chk_39_4.EditValue + chk_39_5.EditValue

            Return x
        End Get
    End Property

    Public ReadOnly Property _o As Integer Implements Window_Forms_View.I_BigFive_Test._o
        Get
            Dim x As Integer = 0
            x = chk_5_1.EditValue + chk_5_2.EditValue + chk_5_3.EditValue + chk_5_4.EditValue + chk_5_5.EditValue
            x += chk_10_1.EditValue + chk_10_2.EditValue + chk_10_3.EditValue + chk_10_4.EditValue + chk_10_5.EditValue
            x += chk_15_1.EditValue + chk_15_2.EditValue + chk_15_3.EditValue + chk_15_4.EditValue + chk_15_5.EditValue
            x += chk_19_1.EditValue + chk_19_2.EditValue + chk_19_3.EditValue + chk_19_4.EditValue + chk_19_5.EditValue
            x += chk_20_1.EditValue + chk_20_2.EditValue + chk_20_3.EditValue + chk_20_4.EditValue + chk_20_5.EditValue
            x += chk_25_1.EditValue + chk_25_2.EditValue + chk_25_3.EditValue + chk_25_4.EditValue + chk_25_5.EditValue
            x += chk_30_1.EditValue + chk_30_2.EditValue + chk_30_3.EditValue + chk_30_4.EditValue + chk_30_5.EditValue
            x += chk_35_1.EditValue + chk_35_2.EditValue + chk_35_3.EditValue + chk_35_4.EditValue + chk_35_5.EditValue
            x += chk_40_1.EditValue + chk_40_2.EditValue + chk_40_3.EditValue + chk_40_4.EditValue + chk_40_5.EditValue
            x += chk_41_1.EditValue + chk_41_2.EditValue + chk_41_3.EditValue + chk_41_4.EditValue + chk_41_5.EditValue
            x += chk_44_1.EditValue + chk_44_2.EditValue + chk_44_3.EditValue + chk_44_4.EditValue + chk_44_5.EditValue

            Return x
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim j(44) As Integer
        For Each x In TableLayoutPanel1.Controls
            If TypeOf (x) Is CheckEdit Then
                Dim y = CType(x, CheckEdit)
                j(y.Properties.RadioGroupIndex) += y.EditValue
            End If
        Next
        For Each x In TableLayoutPanel3.Controls
            If TypeOf (x) Is CheckEdit Then
                Dim y = CType(x, CheckEdit)
                j(y.Properties.RadioGroupIndex) += y.EditValue
            End If
        Next
        For i As Integer = 1 To 44
            If j(i) <= 0 Then
                errorMessage = "Nomor : " & i & "Tidak boleh kosong"
                Return
            End If
        Next
        If _Presenter.Save Then
            btnResult.Enabled = True
        End If
    End Sub
End Class