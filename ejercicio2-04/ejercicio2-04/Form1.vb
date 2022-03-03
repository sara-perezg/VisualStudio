Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub
    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'tmOCULTAR.Enabled = True
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width <= 60 Then
            tmMOSTRAR.Enabled = True
        End If

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        btnMinimizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurarr_Click_1(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMinimizar.Visible = True
    End Sub
    Private Sub AbrirFormEnPanel(Formhijo As Object)
        If Me.panelContenedor.Controls.Count > 0 Then Me.panelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(FormProductos)

    End Sub

End Class
