Imports ComponentFactory.Krypton
Imports ComponentFactory.Krypton.Toolkit

Public Class MDI

    Public oldControl As Control = Nothing

    Public NIdCaja As Integer

    'Private Sub MostrarMantenerModulo(ByVal Control As UserControl)
    '    pcMain.SuspendLayout()
    '    Try
    '        '    Me.pbImagen.Visible = False
    '        MostrarMantenerModulo(Control, oldControl, GroupControl1)
    '        oldControl = Control

    '    Finally
    '        pcMain.ResumeLayout()
    '    End Try
    'End Sub

    'Function MostrarMantenerModulo(ByVal Control As UserControl, ByVal oldControl As Windows.Forms.Control, ByVal groupControl As Panel) As Boolean

    '    Dim currentCursor As Cursor = Cursor.Current
    '    Cursor.Current = Cursors.WaitCursor
    '    groupControl.Parent.SuspendLayout()
    '    groupControl.SuspendLayout()
    '    Try
    '        Control.Bounds = groupControl.DisplayRectangle
    '        'Instance.CurrentModuleBase = item
    '        Control.Visible = False
    '        groupControl.Controls.Add(Control)
    '        Control.Dock = DockStyle.Fill

    '        'CloseCustomizationForm(oldControl)

    '        Control.Visible = True


    '        If Not oldControl Is Nothing Then
    '            If Control.Equals(oldControl) Then
    '            Else
    '                oldControl.Visible = False
    '            End If

    '        End If
    '    Finally
    '        oldControl = Control
    '        groupControl.ResumeLayout(True)
    '        groupControl.Parent.ResumeLayout(True)
    '        Cursor.Current = currentCursor
    '    End Try

    '    Return True
    'End Function

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim control As New ControlFondo
        MostrarMantenerModulo(control)


        'configuracion empresas
        'KryptonRibbonGroupButton5.Visible = False

        KryptonRibbonGroupButton25.Visible = False
        KryptonRibbonGroupButton26.Visible = False
        KryptonRibbonGroupButton28.Visible = False
        KryptonRibbonGroupButton29.Visible = False

        'consultas
        KryptonRibbonGroupButton17.Visible = False


    End Sub



    Private Sub includeInsertCalendar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton3_Click(sender As Object, e As EventArgs)
        'Dim control As New ControlComunicacionBaja
        'MostrarMantenerModulo(control)
    End Sub

    Private Sub KryptonRibbonResumenDiario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MDIFacturacion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Cerrar el modulo, ¿Desea salir?", vbYesNo, "Salir del Modulo")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub KryptonRibbonComprobantesAnulados_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub KryptonRibbonClientes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonProductoGrupo_Click(sender As Object, e As EventArgs) Handles KryptonRibbonProductoGrupo.Click

    End Sub

    Private Sub KryptonRibbonProductoGrupoSub_Click(sender As Object, e As EventArgs) Handles KryptonRibbonProductoGrupoSub.Click

    End Sub

    Private Sub KryptonRibbonProducto_Click(sender As Object, e As EventArgs) Handles KryptonRibbonProducto.Click

    End Sub

    Private Sub KryptonRibbonComprobantes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonControlCaja_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub MostrarMantenerModulo(ByVal Control As UserControl)
        pcMain.SuspendLayout()
        Try
            '    Me.pbImagen.Visible = False
            MostrarMantenerModulo(Control, oldControl, GroupControl1)
            oldControl = Control

        Finally
            pcMain.ResumeLayout()
        End Try
    End Sub



    Function MostrarMantenerModulo(ByVal Control As UserControl, ByVal oldControl As Windows.Forms.Control, ByVal groupControl As Panel) As Boolean

        Dim currentCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        groupControl.Parent.SuspendLayout()
        groupControl.SuspendLayout()
        Try
            Control.Bounds = groupControl.DisplayRectangle
            'Instance.CurrentModuleBase = item
            Control.Visible = False
            groupControl.Controls.Add(Control)
            Control.Dock = DockStyle.Fill

            'CloseCustomizationForm(oldControl)

            Control.Visible = True


            If Not oldControl Is Nothing Then
                If Control.Equals(oldControl) Then
                Else
                    oldControl.Visible = False
                End If

            End If
        Finally
            oldControl = Control
            groupControl.ResumeLayout(True)
            groupControl.Parent.ResumeLayout(True)
            Cursor.Current = currentCursor
        End Try

        Return True
    End Function

    Private Sub KryptonRibbonConsultaCDR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton1_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton1.Click

    End Sub

    Private Sub KryptonRibbonGroupButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton14_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub KryptonRibbonGroupButton11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton4_Click_1(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton4.Click

    End Sub

    Private Sub kryptonRibbon_SelectedTabChanged(sender As Object, e As EventArgs) Handles kryptonRibbon.SelectedTabChanged

    End Sub

    Private Sub KryptonRibbonGroupButton24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KryptonRibbonGroupButton27_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton27.Click

    End Sub


    Private Sub KryptonRibbonGroupButton23_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton23.Click

    End Sub

    Private Sub KryptonRibbonGroupButton16_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton16.Click
        Dim control As New ControlConsultasSunat
        MostrarMantenerModulo(control)
    End Sub
End Class