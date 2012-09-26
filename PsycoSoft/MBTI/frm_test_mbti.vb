Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Public Class frm_test_mbti : Implements I_test_mbti
    Private _Presenter As mbti_test_Presenter
    Dim _profil_id As Integer
    Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Inisialisasi()

        _profil_id = profil_id

        _Presenter = New mbti_test_Presenter(Me)
        _Presenter.DisplayNomorPeserta()


    End Sub

#Region "Init"
    Private Sub Inisialisasi()
        For Each Control In Me.TableLayoutPanel1.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel2.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel3.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel4.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel5.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel6.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel7.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next
        For Each Control In Me.TableLayoutPanel8.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                AddHandler CType(Control, DevExpress.XtraEditors.CheckEdit).GotFocus, AddressOf setSoal
            End If
        Next

        A1_CheckEdit.Properties.RadioGroupIndex = 1
        B1_CheckEdit.Properties.RadioGroupIndex = 1

        A2_CheckEdit.Properties.RadioGroupIndex = 2
        B2_CheckEdit.Properties.RadioGroupIndex = 2

        A3_CheckEdit.Properties.RadioGroupIndex = 3
        B3_CheckEdit.Properties.RadioGroupIndex = 3

        A4_CheckEdit.Properties.RadioGroupIndex = 4
        B4_CheckEdit.Properties.RadioGroupIndex = 4

        A5_CheckEdit.Properties.RadioGroupIndex = 5
        B5_CheckEdit.Properties.RadioGroupIndex = 5

        A6_CheckEdit.Properties.RadioGroupIndex = 6
        B6_CheckEdit.Properties.RadioGroupIndex = 6

        A7_CheckEdit.Properties.RadioGroupIndex = 7
        B7_CheckEdit.Properties.RadioGroupIndex = 7

        A8_CheckEdit.Properties.RadioGroupIndex = 8
        B8_CheckEdit.Properties.RadioGroupIndex = 8

        A9_CheckEdit.Properties.RadioGroupIndex = 9
        B9_CheckEdit.Properties.RadioGroupIndex = 9

        A10_CheckEdit.Properties.RadioGroupIndex = 10
        B10_CheckEdit.Properties.RadioGroupIndex = 10

        A10_CheckEdit.Properties.RadioGroupIndex = 10
        B10_CheckEdit.Properties.RadioGroupIndex = 10

        A11_CheckEdit.Properties.RadioGroupIndex = 11
        B11_CheckEdit.Properties.RadioGroupIndex = 11

        A12_CheckEdit.Properties.RadioGroupIndex = 12
        B12_CheckEdit.Properties.RadioGroupIndex = 12

        A13_CheckEdit.Properties.RadioGroupIndex = 13
        B13_CheckEdit.Properties.RadioGroupIndex = 13

        A14_CheckEdit.Properties.RadioGroupIndex = 14
        B14_CheckEdit.Properties.RadioGroupIndex = 14

        A15_CheckEdit.Properties.RadioGroupIndex = 15
        B15_CheckEdit.Properties.RadioGroupIndex = 15

        A16_CheckEdit.Properties.RadioGroupIndex = 16
        B16_CheckEdit.Properties.RadioGroupIndex = 16

        A17_CheckEdit.Properties.RadioGroupIndex = 17
        B17_CheckEdit.Properties.RadioGroupIndex = 17

        A18_CheckEdit.Properties.RadioGroupIndex = 18
        B18_CheckEdit.Properties.RadioGroupIndex = 18

        A19_CheckEdit.Properties.RadioGroupIndex = 19
        B19_CheckEdit.Properties.RadioGroupIndex = 19

        A20_CheckEdit.Properties.RadioGroupIndex = 20
        B20_CheckEdit.Properties.RadioGroupIndex = 20

        A21_CheckEdit.Properties.RadioGroupIndex = 21
        B21_CheckEdit.Properties.RadioGroupIndex = 21

        A22_CheckEdit.Properties.RadioGroupIndex = 22
        B22_CheckEdit.Properties.RadioGroupIndex = 22

        A23_CheckEdit.Properties.RadioGroupIndex = 23
        B23_CheckEdit.Properties.RadioGroupIndex = 23

        A24_CheckEdit.Properties.RadioGroupIndex = 24
        B24_CheckEdit.Properties.RadioGroupIndex = 24

        A25_CheckEdit.Properties.RadioGroupIndex = 25
        B25_CheckEdit.Properties.RadioGroupIndex = 25

        A26_CheckEdit.Properties.RadioGroupIndex = 26
        B26_CheckEdit.Properties.RadioGroupIndex = 26

        A27_CheckEdit.Properties.RadioGroupIndex = 27
        B27_CheckEdit.Properties.RadioGroupIndex = 27

        A28_CheckEdit.Properties.RadioGroupIndex = 28
        B28_CheckEdit.Properties.RadioGroupIndex = 28

        A29_CheckEdit.Properties.RadioGroupIndex = 29
        B29_CheckEdit.Properties.RadioGroupIndex = 29

        A30_CheckEdit.Properties.RadioGroupIndex = 30
        B30_CheckEdit.Properties.RadioGroupIndex = 30

        A31_CheckEdit.Properties.RadioGroupIndex = 31
        B31_CheckEdit.Properties.RadioGroupIndex = 31

        A32_CheckEdit.Properties.RadioGroupIndex = 32
        B32_CheckEdit.Properties.RadioGroupIndex = 32

        A33_CheckEdit.Properties.RadioGroupIndex = 33
        B33_CheckEdit.Properties.RadioGroupIndex = 33

        A34_CheckEdit.Properties.RadioGroupIndex = 34
        B34_CheckEdit.Properties.RadioGroupIndex = 34

        A35_CheckEdit.Properties.RadioGroupIndex = 35
        B35_CheckEdit.Properties.RadioGroupIndex = 35

        A36_CheckEdit.Properties.RadioGroupIndex = 36
        B36_CheckEdit.Properties.RadioGroupIndex = 36

        A37_CheckEdit.Properties.RadioGroupIndex = 37
        B37_CheckEdit.Properties.RadioGroupIndex = 37

        A38_CheckEdit.Properties.RadioGroupIndex = 38
        B38_CheckEdit.Properties.RadioGroupIndex = 38

        A39_CheckEdit.Properties.RadioGroupIndex = 39
        B39_CheckEdit.Properties.RadioGroupIndex = 39

        A40_CheckEdit.Properties.RadioGroupIndex = 40
        B40_CheckEdit.Properties.RadioGroupIndex = 40

        A41_CheckEdit.Properties.RadioGroupIndex = 41
        B41_CheckEdit.Properties.RadioGroupIndex = 41

        A42_CheckEdit.Properties.RadioGroupIndex = 42
        B42_CheckEdit.Properties.RadioGroupIndex = 42

        A43_CheckEdit.Properties.RadioGroupIndex = 43
        B43_CheckEdit.Properties.RadioGroupIndex = 43

        A44_CheckEdit.Properties.RadioGroupIndex = 44
        B44_CheckEdit.Properties.RadioGroupIndex = 44

        A45_CheckEdit.Properties.RadioGroupIndex = 45
        B45_CheckEdit.Properties.RadioGroupIndex = 45

        A46_CheckEdit.Properties.RadioGroupIndex = 46
        B46_CheckEdit.Properties.RadioGroupIndex = 46

        A47_CheckEdit.Properties.RadioGroupIndex = 47
        B47_CheckEdit.Properties.RadioGroupIndex = 47

        A48_CheckEdit.Properties.RadioGroupIndex = 48
        B48_CheckEdit.Properties.RadioGroupIndex = 48

        A49_CheckEdit.Properties.RadioGroupIndex = 49
        B49_CheckEdit.Properties.RadioGroupIndex = 49

        A50_CheckEdit.Properties.RadioGroupIndex = 50
        B50_CheckEdit.Properties.RadioGroupIndex = 50

        A51_CheckEdit.Properties.RadioGroupIndex = 51
        B51_CheckEdit.Properties.RadioGroupIndex = 51

        A52_CheckEdit.Properties.RadioGroupIndex = 52
        B52_CheckEdit.Properties.RadioGroupIndex = 52

        A53_CheckEdit.Properties.RadioGroupIndex = 53
        B53_CheckEdit.Properties.RadioGroupIndex = 53

        A54_CheckEdit.Properties.RadioGroupIndex = 54
        B54_CheckEdit.Properties.RadioGroupIndex = 54

        A55_CheckEdit.Properties.RadioGroupIndex = 55
        B55_CheckEdit.Properties.RadioGroupIndex = 55

        A56_CheckEdit.Properties.RadioGroupIndex = 56
        B56_CheckEdit.Properties.RadioGroupIndex = 56

        A57_CheckEdit.Properties.RadioGroupIndex = 57
        B57_CheckEdit.Properties.RadioGroupIndex = 57

        A58_CheckEdit.Properties.RadioGroupIndex = 58
        B58_CheckEdit.Properties.RadioGroupIndex = 58

        A59_CheckEdit.Properties.RadioGroupIndex = 59
        B59_CheckEdit.Properties.RadioGroupIndex = 59

        A60_CheckEdit.Properties.RadioGroupIndex = 60
        B60_CheckEdit.Properties.RadioGroupIndex = 60

        A61_CheckEdit.Properties.RadioGroupIndex = 61
        B61_CheckEdit.Properties.RadioGroupIndex = 61

        A62_CheckEdit.Properties.RadioGroupIndex = 62
        B62_CheckEdit.Properties.RadioGroupIndex = 62

        A63_CheckEdit.Properties.RadioGroupIndex = 63
        B63_CheckEdit.Properties.RadioGroupIndex = 63

        A64_CheckEdit.Properties.RadioGroupIndex = 64
        B64_CheckEdit.Properties.RadioGroupIndex = 64

        A65_CheckEdit.Properties.RadioGroupIndex = 65
        B65_CheckEdit.Properties.RadioGroupIndex = 65

        A66_CheckEdit.Properties.RadioGroupIndex = 66
        B66_CheckEdit.Properties.RadioGroupIndex = 66

        A67_CheckEdit.Properties.RadioGroupIndex = 67
        B67_CheckEdit.Properties.RadioGroupIndex = 67

        A68_CheckEdit.Properties.RadioGroupIndex = 68
        B68_CheckEdit.Properties.RadioGroupIndex = 68

        A69_CheckEdit.Properties.RadioGroupIndex = 69
        B69_CheckEdit.Properties.RadioGroupIndex = 69

        A70_CheckEdit.Properties.RadioGroupIndex = 70
        B70_CheckEdit.Properties.RadioGroupIndex = 70

        A71_CheckEdit.Properties.RadioGroupIndex = 71
        B71_CheckEdit.Properties.RadioGroupIndex = 71

        A72_CheckEdit.Properties.RadioGroupIndex = 72
        B72_CheckEdit.Properties.RadioGroupIndex = 72

        A73_CheckEdit.Properties.RadioGroupIndex = 73
        B73_CheckEdit.Properties.RadioGroupIndex = 73

        A74_CheckEdit.Properties.RadioGroupIndex = 74
        B74_CheckEdit.Properties.RadioGroupIndex = 74

        A75_CheckEdit.Properties.RadioGroupIndex = 75
        B75_CheckEdit.Properties.RadioGroupIndex = 75

        A76_CheckEdit.Properties.RadioGroupIndex = 76
        B76_CheckEdit.Properties.RadioGroupIndex = 76

        A77_CheckEdit.Properties.RadioGroupIndex = 77
        B77_CheckEdit.Properties.RadioGroupIndex = 77

        A78_CheckEdit.Properties.RadioGroupIndex = 78
        B78_CheckEdit.Properties.RadioGroupIndex = 78

        A79_CheckEdit.Properties.RadioGroupIndex = 79
        B79_CheckEdit.Properties.RadioGroupIndex = 79

        A80_CheckEdit.Properties.RadioGroupIndex = 80
        B80_CheckEdit.Properties.RadioGroupIndex = 80

        A81_CheckEdit.Properties.RadioGroupIndex = 81
        B81_CheckEdit.Properties.RadioGroupIndex = 81

        A82_CheckEdit.Properties.RadioGroupIndex = 82
        B82_CheckEdit.Properties.RadioGroupIndex = 82

        A83_CheckEdit.Properties.RadioGroupIndex = 83
        B83_CheckEdit.Properties.RadioGroupIndex = 83

        A84_CheckEdit.Properties.RadioGroupIndex = 84
        B84_CheckEdit.Properties.RadioGroupIndex = 84

        A85_CheckEdit.Properties.RadioGroupIndex = 85
        B85_CheckEdit.Properties.RadioGroupIndex = 85

        A86_CheckEdit.Properties.RadioGroupIndex = 86
        B86_CheckEdit.Properties.RadioGroupIndex = 86

        A87_CheckEdit.Properties.RadioGroupIndex = 87
        B87_CheckEdit.Properties.RadioGroupIndex = 87

        A88_CheckEdit.Properties.RadioGroupIndex = 88
        B88_CheckEdit.Properties.RadioGroupIndex = 88

        A89_CheckEdit.Properties.RadioGroupIndex = 89
        B89_CheckEdit.Properties.RadioGroupIndex = 89

        A90_CheckEdit.Properties.RadioGroupIndex = 90
        B90_CheckEdit.Properties.RadioGroupIndex = 90

        A91_CheckEdit.Properties.RadioGroupIndex = 91
        B91_CheckEdit.Properties.RadioGroupIndex = 91

        A92_CheckEdit.Properties.RadioGroupIndex = 92
        B92_CheckEdit.Properties.RadioGroupIndex = 92

        A93_CheckEdit.Properties.RadioGroupIndex = 93
        B93_CheckEdit.Properties.RadioGroupIndex = 93

        A94_CheckEdit.Properties.RadioGroupIndex = 94
        B94_CheckEdit.Properties.RadioGroupIndex = 94

        A95_CheckEdit.Properties.RadioGroupIndex = 95
        B95_CheckEdit.Properties.RadioGroupIndex = 95

        A96_CheckEdit.Properties.RadioGroupIndex = 96
        B96_CheckEdit.Properties.RadioGroupIndex = 96

        A97_CheckEdit.Properties.RadioGroupIndex = 97
        B97_CheckEdit.Properties.RadioGroupIndex = 97

        A98_CheckEdit.Properties.RadioGroupIndex = 98
        B98_CheckEdit.Properties.RadioGroupIndex = 98

        A99_CheckEdit.Properties.RadioGroupIndex = 99
        B99_CheckEdit.Properties.RadioGroupIndex = 99

        A100_CheckEdit.Properties.RadioGroupIndex = 100
        B100_CheckEdit.Properties.RadioGroupIndex = 100

        E101_CheckEdit.Properties.RadioGroupIndex = 101
        I101_CheckEdit.Properties.RadioGroupIndex = 101

        S102_CheckEdit.Properties.RadioGroupIndex = 102
        N102_CheckEdit.Properties.RadioGroupIndex = 102

        T103_CheckEdit.Properties.RadioGroupIndex = 103
        F103_CheckEdit.Properties.RadioGroupIndex = 103

        J104_CheckEdit.Properties.RadioGroupIndex = 104
        P104_CheckEdit.Properties.RadioGroupIndex = 104
    End Sub
    Private Sub setSoal(s As Object, e As EventArgs)
        Dim nomor As Integer = CType(s, DevExpress.XtraEditors.CheckEdit).Properties.RadioGroupIndex
        _Presenter.setPertanyaan(nomor)
    End Sub
