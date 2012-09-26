Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports Window_Forms_Report
Public Class frm_mbti_result : Implements I_mbti_result
    Private _Presenter As mbti_result_Presenter
    Dim _profil_id As Integer
    Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New mbti_result_Presenter(Me)
        _Presenter.DisplayPartisipan()
    End Sub
    Public WriteOnly Property NamaPartisipan As String Implements Window_Forms_View.I_mbti_result.NamaPartisipan
        Set(value As String)
            lblName.Text = value
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_mbti_result.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Private Sub btn_overview_Click(sender As System.Object, e As System.EventArgs) Handles btn_overview.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(1, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(2, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(6, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(8, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(5, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton9_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton9.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(9, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton6_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton6.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(7, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton7_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton7.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(4, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_MBTI(3, _Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub
End Class