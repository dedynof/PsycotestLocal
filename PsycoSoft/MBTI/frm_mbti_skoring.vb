Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Public Class frm_mbti_skoring : Implements I_mbti_skoring
    Private _Presenter As mbti_skoring_Presenter
    Private _profil_id As Integer
    Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New mbti_skoring_Presenter(Me)
        _Presenter.setNomor()
        _Presenter.Display()
    End Sub
    Public Property EI_1 As String Implements Window_Forms_View.I_mbti_skoring.EI_1
        Get
            Return EI_I_TextEdit.Text
        End Get
        Set(value As String)
            EI_I_TextEdit.Text = value
        End Set
    End Property

    Public Property EI_2 As String Implements Window_Forms_View.I_mbti_skoring.EI_2
        Get
            Return EI_II_TextEdit.Text
        End Get
        Set(value As String)
            EI_II_TextEdit.Text = value
        End Set
    End Property

    Public Property EI_3 As String Implements Window_Forms_View.I_mbti_skoring.EI_3
        Get
            Return EI_III_TextEdit.Text
        End Get
        Set(value As String)
            EI_III_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property EI_4 As String Implements Window_Forms_View.I_mbti_skoring.EI_4
        Set(value As String)
            EI_IV_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property errorMessage As String Implements Window_Forms_View.I_mbti_skoring.errorMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public Property JP_1 As String Implements Window_Forms_View.I_mbti_skoring.JP_1
        Get
            Return JP_I_TextEdit.Text
        End Get
        Set(value As String)
            JP_I_TextEdit.Text = value
        End Set
    End Property

    Public Property JP_2 As String Implements Window_Forms_View.I_mbti_skoring.JP_2
        Get
            Return JP_II_TextEdit.Text
        End Get
        Set(value As String)
            JP_II_TextEdit.Text = value
        End Set
    End Property

    Public Property JP_3 As String Implements Window_Forms_View.I_mbti_skoring.JP_3
        Get
            Return JP_III_TextEdit.Text
        End Get
        Set(value As String)
            JP_III_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property JP_4 As String Implements Window_Forms_View.I_mbti_skoring.JP_4
        Set(value As String)
            JP_IV_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property Nomor As String Implements Window_Forms_View.I_mbti_skoring.Nomor
        Set(value As String)
            lblNomor.Text = value
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_mbti_skoring.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public Property SN_1 As String Implements Window_Forms_View.I_mbti_skoring.SN_1
        Get
            Return SN_I_TextEdit.Text
        End Get
        Set(value As String)
            SN_I_TextEdit.Text = value
        End Set
    End Property

    Public Property SN_2 As String Implements Window_Forms_View.I_mbti_skoring.SN_2
        Get
            Return SN_II_TextEdit.Text
        End Get
        Set(value As String)
            SN_II_TextEdit.Text = value
        End Set
    End Property

    Public Property SN_3 As String Implements Window_Forms_View.I_mbti_skoring.SN_3
        Get
            Return SN_III_TextEdit.Text
        End Get
        Set(value As String)
            SN_III_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property SN_4 As String Implements Window_Forms_View.I_mbti_skoring.SN_4
        Set(value As String)
            SN_IV_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_mbti_skoring.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public Property TF_1 As String Implements Window_Forms_View.I_mbti_skoring.TF_1
        Get
            Return TF_I_TextEdit.Text
        End Get
        Set(value As String)
            TF_I_TextEdit.Text = value
        End Set
    End Property

    Public Property TF_2 As String Implements Window_Forms_View.I_mbti_skoring.TF_2
        Get
            Return TF_II_TextEdit.Text
        End Get
        Set(value As String)
            TF_II_TextEdit.Text = value
        End Set
    End Property

    Public Property TF_3 As String Implements Window_Forms_View.I_mbti_skoring.TF_3
        Get
            Return TF_III_TextEdit.Text
        End Get
        Set(value As String)
            TF_III_TextEdit.Text = value
        End Set
    End Property

    Public WriteOnly Property TF_4 As String Implements Window_Forms_View.I_mbti_skoring.TF_4
        Set(value As String)
            TF_IV_TextEdit.Text = value
        End Set
    End Property

    
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If _Presenter.save Then
           
        End If
    End Sub

    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click
        If EI_IV_TextEdit.Text.Trim = "" Then
            errorMessage = "Silahkan data di save terlebih dahulu"
            Return
        End If
        Dim f As New frm_mbti_result(profil_id)
        f.ShowDialog()
    End Sub

    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub
End Class