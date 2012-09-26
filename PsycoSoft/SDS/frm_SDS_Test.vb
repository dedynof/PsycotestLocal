Imports Window_Forms_Model
Imports Window_Forms_Presenter
Imports Window_Forms_Report
Imports Window_Forms_View
Public Class frm_SDS_Test : Implements I_SDS_Test

    Private _Presenter As SDS_Test_Presenter
    Private _profil_id As Integer
    Public Sub New(profil_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _profil_id = profil_id
        _Presenter = New SDS_Test_Presenter(Me)
        _Presenter.DisplayNommor()
    End Sub

    Public WriteOnly Property errMessage As String Implements Window_Forms_View.I_SDS_Test.errMessage
        Set(value As String)
            MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Set
    End Property

    Public ReadOnly Property profil_id As Integer Implements Window_Forms_View.I_SDS_Test.profil_id
        Get
            Return _profil_id
        End Get
    End Property

    Public WriteOnly Property SetNomor As String Implements Window_Forms_View.I_SDS_Test.SetNomor
        Set(value As String)
            lblnomor.Text = "Nomor : " & value
        End Set
    End Property

    Public WriteOnly Property suksesMessage As String Implements Window_Forms_View.I_SDS_Test.suksesMessage
        Set(value As String)
            MessageBox.Show(value, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Set
    End Property

    Public ReadOnly Property _a As Integer Implements Window_Forms_View.I_SDS_Test._a
        Get
            Return CheckEdit45.EditValue + CheckEdit47.EditValue + CheckEdit49.EditValue + CheckEdit51.EditValue + CheckEdit53.EditValue + CheckEdit55.EditValue + CheckEdit57.EditValue + CheckEdit59.EditValue + CheckEdit61.EditValue + CheckEdit63.EditValue + CheckEdit65.EditValue + A_kom + A_Pekerjaan + A1_Kemampuan + A2_Kemampuan
        End Get
    End Property

    Public ReadOnly Property _c As Integer Implements Window_Forms_View.I_SDS_Test._c
        Get
            Return CheckEdit111.EditValue + CheckEdit113.EditValue + CheckEdit115.EditValue + CheckEdit117.EditValue + CheckEdit119.EditValue + CheckEdit121.EditValue + CheckEdit123.EditValue + CheckEdit125.EditValue + CheckEdit127.EditValue + CheckEdit129.EditValue + CheckEdit131.EditValue + C_kom + C_Pekerjaan + C1_Kemampuan + C2_Kemampuan
        End Get
    End Property

    Public ReadOnly Property _e As Integer Implements Window_Forms_View.I_SDS_Test._e
        Get
            Return CheckEdit89.EditValue + CheckEdit91.EditValue + CheckEdit93.EditValue + CheckEdit95.EditValue + CheckEdit97.EditValue + CheckEdit99.EditValue + CheckEdit101.EditValue + CheckEdit103.EditValue + CheckEdit105.EditValue + CheckEdit107.EditValue + CheckEdit109.EditValue + E_kom + E_Pekerjaan + E1_Kemampuan + E2_Kemampuan
        End Get
    End Property

    Public ReadOnly Property _i As Integer Implements Window_Forms_View.I_SDS_Test._i
        Get
            Return CheckEdit23.EditValue + CheckEdit25.EditValue + CheckEdit27.EditValue + CheckEdit29.EditValue + CheckEdit31.EditValue + CheckEdit33.EditValue + CheckEdit35.EditValue + CheckEdit37.EditValue + CheckEdit39.EditValue + CheckEdit41.EditValue + CheckEdit43.EditValue + I_kom + I_Pekerjaan + I1_Kemampuan + I2_Kemampuan
        End Get
    End Property

    Public ReadOnly Property _r As Integer Implements Window_Forms_View.I_SDS_Test._r
        Get
            Return CheckEdit1.EditValue + CheckEdit3.EditValue + CheckEdit5.EditValue + CheckEdit7.EditValue + CheckEdit9.EditValue + CheckEdit11.EditValue + CheckEdit13.EditValue + CheckEdit15.EditValue + CheckEdit17.EditValue + CheckEdit19.EditValue + CheckEdit21.EditValue + R_kom + R_Pekerjaan + R1_Kemampuan + R2_Kemampuan
        End Get
    End Property

    Public ReadOnly Property _s As Integer Implements Window_Forms_View.I_SDS_Test._s
        Get
            Return CheckEdit67.EditValue + CheckEdit69.EditValue + CheckEdit71.EditValue + CheckEdit73.EditValue + CheckEdit75.EditValue + CheckEdit77.EditValue + CheckEdit79.EditValue + CheckEdit81.EditValue + CheckEdit83.EditValue + CheckEdit85.EditValue + CheckEdit87.EditValue + S_kom + S_Pekerjaan + S1_Kemampuan + S2_Kemampuan
        End Get
    End Property

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If _Presenter.save Then
            btnResult.Enabled = True
        End If
    End Sub

#Region "Kompetensi"
    ReadOnly Property R_kom As Integer
        Get
            Return CheckEdit133.EditValue + CheckEdit135.EditValue + CheckEdit137.EditValue + CheckEdit139.EditValue + CheckEdit141.EditValue + CheckEdit143.EditValue + CheckEdit145.EditValue + CheckEdit147.EditValue + CheckEdit149.EditValue + CheckEdit151.EditValue + CheckEdit153.EditValue
        End Get
    End Property
    ReadOnly Property I_kom As Integer
        Get
            Return CheckEdit155.EditValue + CheckEdit157.EditValue + CheckEdit159.EditValue + CheckEdit161.EditValue + CheckEdit163.EditValue + CheckEdit165.EditValue + CheckEdit167.EditValue + CheckEdit169.EditValue + CheckEdit171.EditValue + CheckEdit173.EditValue + CheckEdit175.EditValue
        End Get
    End Property
    ReadOnly Property A_kom As Integer
        Get
            Return CheckEdit177.EditValue + CheckEdit179.EditValue + CheckEdit181.EditValue + CheckEdit183.EditValue + CheckEdit185.EditValue + CheckEdit187.EditValue + CheckEdit189.EditValue + CheckEdit191.EditValue + CheckEdit193.EditValue + CheckEdit195.EditValue + CheckEdit197.EditValue
        End Get
    End Property
    ReadOnly Property S_kom As Integer
        Get
            Return CheckEdit199.EditValue + CheckEdit201.EditValue + CheckEdit203.EditValue + CheckEdit205.EditValue + CheckEdit207.EditValue + CheckEdit209.EditValue + CheckEdit211.EditValue + CheckEdit213.EditValue + CheckEdit215.EditValue + CheckEdit217.EditValue + CheckEdit219.EditValue
        End Get
    End Property
    ReadOnly Property E_kom As Integer
        Get
            Return CheckEdit221.EditValue + CheckEdit223.EditValue + CheckEdit225.EditValue + CheckEdit227.EditValue + CheckEdit229.EditValue + CheckEdit231.EditValue + CheckEdit233.EditValue + CheckEdit235.EditValue + CheckEdit237.EditValue + CheckEdit239.EditValue + CheckEdit241.EditValue
        End Get
    End Property
    ReadOnly Property C_kom As Integer
        Get
            Return CheckEdit243.EditValue + CheckEdit245.EditValue + CheckEdit247.EditValue + CheckEdit249.EditValue + CheckEdit251.EditValue + CheckEdit253.EditValue + CheckEdit255.EditValue + CheckEdit257.EditValue + CheckEdit259.EditValue + CheckEdit261.EditValue + CheckEdit263.EditValue
        End Get
    End Property
#End Region

#Region "Pekerjaan"
    ReadOnly Property R_Pekerjaan As Integer
        Get
            Return CheckEdit265.EditValue + CheckEdit267.EditValue + CheckEdit269.EditValue + CheckEdit271.EditValue + CheckEdit273.EditValue + CheckEdit275.EditValue + CheckEdit277.EditValue + CheckEdit279.EditValue + CheckEdit281.EditValue + CheckEdit283.EditValue + CheckEdit285.EditValue + CheckEdit287.EditValue + CheckEdit289.EditValue + CheckEdit291.EditValue
        End Get
    End Property
    ReadOnly Property I_Pekerjaan As Integer
        Get
            Return CheckEdit293.EditValue + CheckEdit295.EditValue + CheckEdit297.EditValue + CheckEdit299.EditValue + CheckEdit301.EditValue + CheckEdit303.EditValue + CheckEdit305.EditValue + CheckEdit307.EditValue + CheckEdit309.EditValue + CheckEdit311.EditValue + CheckEdit313.EditValue + CheckEdit315.EditValue + CheckEdit317.EditValue + CheckEdit319.EditValue
        End Get
    End Property
    ReadOnly Property A_Pekerjaan As Integer
        Get
            Return CheckEdit321.EditValue + CheckEdit323.EditValue + CheckEdit325.EditValue + CheckEdit327.EditValue + CheckEdit329.EditValue + CheckEdit331.EditValue + CheckEdit333.EditValue + CheckEdit335.EditValue + CheckEdit337.EditValue + CheckEdit339.EditValue + CheckEdit341.EditValue + CheckEdit343.EditValue + CheckEdit345.EditValue + CheckEdit347.EditValue
        End Get
    End Property
    ReadOnly Property S_Pekerjaan As Integer
        Get
            Return CheckEdit349.EditValue + CheckEdit351.EditValue + CheckEdit353.EditValue + CheckEdit355.EditValue + CheckEdit357.EditValue + CheckEdit359.EditValue + CheckEdit361.EditValue + CheckEdit363.EditValue + CheckEdit365.EditValue + CheckEdit367.EditValue + CheckEdit369.EditValue + CheckEdit371.EditValue + CheckEdit373.EditValue + CheckEdit375.EditValue
        End Get
    End Property
    ReadOnly Property E_Pekerjaan As Integer
        Get
            Return CheckEdit377.EditValue + CheckEdit379.EditValue + CheckEdit381.EditValue + CheckEdit383.EditValue + CheckEdit385.EditValue + CheckEdit387.EditValue + CheckEdit389.EditValue + CheckEdit391.EditValue + CheckEdit393.EditValue + CheckEdit395.EditValue + CheckEdit397.EditValue + CheckEdit399.EditValue + CheckEdit401.EditValue + CheckEdit403.EditValue
        End Get
    End Property
    ReadOnly Property C_Pekerjaan As Integer
        Get
            Return CheckEdit405.EditValue + CheckEdit407.EditValue + CheckEdit409.EditValue + CheckEdit411.EditValue + CheckEdit413.EditValue + CheckEdit415.EditValue + CheckEdit417.EditValue + CheckEdit419.EditValue + CheckEdit421.EditValue + CheckEdit423.EditValue + CheckEdit425.EditValue + CheckEdit427.EditValue + CheckEdit429.EditValue + CheckEdit431.EditValue
        End Get
    End Property
#End Region

#Region "Kemampuan"
    ReadOnly Property R1_Kemampuan As Integer
        Get
            Return CheckEdit433.EditValue + CheckEdit434.EditValue + CheckEdit435.EditValue + CheckEdit436.EditValue + CheckEdit437.EditValue + CheckEdit438.EditValue + CheckEdit439.EditValue
        End Get
    End Property
    ReadOnly Property I1_Kemampuan As Integer
        Get
            Return CheckEdit440.EditValue + CheckEdit441.EditValue + CheckEdit442.EditValue + CheckEdit443.EditValue + CheckEdit444.EditValue + CheckEdit445.EditValue + CheckEdit446.EditValue
        End Get
    End Property
    ReadOnly Property A1_Kemampuan As Integer
        Get
            Return CheckEdit447.EditValue + CheckEdit448.EditValue + CheckEdit449.EditValue + CheckEdit450.EditValue + CheckEdit451.EditValue + CheckEdit452.EditValue + CheckEdit453.EditValue
        End Get
    End Property
    ReadOnly Property S1_Kemampuan As Integer
        Get
            Return CheckEdit454.EditValue + CheckEdit455.EditValue + CheckEdit456.EditValue + CheckEdit457.EditValue + CheckEdit458.EditValue + CheckEdit459.EditValue + CheckEdit460.EditValue
        End Get
    End Property
    ReadOnly Property E1_Kemampuan As Integer
        Get
            Return CheckEdit461.EditValue + CheckEdit462.EditValue + CheckEdit463.EditValue + CheckEdit464.EditValue + CheckEdit465.EditValue + CheckEdit466.EditValue + CheckEdit467.EditValue
        End Get
    End Property
    ReadOnly Property C1_Kemampuan As Integer
        Get
            Return CheckEdit468.EditValue + CheckEdit469.EditValue + CheckEdit470.EditValue + CheckEdit471.EditValue + CheckEdit472.EditValue + CheckEdit473.EditValue + CheckEdit474.EditValue
        End Get
    End Property

    ReadOnly Property R2_Kemampuan As Integer
        Get
            Return CheckEdit475.EditValue + CheckEdit476.EditValue + CheckEdit477.EditValue + CheckEdit478.EditValue + CheckEdit479.EditValue + CheckEdit480.EditValue + CheckEdit481.EditValue
        End Get
    End Property
    ReadOnly Property I2_Kemampuan As Integer
        Get
            Return CheckEdit482.EditValue + CheckEdit483.EditValue + CheckEdit484.EditValue + CheckEdit485.EditValue + CheckEdit486.EditValue + CheckEdit487.EditValue + CheckEdit488.EditValue
        End Get
    End Property
    ReadOnly Property A2_Kemampuan As Integer
        Get
            Return CheckEdit489.EditValue + CheckEdit490.EditValue + CheckEdit491.EditValue + CheckEdit492.EditValue + CheckEdit493.EditValue + CheckEdit494.EditValue + CheckEdit495.EditValue
        End Get
    End Property
    ReadOnly Property S2_Kemampuan As Integer
        Get
            Return CheckEdit496.EditValue + CheckEdit497.EditValue + CheckEdit498.EditValue + CheckEdit499.EditValue + CheckEdit500.EditValue + CheckEdit501.EditValue + CheckEdit502.EditValue
        End Get
    End Property
    ReadOnly Property E2_Kemampuan As Integer
        Get
            Return CheckEdit503.EditValue + CheckEdit504.EditValue + CheckEdit505.EditValue + CheckEdit506.EditValue + CheckEdit507.EditValue + CheckEdit508.EditValue + CheckEdit509.EditValue
        End Get
    End Property
    ReadOnly Property C2_Kemampuan As Integer
        Get
            Return CheckEdit510.EditValue + CheckEdit511.EditValue + CheckEdit512.EditValue + CheckEdit513.EditValue + CheckEdit514.EditValue + CheckEdit515.EditValue + CheckEdit516.EditValue
        End Get
    End Property
#End Region


    Private Sub btnResult_Click(sender As System.Object, e As System.EventArgs) Handles btnResult.Click
        Dim cls As New clsRPT
        Dim rpt = cls.Get_rpt_sds(_Presenter.Get_Profil)
        rpt.ShowPreviewDialog()
    End Sub
End Class