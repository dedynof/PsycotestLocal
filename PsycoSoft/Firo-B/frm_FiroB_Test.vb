Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_View
Imports DevExpress.XtraEditors
Imports Window_Forms_Report
Public Class frm_FiroB_Test : Implements I_FiroB_Test

    Private _Presenter As FiroB_Test_Presenter
    Private _profil_id As Integer
    Public Sub New(profilid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profilid
        _Presenter = New FiroB_Test_Presenter(Me)
        _Presenter.DisplayNomor()
    End Sub

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_FiroB_Test.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_FiroB_Test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property SetNomor As String Implements Window_Forms_View.I_FiroB_Test.SetNomor
        Set(value As String)
            lblnomor.Text = "Nomor : " & value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_FiroB_Test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public ReadOnly Property _ae As Integer Implements Window_Forms_View.I_FiroB_Test._ae
        Get
            Return If(Convert.ToInt32(TextEdit4.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit8.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit12.Text) < 2, 1, 0) + If(Convert.ToInt32(TextEdit17.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit19.Text) > 3, 1, 0) + If(Convert.ToInt32(TextEdit21.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit23.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit25.Text) > 3, 1, 0) + If(Convert.ToInt32(TextEdit27.Text) < 3, 1, 0)
        End Get
    End Property

    Public ReadOnly Property _aw As Integer Implements Window_Forms_View.I_FiroB_Test._aw
        Get
            Return If(Convert.ToInt32(TextEdit29.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit32.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit35.Text) > 4, 1, 0) + If(Convert.ToInt32(TextEdit38.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit40.Text) > 4, 1, 0) + If(Convert.ToInt32(TextEdit43.Text) < 2, 1, 0) + If(Convert.ToInt32(TextEdit46.Text) > 4, 1, 0) + If(Convert.ToInt32(TextEdit49.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit52.Text) > 4, 1, 0)
        End Get
    End Property

    Public ReadOnly Property _ce As Integer Implements Window_Forms_View.I_FiroB_Test._ce
        Get
            Return If(Convert.ToInt32(TextEdit30.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit33.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit36.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit41.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit44.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit47.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit50.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit53.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit54.Text) < 3, 1, 0)
        End Get
    End Property

    Public ReadOnly Property _cw As Integer Implements Window_Forms_View.I_FiroB_Test._cw
        Get
            Return If(Convert.ToInt32(TextEdit2.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit6.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit10.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit14.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit18.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit20.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit22.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit24.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit26.Text) < 4, 1, 0)
        End Get
    End Property

    Public ReadOnly Property _ie As Integer Implements Window_Forms_View.I_FiroB_Test._ie
        Get
            Return If(Convert.ToInt32(TextEdit1.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit3.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit5.Text) < 5, 1, 0) + If(Convert.ToInt32(TextEdit7.Text) < 4, 1, 0) + If(Convert.ToInt32(TextEdit9.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit11.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit13.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit15.Text) < 2, 1, 0) + If(Convert.ToInt32(TextEdit16.Text) < 2, 1, 0)
        End Get
    End Property

    Public ReadOnly Property _iw As Integer Implements Window_Forms_View.I_FiroB_Test._iw
        Get
            Return If(Convert.ToInt32(TextEdit28.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit31.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit34.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit37.Text) < 2, 1, 0) + If(Convert.ToInt32(TextEdit39.Text) < 2, 1, 0) + If(Convert.ToInt32(TextEdit42.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit45.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit48.Text) < 3, 1, 0) + If(Convert.ToInt32(TextEdit51.Text) < 3, 1, 0)
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        For Each x In TableLayoutPanel2.Controls
            If TypeOf (x) Is TextEdit Then
                If CType(x, TextEdit).Text.Trim = "" Then
                    errMessage = "Nomor : " & CType(x, TextEdit).Name.ToString.Replace("TextEdit", "") & " Tidak Boleh Kosong"
                    Return
                End If
            End If
        Next
        For Each x In TableLayoutPanel4.Controls
            If TypeOf (x) Is TextEdit Then
                If CType(x, TextEdit).Text.Trim = "" Then
                    errMessage = "Nomor : " & CType(x, TextEdit).Name.ToString.Replace("TextEdit", "") & " Tidak Boleh Kosong"
                    Return
                End If
            End If
        Next
        For Each x In TableLayoutPanel6.Controls
            If TypeOf (x) Is TextEdit Then
                If CType(x, TextEdit).Text.Trim = "" Then
                    errMessage = "Nomor : " & CType(x, TextEdit).Name.ToString.Replace("TextEdit", "") & " Tidak Boleh Kosong"
                    Return
                End If
            End If
        Next
        If _Presenter.Save Then
            btnResult.Enabled = True
        End If
    End Sub

    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub

    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click

    End Sub
End Class