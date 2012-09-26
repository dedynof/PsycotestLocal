Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon


Public Class Main
    Sub New()
        InitSkins()
        InitializeComponent()
        

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")

    End Sub
   
  

    Private Sub mbtiBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mbtiBarButtonItem.ItemClick
        Dim f As New frm_profil(1)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub MI_BarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MI_BarButtonItem.ItemClick
        Dim f As New frm_profil(9)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub belbinBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles belbinBarButtonItem.ItemClick
        Dim f As New frm_profil(5)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub bigFiveBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bigFiveBarButtonItem.ItemClick
        Dim f As New frm_profil(6)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub EneagramBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EneagramBarButtonItem.ItemClick
        Dim f As New frm_profil(8)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub FiroBBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles FiroBBarButtonItem.ItemClick
        Dim f As New frm_profil(7)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub sdsBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles sdsBarButtonItem.ItemClick
        Dim f As New frm_profil(4)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub discBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles discBarButtonItem.ItemClick
        Dim f As New frm_profil(2)
        For Each x In Me.MdiChildren
            If f.Name = f.Name Then
                x.Close()
            End If
        Next
        f.chk_positionStyleAnalysis.Visible = True
        f.chk_teamProfile.Visible = True
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub
End Class
