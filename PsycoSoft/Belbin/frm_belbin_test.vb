Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports Window_Forms_Report
Public Class frm_belbin_test : Implements I_Belbin_Test

    Private _Presenter As belbin_tes_Presenter
    Private _profil_id As Integer
    Public Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New belbin_tes_Presenter(Me)
        _Presenter.DisplayNomor()
    End Sub

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_Belbin_Test.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_Belbin_Test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property SetNomor As String Implements Window_Forms_View.I_Belbin_Test.SetNomor
        Set(value As String)
            lblnomor.Text = "Nomor : " & value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_Belbin_Test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Private Sub A1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A1_CheckBox.CheckedChanged
        A_1_TextEdit.Text = ""
        A_1_TextEdit.Enabled = A1_CheckBox.Checked
        A_1_TextEdit.Focus()
    End Sub

    Private Sub A2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A2_CheckBox.CheckedChanged
        A_2_TextEdit.Text = ""
        A_2_TextEdit.Enabled = A2_CheckBox.Checked
        A_2_TextEdit.Focus()
    End Sub

    Private Sub A3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A3_CheckBox.CheckedChanged
        A_3_TextEdit.Text = ""
        A_3_TextEdit.Enabled = A3_CheckBox.Checked
        A_3_TextEdit.Focus()
    End Sub

    Private Sub A4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A4_CheckBox.CheckedChanged
        A_4_TextEdit.Text = ""
        A_4_TextEdit.Enabled = A4_CheckBox.Checked
        A_4_TextEdit.Focus()
    End Sub

    Private Sub A5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A5_CheckBox.CheckedChanged
        A_5_TextEdit.Text = ""
        A_5_TextEdit.Enabled = A5_CheckBox.Checked
        A_5_TextEdit.Focus()
    End Sub

    Private Sub A6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A6_CheckBox.CheckedChanged
        A_6_TextEdit.Text = ""
        A_6_TextEdit.Enabled = A6_CheckBox.Checked
        A_6_TextEdit.Focus()
    End Sub

    Private Sub A7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A7_CheckBox.CheckedChanged
        A_7_TextEdit.Text = ""
        A_7_TextEdit.Enabled = A7_CheckBox.Checked
        A_7_TextEdit.Focus()
    End Sub

    Private Sub A8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles A8_CheckBox.CheckedChanged
        A_8_TextEdit.Text = ""
        A_8_TextEdit.Enabled = A8_CheckBox.Checked
        A_8_TextEdit.Focus()
    End Sub

    Private Sub B1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B1_CheckBox.CheckedChanged
        B_1_TextEdit.Text = ""
        B_1_TextEdit.Enabled = B1_CheckBox.Checked
        B_1_TextEdit.Focus()
    End Sub

    Private Sub B2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B2_CheckBox.CheckedChanged
        B_2_TextEdit.Text = ""
        B_2_TextEdit.Enabled = B2_CheckBox.Checked
        B_2_TextEdit.Focus()
    End Sub

    Private Sub B3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B3_CheckBox.CheckedChanged
        B_3_TextEdit.Text = ""
        B_3_TextEdit.Enabled = B3_CheckBox.Checked
        B_3_TextEdit.Focus()
    End Sub

    Private Sub B4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B4_CheckBox.CheckedChanged
        B_4_TextEdit.Text = ""
        B_4_TextEdit.Enabled = B4_CheckBox.Checked
        B_4_TextEdit.Focus()
    End Sub

    Private Sub B5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B5_CheckBox.CheckedChanged
        B_5_TextEdit.Text = ""
        B_5_TextEdit.Enabled = B5_CheckBox.Checked
        B_5_TextEdit.Focus()
    End Sub

    Private Sub B6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B6_CheckBox.CheckedChanged
        B_6_TextEdit.Text = ""
        B_6_TextEdit.Enabled = B6_CheckBox.Checked
        B_6_TextEdit.Focus()
    End Sub

    Private Sub B7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B7_CheckBox.CheckedChanged
        B_7_TextEdit.Text = ""
        B_7_TextEdit.Enabled = B7_CheckBox.Checked
        B_7_TextEdit.Focus()
    End Sub

    Private Sub B8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles B8_CheckBox.CheckedChanged
        B_8_TextEdit.Text = ""
        B_8_TextEdit.Enabled = B8_CheckBox.Checked
        B_8_TextEdit.Focus()
    End Sub

    Private Sub C1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C1_CheckBox.CheckedChanged
        C_1_TextEdit.Text = ""
        C_1_TextEdit.Enabled = C1_CheckBox.Checked
        C_1_TextEdit.Focus()
    End Sub

    Private Sub C2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C2_CheckBox.CheckedChanged
        C_2_TextEdit.Text = ""
        C_2_TextEdit.Enabled = C2_CheckBox.Checked
        C_2_TextEdit.Focus()
    End Sub

    Private Sub C3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C3_CheckBox.CheckedChanged
        C_3_TextEdit.Text = ""
        C_3_TextEdit.Enabled = C3_CheckBox.Checked
        C_3_TextEdit.Focus()
    End Sub

    Private Sub C4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C4_CheckBox.CheckedChanged
        C_4_TextEdit.Text = ""
        C_4_TextEdit.Enabled = C4_CheckBox.Checked
        C_4_TextEdit.Focus()
    End Sub

    Private Sub C5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C5_CheckBox.CheckedChanged
        C_5_TextEdit.Text = ""
        C_5_TextEdit.Enabled = C5_CheckBox.Checked
        C_5_TextEdit.Focus()
    End Sub

    Private Sub C6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C6_CheckBox.CheckedChanged
        C_6_TextEdit.Text = ""
        C_6_TextEdit.Enabled = C6_CheckBox.Checked
        C_6_TextEdit.Focus()
    End Sub

    Private Sub C7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C7_CheckBox.CheckedChanged
        C_7_TextEdit.Text = ""
        C_7_TextEdit.Enabled = C7_CheckBox.Checked
        C_7_TextEdit.Focus()
    End Sub

    Private Sub C8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C8_CheckBox.CheckedChanged
        C_8_TextEdit.Text = ""
        C_8_TextEdit.Enabled = C8_CheckBox.Checked
        C_8_TextEdit.Focus()
    End Sub

    Private Sub D1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D1_CheckBox.CheckedChanged
        D_1_TextEdit.Text = ""
        D_1_TextEdit.Enabled = D1_CheckBox.Checked
        D_1_TextEdit.Focus()
    End Sub

    Private Sub D2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D2_CheckBox.CheckedChanged
        D_2_TextEdit.Text = ""
        D_2_TextEdit.Enabled = D2_CheckBox.Checked
        D_2_TextEdit.Focus()
    End Sub

    Private Sub D3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D3_CheckBox.CheckedChanged
        D_3_TextEdit.Text = ""
        D_3_TextEdit.Enabled = D3_CheckBox.Checked
        D_3_TextEdit.Focus()
    End Sub

    Private Sub D4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D4_CheckBox.CheckedChanged
        D_4_TextEdit.Text = ""
        D_4_TextEdit.Enabled = D4_CheckBox.Checked
        D_4_TextEdit.Focus()
    End Sub

    Private Sub D5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D5_CheckBox.CheckedChanged
        D_5_TextEdit.Text = ""
        D_5_TextEdit.Enabled = D5_CheckBox.Checked
        D_5_TextEdit.Focus()
    End Sub

    Private Sub D6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D6_CheckBox.CheckedChanged
        D_6_TextEdit.Text = ""
        D_6_TextEdit.Enabled = D6_CheckBox.Checked
        D_6_TextEdit.Focus()
    End Sub

    Private Sub D7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D7_CheckBox.CheckedChanged
        D_7_TextEdit.Text = ""
        D_7_TextEdit.Enabled = D7_CheckBox.Checked
        D_7_TextEdit.Focus()
    End Sub

    Private Sub D8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles D8_CheckBox.CheckedChanged
        D_8_TextEdit.Text = ""
        D_8_TextEdit.Enabled = D8_CheckBox.Checked
        D_8_TextEdit.Focus()
    End Sub

    Private Sub E1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E1_CheckBox.CheckedChanged
        E_1_TextEdit.Text = ""
        E_1_TextEdit.Enabled = E1_CheckBox.Checked
        E_1_TextEdit.Focus()
    End Sub

    Private Sub E2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E2_CheckBox.CheckedChanged
        E_2_TextEdit.Text = ""
        E_2_TextEdit.Enabled = E2_CheckBox.Checked
        E_2_TextEdit.Focus()
    End Sub

    Private Sub E3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E3_CheckBox.CheckedChanged
        E_3_TextEdit.Text = ""
        E_3_TextEdit.Enabled = E3_CheckBox.Checked
        E_3_TextEdit.Focus()
    End Sub

    Private Sub E4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E4_CheckBox.CheckedChanged
        E_4_TextEdit.Text = ""
        E_4_TextEdit.Enabled = E4_CheckBox.Checked
        E_4_TextEdit.Focus()
    End Sub

    Private Sub E5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E5_CheckBox.CheckedChanged
        E_5_TextEdit.Text = ""
        E_5_TextEdit.Enabled = E5_CheckBox.Checked
        E_5_TextEdit.Focus()
    End Sub

    Private Sub E6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E6_CheckBox.CheckedChanged
        E_6_TextEdit.Text = ""
        E_6_TextEdit.Enabled = E6_CheckBox.Checked
        E_6_TextEdit.Focus()
    End Sub

    Private Sub E7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E7_CheckBox.CheckedChanged
        E_7_TextEdit.Text = ""
        E_7_TextEdit.Enabled = E7_CheckBox.Checked
        E_7_TextEdit.Focus()
    End Sub

    Private Sub E8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles E8_CheckBox.CheckedChanged
        E_8_TextEdit.Text = ""
        E_8_TextEdit.Enabled = E8_CheckBox.Checked
        E_8_TextEdit.Focus()
    End Sub

    Private Sub F1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F1_CheckBox.CheckedChanged
        F_1_TextEdit.Text = ""
        F_1_TextEdit.Enabled = F1_CheckBox.Checked
        F_1_TextEdit.Focus()
    End Sub

    Private Sub F2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F2_CheckBox.CheckedChanged
        F_2_TextEdit.Text = ""
        F_2_TextEdit.Enabled = F2_CheckBox.Checked
        F_2_TextEdit.Focus()
    End Sub

    Private Sub F3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F3_CheckBox.CheckedChanged
        F_3_TextEdit.Text = ""
        F_3_TextEdit.Enabled = F3_CheckBox.Checked
        F_3_TextEdit.Focus()
    End Sub

    Private Sub F4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F4_CheckBox.CheckedChanged
        F_4_TextEdit.Text = ""
        F_4_TextEdit.Enabled = F4_CheckBox.Checked
        F_4_TextEdit.Focus()
    End Sub

    Private Sub F5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F5_CheckBox.CheckedChanged
        F_5_TextEdit.Text = ""
        F_5_TextEdit.Enabled = F5_CheckBox.Checked
        F_5_TextEdit.Focus()
    End Sub

    Private Sub F6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F6_CheckBox.CheckedChanged
        F_6_TextEdit.Text = ""
        F_6_TextEdit.Enabled = F6_CheckBox.Checked
        F_6_TextEdit.Focus()
    End Sub

    Private Sub F7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F7_CheckBox.CheckedChanged
        F_7_TextEdit.Text = ""
        F_7_TextEdit.Enabled = F7_CheckBox.Checked
        F_7_TextEdit.Focus()
    End Sub

    Private Sub F8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles F8_CheckBox.CheckedChanged
        F_8_TextEdit.Text = ""
        F_8_TextEdit.Enabled = F8_CheckBox.Checked
        F_8_TextEdit.Focus()
    End Sub

    Private Sub G1_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G1_CheckBox.CheckedChanged
        G_1_TextEdit.Text = ""
        G_1_TextEdit.Enabled = G1_CheckBox.Checked
        G_1_TextEdit.Focus()
    End Sub

    Private Sub G2_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G2_CheckBox.CheckedChanged
        G_2_TextEdit.Text = ""
        G_2_TextEdit.Enabled = G2_CheckBox.Checked
        G_2_TextEdit.Focus()
    End Sub

    Private Sub G3_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G3_CheckBox.CheckedChanged
        G_3_TextEdit.Text = ""
        G_3_TextEdit.Enabled = G3_CheckBox.Checked
        G_3_TextEdit.Focus()
    End Sub

    Private Sub G4_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G4_CheckBox.CheckedChanged
        G_4_TextEdit.Text = ""
        G_4_TextEdit.Enabled = G4_CheckBox.Checked
        G_4_TextEdit.Focus()
    End Sub

    Private Sub G5_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G5_CheckBox.CheckedChanged
        G_5_TextEdit.Text = ""
        G_5_TextEdit.Enabled = G5_CheckBox.Checked
        G_5_TextEdit.Focus()
    End Sub

    Private Sub G6_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G6_CheckBox.CheckedChanged
        G_6_TextEdit.Text = ""
        G_6_TextEdit.Enabled = G6_CheckBox.Checked
        G_6_TextEdit.Focus()
    End Sub

    Private Sub G7_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G7_CheckBox.CheckedChanged
        G_7_TextEdit.Text = ""
        G_7_TextEdit.Enabled = G7_CheckBox.Checked
        G_7_TextEdit.Focus()
    End Sub

    Private Sub G8_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles G8_CheckBox.CheckedChanged
        G_8_TextEdit.Text = ""
        G_8_TextEdit.Enabled = G8_CheckBox.Checked
        G_8_TextEdit.Focus()
    End Sub

    Public ReadOnly Property _CF As Integer Implements Window_Forms_View.I_Belbin_Test._CF
        Get
            Return If(String.IsNullOrEmpty(A_2_TextEdit.Text), 0, A_2_TextEdit.Text) + If(String.IsNullOrEmpty(B_2_TextEdit.Text), 0, B_2_TextEdit.Text) + If(String.IsNullOrEmpty(C_1_TextEdit.Text), 0, C_1_TextEdit.Text) + If(String.IsNullOrEmpty(D_7_TextEdit.Text), 0, D_7_TextEdit.Text) + If(String.IsNullOrEmpty(E_8_TextEdit.Text), 0, E_8_TextEdit.Text) + If(String.IsNullOrEmpty(F_2_TextEdit.Text), 0, F_2_TextEdit.Text) + If(String.IsNullOrEmpty(G_4_TextEdit.Text), 0, G_4_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _CO As Integer Implements Window_Forms_View.I_Belbin_Test._CO
        Get
            Return If(String.IsNullOrEmpty(A_7_TextEdit.Text), 0, A_7_TextEdit.Text) + If(String.IsNullOrEmpty(B_6_TextEdit.Text), 0, B_6_TextEdit.Text) + If(String.IsNullOrEmpty(C_4_TextEdit.Text), 0, C_4_TextEdit.Text) + If(String.IsNullOrEmpty(D_3_TextEdit.Text), 0, D_3_TextEdit.Text) + If(String.IsNullOrEmpty(E_5_TextEdit.Text), 0, E_5_TextEdit.Text) + If(String.IsNullOrEmpty(F_4_TextEdit.Text), 0, F_4_TextEdit.Text) + If(String.IsNullOrEmpty(G_7_TextEdit.Text), 0, G_7_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _IMP As Integer Implements Window_Forms_View.I_Belbin_Test._IMP
        Get
            Return If(String.IsNullOrEmpty(A_4_TextEdit.Text), 0, A_4_TextEdit.Text) + If(String.IsNullOrEmpty(B_7_TextEdit.Text), 0, B_7_TextEdit.Text) + If(String.IsNullOrEmpty(C_5_TextEdit.Text), 0, C_5_TextEdit.Text) + If(String.IsNullOrEmpty(D_1_TextEdit.Text), 0, D_1_TextEdit.Text) + If(String.IsNullOrEmpty(E_4_TextEdit.Text), 0, E_4_TextEdit.Text) + If(String.IsNullOrEmpty(F_8_TextEdit.Text), 0, F_8_TextEdit.Text) + If(String.IsNullOrEmpty(G_1_TextEdit.Text), 0, G_1_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _ME As Integer Implements Window_Forms_View.I_Belbin_Test._ME
        Get
            Return If(String.IsNullOrEmpty(A_5_TextEdit.Text), 0, A_5_TextEdit.Text) + If(String.IsNullOrEmpty(B_4_TextEdit.Text), 0, B_4_TextEdit.Text) + If(String.IsNullOrEmpty(C_3_TextEdit.Text), 0, C_3_TextEdit.Text) + If(String.IsNullOrEmpty(D_5_TextEdit.Text), 0, D_5_TextEdit.Text) + If(String.IsNullOrEmpty(E_1_TextEdit.Text), 0, E_1_TextEdit.Text) + If(String.IsNullOrEmpty(F_3_TextEdit.Text), 0, F_3_TextEdit.Text) + If(String.IsNullOrEmpty(G_2_TextEdit.Text), 0, G_2_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _PL As Integer Implements Window_Forms_View.I_Belbin_Test._PL
        Get
            Return If(String.IsNullOrEmpty(A_1_TextEdit.Text), 0, A_1_TextEdit.Text) + If(String.IsNullOrEmpty(B_5_TextEdit.Text), 0, B_5_TextEdit.Text) + If(String.IsNullOrEmpty(C_6_TextEdit.Text), 0, C_6_TextEdit.Text) + If(String.IsNullOrEmpty(D_6_TextEdit.Text), 0, D_6_TextEdit.Text) + If(String.IsNullOrEmpty(E_3_TextEdit.Text), 0, E_3_TextEdit.Text) + If(String.IsNullOrEmpty(F_5_TextEdit.Text), 0, F_5_TextEdit.Text) + If(String.IsNullOrEmpty(G_6_TextEdit.Text), 0, G_6_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _RI As Integer Implements Window_Forms_View.I_Belbin_Test._RI
        Get
            Return If(String.IsNullOrEmpty(A_6_TextEdit.Text), 0, A_6_TextEdit.Text) + If(String.IsNullOrEmpty(B_8_TextEdit.Text), 0, B_8_TextEdit.Text) + If(String.IsNullOrEmpty(C_2_TextEdit.Text), 0, C_2_TextEdit.Text) + If(String.IsNullOrEmpty(D_4_TextEdit.Text), 0, D_4_TextEdit.Text) + If(String.IsNullOrEmpty(E_7_TextEdit.Text), 0, E_7_TextEdit.Text) + If(String.IsNullOrEmpty(F_1_TextEdit.Text), 0, F_1_TextEdit.Text) + If(String.IsNullOrEmpty(G_3_TextEdit.Text), 0, G_3_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _SH As Integer Implements Window_Forms_View.I_Belbin_Test._SH
        Get
            Return If(String.IsNullOrEmpty(A_3_TextEdit.Text), 0, A_3_TextEdit.Text) + If(String.IsNullOrEmpty(B_1_TextEdit.Text), 0, B_1_TextEdit.Text) + If(String.IsNullOrEmpty(C_7_TextEdit.Text), 0, C_7_TextEdit.Text) + If(String.IsNullOrEmpty(D_2_TextEdit.Text), 0, D_2_TextEdit.Text) + If(String.IsNullOrEmpty(E_6_TextEdit.Text), 0, E_6_TextEdit.Text) + If(String.IsNullOrEmpty(F_6_TextEdit.Text), 0, F_6_TextEdit.Text) + If(String.IsNullOrEmpty(G_5_TextEdit.Text), 0, G_5_TextEdit.Text)
        End Get
    End Property

    Public ReadOnly Property _TW As Integer Implements Window_Forms_View.I_Belbin_Test._TW
        Get
            Return If(String.IsNullOrEmpty(A_8_TextEdit.Text), 0, A_8_TextEdit.Text) + If(String.IsNullOrEmpty(B_3_TextEdit.Text), 0, B_3_TextEdit.Text) + If(String.IsNullOrEmpty(C_8_TextEdit.Text), 0, C_8_TextEdit.Text) + If(String.IsNullOrEmpty(D_8_TextEdit.Text), 0, D_8_TextEdit.Text) + If(String.IsNullOrEmpty(E_2_TextEdit.Text), 0, E_2_TextEdit.Text) + If(String.IsNullOrEmpty(F_7_TextEdit.Text), 0, F_7_TextEdit.Text) + If(String.IsNullOrEmpty(G_8_TextEdit.Text), 0, G_8_TextEdit.Text)
        End Get
    End Property

    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim _a As Integer = If(String.IsNullOrEmpty(A_1_TextEdit.Text), 0, A_1_TextEdit.Text) + If(String.IsNullOrEmpty(A_2_TextEdit.Text), 0, A_2_TextEdit.Text) + If(String.IsNullOrEmpty(A_3_TextEdit.Text), 0, A_3_TextEdit.Text) + If(String.IsNullOrEmpty(A_4_TextEdit.Text), 0, A_4_TextEdit.Text) + If(String.IsNullOrEmpty(A_5_TextEdit.Text), 0, A_5_TextEdit.Text) + If(String.IsNullOrEmpty(A_6_TextEdit.Text), 0, A_6_TextEdit.Text) + If(String.IsNullOrEmpty(A_7_TextEdit.Text), 0, A_7_TextEdit.Text) + If(String.IsNullOrEmpty(A_8_TextEdit.Text), 0, A_8_TextEdit.Text)
        Dim _b As Integer = If(String.IsNullOrEmpty(B_1_TextEdit.Text), 0, B_1_TextEdit.Text) + If(String.IsNullOrEmpty(B_2_TextEdit.Text), 0, B_2_TextEdit.Text) + If(String.IsNullOrEmpty(B_3_TextEdit.Text), 0, B_3_TextEdit.Text) + If(String.IsNullOrEmpty(B_4_TextEdit.Text), 0, B_4_TextEdit.Text) + If(String.IsNullOrEmpty(B_5_TextEdit.Text), 0, B_5_TextEdit.Text) + If(String.IsNullOrEmpty(B_6_TextEdit.Text), 0, B_6_TextEdit.Text) + If(String.IsNullOrEmpty(B_7_TextEdit.Text), 0, B_7_TextEdit.Text) + If(String.IsNullOrEmpty(B_8_TextEdit.Text), 0, B_8_TextEdit.Text)
        Dim _c As Integer = If(String.IsNullOrEmpty(C_1_TextEdit.Text), 0, C_1_TextEdit.Text) + If(String.IsNullOrEmpty(C_2_TextEdit.Text), 0, C_2_TextEdit.Text) + If(String.IsNullOrEmpty(C_3_TextEdit.Text), 0, C_3_TextEdit.Text) + If(String.IsNullOrEmpty(C_4_TextEdit.Text), 0, C_4_TextEdit.Text) + If(String.IsNullOrEmpty(C_5_TextEdit.Text), 0, C_5_TextEdit.Text) + If(String.IsNullOrEmpty(C_6_TextEdit.Text), 0, C_6_TextEdit.Text) + If(String.IsNullOrEmpty(C_7_TextEdit.Text), 0, C_7_TextEdit.Text) + If(String.IsNullOrEmpty(C_8_TextEdit.Text), 0, C_8_TextEdit.Text)
        Dim _d As Integer = If(String.IsNullOrEmpty(D_1_TextEdit.Text), 0, D_1_TextEdit.Text) + If(String.IsNullOrEmpty(D_2_TextEdit.Text), 0, D_2_TextEdit.Text) + If(String.IsNullOrEmpty(D_3_TextEdit.Text), 0, D_3_TextEdit.Text) + If(String.IsNullOrEmpty(D_4_TextEdit.Text), 0, D_4_TextEdit.Text) + If(String.IsNullOrEmpty(D_5_TextEdit.Text), 0, D_5_TextEdit.Text) + If(String.IsNullOrEmpty(D_6_TextEdit.Text), 0, D_6_TextEdit.Text) + If(String.IsNullOrEmpty(D_7_TextEdit.Text), 0, D_7_TextEdit.Text) + If(String.IsNullOrEmpty(D_8_TextEdit.Text), 0, D_8_TextEdit.Text)
        Dim _e As Integer = If(String.IsNullOrEmpty(E_1_TextEdit.Text), 0, E_1_TextEdit.Text) + If(String.IsNullOrEmpty(E_2_TextEdit.Text), 0, E_2_TextEdit.Text) + If(String.IsNullOrEmpty(E_3_TextEdit.Text), 0, E_3_TextEdit.Text) + If(String.IsNullOrEmpty(E_4_TextEdit.Text), 0, E_4_TextEdit.Text) + If(String.IsNullOrEmpty(E_5_TextEdit.Text), 0, E_5_TextEdit.Text) + If(String.IsNullOrEmpty(E_6_TextEdit.Text), 0, E_6_TextEdit.Text) + If(String.IsNullOrEmpty(E_7_TextEdit.Text), 0, E_7_TextEdit.Text) + If(String.IsNullOrEmpty(E_8_TextEdit.Text), 0, E_8_TextEdit.Text)
        Dim _f As Integer = If(String.IsNullOrEmpty(F_1_TextEdit.Text), 0, F_1_TextEdit.Text) + If(String.IsNullOrEmpty(F_2_TextEdit.Text), 0, F_2_TextEdit.Text) + If(String.IsNullOrEmpty(F_3_TextEdit.Text), 0, F_3_TextEdit.Text) + If(String.IsNullOrEmpty(F_4_TextEdit.Text), 0, F_4_TextEdit.Text) + If(String.IsNullOrEmpty(F_5_TextEdit.Text), 0, F_5_TextEdit.Text) + If(String.IsNullOrEmpty(F_6_TextEdit.Text), 0, F_6_TextEdit.Text) + If(String.IsNullOrEmpty(F_7_TextEdit.Text), 0, F_7_TextEdit.Text) + If(String.IsNullOrEmpty(F_8_TextEdit.Text), 0, F_8_TextEdit.Text)
        Dim _g As Integer = If(String.IsNullOrEmpty(G_1_TextEdit.Text), 0, G_1_TextEdit.Text) + If(String.IsNullOrEmpty(G_2_TextEdit.Text), 0, G_2_TextEdit.Text) + If(String.IsNullOrEmpty(G_3_TextEdit.Text), 0, G_3_TextEdit.Text) + If(String.IsNullOrEmpty(G_4_TextEdit.Text), 0, G_4_TextEdit.Text) + If(String.IsNullOrEmpty(G_5_TextEdit.Text), 0, G_5_TextEdit.Text) + If(String.IsNullOrEmpty(G_6_TextEdit.Text), 0, G_6_TextEdit.Text) + If(String.IsNullOrEmpty(G_7_TextEdit.Text), 0, G_7_TextEdit.Text) + If(String.IsNullOrEmpty(G_8_TextEdit.Text), 0, F_8_TextEdit.Text)
        If _a <> 10 Then
            errMessage = "Section A masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _b <> 10 Then
            errMessage = "Section B masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _c <> 10 Then
            errMessage = "Section C masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _d <> 10 Then
            errMessage = "Section D masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _e <> 10 Then
            errMessage = "Section E masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _f <> 10 Then
            errMessage = "Section F masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _g <> 10 Then
            errMessage = "Section G masih salah!" & Environment.NewLine & "Tolong dikoreksi!"
            Return
        End If
        If _Presenter.save Then
            btnResult.Enabled = True
        End If
    End Sub

    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click
        Dim o = _Presenter.Get_Profil
        Dim j = _Presenter.Get_Jawaban
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_Belbin(o, j)
        rpt.ShowPreviewDialog()
    End Sub
End Class