#End Region

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_test_mbti.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public WriteOnly Property NomorPeserta As String Implements Window_Forms_View.I_test_mbti.NomorPeserta
        Set(value As String)
            lblNomor.Text = "Nomor : " & value
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_test_mbti.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property Soal As String Implements Window_Forms_View.I_test_mbti.Soal
        Set(value As String)
            SoalMemoEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_test_mbti.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public ReadOnly Property module_id As Integer Implements Window_Forms_View.I_test_mbti.module_id
        Get
            Return 1
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim arrNomor(104) As Integer
        For Each Control In Me.TableLayoutPanel1.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel2.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel3.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel4.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel5.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel6.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel7.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For Each Control In Me.TableLayoutPanel8.Controls
            If TypeOf (Control) Is DevExpress.XtraEditors.CheckEdit Then
                Dim x = CType(Control, DevExpress.XtraEditors.CheckEdit)
                arrNomor(x.Properties.RadioGroupIndex) += If(x.Checked, 1, 0)
            End If

        Next
        For i As Integer = 1 To 104
            If arrNomor(i) = 0 Then
                errMessage = "No " & i & " harus diisi!"
                Return
            End If
        Next
        If _Presenter.save Then
            
        End If
    End Sub

    Public ReadOnly Property e1 As Integer Implements Window_Forms_View.I_test_mbti.e1
        Get
            Dim x As Integer = 0
            x = If(A1_CheckEdit.Checked, 1, 0) + If(A5_CheckEdit.Checked, 1, 0) + If(A9_CheckEdit.Checked, 1, 0) + If(B13_CheckEdit.Checked, 1, 0) + If(B17_CheckEdit.Checked, 1, 0) + If(A21_CheckEdit.Checked, 1, 0) + If(A25_CheckEdit.Checked, 1, 0) + If(A29_CheckEdit.Checked, 1, 0) + If(A33_CheckEdit.Checked, 1, 0) + If(B37_CheckEdit.Checked, 1, 0) + If(A41_CheckEdit.Checked, 1, 0) + If(A45_CheckEdit.Checked, 1, 0) + If(B49_CheckEdit.Checked, 1, 0) + If(A53_CheckEdit.Checked, 1, 0) + If(A57_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property e2 As Integer Implements Window_Forms_View.I_test_mbti.e2
        Get
            Dim x As Integer = 0
            x = If(A61_CheckEdit.Checked, 1, 0) + If(B65_CheckEdit.Checked, 1, 0) + If(B69_CheckEdit.Checked, 1, 0) + If(A73_CheckEdit.Checked, 1, 0) + If(A77_CheckEdit.Checked, 1, 0) + If(A81_CheckEdit.Checked, 1, 0) + If(A85_CheckEdit.Checked, 1, 0) + If(B89_CheckEdit.Checked, 1, 0) + If(A93_CheckEdit.Checked, 1, 0) + If(A97_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property e3 As Integer Implements Window_Forms_View.I_test_mbti.e3
        Get
            Return If(E101_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property f1 As Integer Implements Window_Forms_View.I_test_mbti.f1
        Get
            Dim x As Integer = 0
            x = If(A3_CheckEdit.Checked, 1, 0) + If(A7_CheckEdit.Checked, 1, 0) + If(A11_CheckEdit.Checked, 1, 0) + If(A15_CheckEdit.Checked, 1, 0) + If(A19_CheckEdit.Checked, 1, 0) + If(B23_CheckEdit.Checked, 1, 0) + If(A27_CheckEdit.Checked, 1, 0) + If(A31_CheckEdit.Checked, 1, 0) + If(B35_CheckEdit.Checked, 1, 0) + If(B39_CheckEdit.Checked, 1, 0) + If(B43_CheckEdit.Checked, 1, 0) + If(B47_CheckEdit.Checked, 1, 0) + If(A51_CheckEdit.Checked, 1, 0) + If(B55_CheckEdit.Checked, 1, 0) + If(B59_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property f2 As Integer Implements Window_Forms_View.I_test_mbti.f2
        Get
            Dim x As Integer = 0
            x = If(B63_CheckEdit.Checked, 1, 0) + If(A67_CheckEdit.Checked, 1, 0) + If(A71_CheckEdit.Checked, 1, 0) + If(A75_CheckEdit.Checked, 1, 0) + If(A79_CheckEdit.Checked, 1, 0) + If(A83_CheckEdit.Checked, 1, 0) + If(A87_CheckEdit.Checked, 1, 0) + If(B91_CheckEdit.Checked, 1, 0) + If(B95_CheckEdit.Checked, 1, 0) + If(B99_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property f3 As Integer Implements Window_Forms_View.I_test_mbti.f3
        Get
            Return If(F103_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property i1 As Integer Implements Window_Forms_View.I_test_mbti.i1
        Get
            Dim x As Integer = 0
            x = If(B1_CheckEdit.Checked, 1, 0) + If(B5_CheckEdit.Checked, 1, 0) + If(B9_CheckEdit.Checked, 1, 0) + If(A13_CheckEdit.Checked, 1, 0) + If(A17_CheckEdit.Checked, 1, 0) + If(B21_CheckEdit.Checked, 1, 0) + If(B25_CheckEdit.Checked, 1, 0) + If(B29_CheckEdit.Checked, 1, 0) + If(B33_CheckEdit.Checked, 1, 0) + If(A37_CheckEdit.Checked, 1, 0) + If(B41_CheckEdit.Checked, 1, 0) + If(B45_CheckEdit.Checked, 1, 0) + If(A49_CheckEdit.Checked, 1, 0) + If(B53_CheckEdit.Checked, 1, 0) + If(B57_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property i2 As Integer Implements Window_Forms_View.I_test_mbti.i2
        Get
            Dim x As Integer = 0
            x = If(B61_CheckEdit.Checked, 1, 0) + If(A65_CheckEdit.Checked, 1, 0) + If(A69_CheckEdit.Checked, 1, 0) + If(B73_CheckEdit.Checked, 1, 0) + If(B77_CheckEdit.Checked, 1, 0) + If(B81_CheckEdit.Checked, 1, 0) + If(B85_CheckEdit.Checked, 1, 0) + If(A89_CheckEdit.Checked, 1, 0) + If(B93_CheckEdit.Checked, 1, 0) + If(B97_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property i3 As Integer Implements Window_Forms_View.I_test_mbti.i3
        Get
            Return If(I101_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property j1 As Integer Implements Window_Forms_View.I_test_mbti.j1
        Get
            Dim x As Integer = 0
            x = If(A4_CheckEdit.Checked, 1, 0) + If(A8_CheckEdit.Checked, 1, 0) + If(B12_CheckEdit.Checked, 1, 0) + If(A16_CheckEdit.Checked, 1, 0) + If(A20_CheckEdit.Checked, 1, 0) + If(B24_CheckEdit.Checked, 1, 0) + If(A28_CheckEdit.Checked, 1, 0) + If(A32_CheckEdit.Checked, 1, 0) + If(A36_CheckEdit.Checked, 1, 0) + If(A40_CheckEdit.Checked, 1, 0) + If(B44_CheckEdit.Checked, 1, 0) + If(B48_CheckEdit.Checked, 1, 0) + If(A52_CheckEdit.Checked, 1, 0) + If(A56_CheckEdit.Checked, 1, 0) + If(A60_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property j2 As Integer Implements Window_Forms_View.I_test_mbti.j2
        Get
            Dim x As Integer = 0
            x = If(A64_CheckEdit.Checked, 1, 0) + If(A68_CheckEdit.Checked, 1, 0) + If(A72_CheckEdit.Checked, 1, 0) + If(A76_CheckEdit.Checked, 1, 0) + If(B80_CheckEdit.Checked, 1, 0) + If(A84_CheckEdit.Checked, 1, 0) + If(B88_CheckEdit.Checked, 1, 0) + If(B92_CheckEdit.Checked, 1, 0) + If(A96_CheckEdit.Checked, 1, 0) + If(B100_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property j3 As Integer Implements Window_Forms_View.I_test_mbti.j3
        Get
            Return If(J104_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property n1 As Integer Implements Window_Forms_View.I_test_mbti.n1
        Get
            Dim x As Integer = 0
            x = If(B2_CheckEdit.Checked, 1, 0) + If(A6_CheckEdit.Checked, 1, 0) + If(B10_CheckEdit.Checked, 1, 0) + If(A14_CheckEdit.Checked, 1, 0) + If(A18_CheckEdit.Checked, 1, 0) + If(A22_CheckEdit.Checked, 1, 0) + If(A26_CheckEdit.Checked, 1, 0) + If(A30_CheckEdit.Checked, 1, 0) + If(A34_CheckEdit.Checked, 1, 0) + If(B38_CheckEdit.Checked, 1, 0) + If(B42_CheckEdit.Checked, 1, 0) + If(B46_CheckEdit.Checked, 1, 0) + If(B50_CheckEdit.Checked, 1, 0) + If(A54_CheckEdit.Checked, 1, 0) + If(B58_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property n2 As Integer Implements Window_Forms_View.I_test_mbti.n2
        Get
            Dim x As Integer = 0
            x = If(A62_CheckEdit.Checked, 1, 0) + If(B66_CheckEdit.Checked, 1, 0) + If(B70_CheckEdit.Checked, 1, 0) + If(B74_CheckEdit.Checked, 1, 0) + If(B78_CheckEdit.Checked, 1, 0) + If(B82_CheckEdit.Checked, 1, 0) + If(B86_CheckEdit.Checked, 1, 0) + If(B90_CheckEdit.Checked, 1, 0) + If(B94_CheckEdit.Checked, 1, 0) + If(A98_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property n3 As Integer Implements Window_Forms_View.I_test_mbti.n3
        Get
            Return If(N102_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property p1 As Integer Implements Window_Forms_View.I_test_mbti.p1
        Get
            Dim x As Integer = 0
            x = If(B4_CheckEdit.Checked, 1, 0) + If(B8_CheckEdit.Checked, 1, 0) + If(A12_CheckEdit.Checked, 1, 0) + If(B16_CheckEdit.Checked, 1, 0) + If(B20_CheckEdit.Checked, 1, 0) + If(A24_CheckEdit.Checked, 1, 0) + If(B28_CheckEdit.Checked, 1, 0) + If(B32_CheckEdit.Checked, 1, 0) + If(B36_CheckEdit.Checked, 1, 0) + If(B40_CheckEdit.Checked, 1, 0) + If(A44_CheckEdit.Checked, 1, 0) + If(A48_CheckEdit.Checked, 1, 0) + If(B52_CheckEdit.Checked, 1, 0) + If(B56_CheckEdit.Checked, 1, 0) + If(B60_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property p2 As Integer Implements Window_Forms_View.I_test_mbti.p2
        Get
            Dim x As Integer = 0
            x = If(B64_CheckEdit.Checked, 1, 0) + If(B68_CheckEdit.Checked, 1, 0) + If(B72_CheckEdit.Checked, 1, 0) + If(B76_CheckEdit.Checked, 1, 0) + If(A80_CheckEdit.Checked, 1, 0) + If(B84_CheckEdit.Checked, 1, 0) + If(A88_CheckEdit.Checked, 1, 0) + If(A92_CheckEdit.Checked, 1, 0) + If(B96_CheckEdit.Checked, 1, 0) + If(A100_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property p3 As Integer Implements Window_Forms_View.I_test_mbti.p3
        Get
            Return If(P104_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property s1 As Integer Implements Window_Forms_View.I_test_mbti.s1
        Get
            Dim x As Integer = 0
            x = If(A2_CheckEdit.Checked, 1, 0) + If(A6_CheckEdit.Checked, 1, 0) + If(A10_CheckEdit.Checked, 1, 0) + If(B14_CheckEdit.Checked, 1, 0) + If(B18_CheckEdit.Checked, 1, 0) + If(B22_CheckEdit.Checked, 1, 0) + If(B26_CheckEdit.Checked, 1, 0) + If(B30_CheckEdit.Checked, 1, 0) + If(B34_CheckEdit.Checked, 1, 0) + If(A38_CheckEdit.Checked, 1, 0) + If(A42_CheckEdit.Checked, 1, 0) + If(A46_CheckEdit.Checked, 1, 0) + If(A50_CheckEdit.Checked, 1, 0) + If(B54_CheckEdit.Checked, 1, 0) + If(A58_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property s2 As Integer Implements Window_Forms_View.I_test_mbti.s2
        Get
            Dim x As Integer = 0
            x = If(B62_CheckEdit.Checked, 1, 0) + If(A66_CheckEdit.Checked, 1, 0) + If(A70_CheckEdit.Checked, 1, 0) + If(A74_CheckEdit.Checked, 1, 0) + If(A78_CheckEdit.Checked, 1, 0) + If(A82_CheckEdit.Checked, 1, 0) + If(A86_CheckEdit.Checked, 1, 0) + If(A90_CheckEdit.Checked, 1, 0) + If(A94_CheckEdit.Checked, 1, 0) + If(B98_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property s3 As Integer Implements Window_Forms_View.I_test_mbti.s3
        Get
            Return If(S102_CheckEdit.Checked, 1, 0)
        End Get
    End Property

    Public ReadOnly Property t1 As Integer Implements Window_Forms_View.I_test_mbti.t1
        Get
            Dim x As Integer = 0
            x = If(B3_CheckEdit.Checked, 1, 0) + If(B7_CheckEdit.Checked, 1, 0) + If(B11_CheckEdit.Checked, 1, 0) + If(B15_CheckEdit.Checked, 1, 0) + If(B19_CheckEdit.Checked, 1, 0) + If(A23_CheckEdit.Checked, 1, 0) + If(B27_CheckEdit.Checked, 1, 0) + If(B31_CheckEdit.Checked, 1, 0) + If(A35_CheckEdit.Checked, 1, 0) + If(A39_CheckEdit.Checked, 1, 0) + If(A43_CheckEdit.Checked, 1, 0) + If(A47_CheckEdit.Checked, 1, 0) + If(B51_CheckEdit.Checked, 1, 0) + If(A55_CheckEdit.Checked, 1, 0) + If(A59_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property t2 As Integer Implements Window_Forms_View.I_test_mbti.t2
        Get
            Dim x As Integer = 0
            x = If(A63_CheckEdit.Checked, 1, 0) + If(B67_CheckEdit.Checked, 1, 0) + If(B71_CheckEdit.Checked, 1, 0) + If(B75_CheckEdit.Checked, 1, 0) + If(B79_CheckEdit.Checked, 1, 0) + If(B83_CheckEdit.Checked, 1, 0) + If(B87_CheckEdit.Checked, 1, 0) + If(A91_CheckEdit.Checked, 1, 0) + If(A95_CheckEdit.Checked, 1, 0) + If(A99_CheckEdit.Checked, 1, 0)
            Return x
        End Get
    End Property

    Public ReadOnly Property t3 As Integer Implements Window_Forms_View.I_test_mbti.t3
        Get
            Return If(T103_CheckEdit.Checked, 1, 0)
        End Get
    End Property

  
    
    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click
        Dim f As New frm_mbti_result(profil_id)
        f.ShowDialog()
    End Sub

    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub
End Class