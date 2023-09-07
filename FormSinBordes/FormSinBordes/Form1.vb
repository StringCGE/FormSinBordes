Imports System.Drawing.Drawing2D
Imports System.Drawing.IconLib
Imports System.IO
Imports System.Runtime.InteropServices
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim miBorde As New Padding(5)
    Const BORDE_SIZE As Integer = 10
    Public Sub New()
        InitializeComponent()
        miBorde = New Padding(BORDE_SIZE)
        FormBorderStyle = FormBorderStyle.None
        BackColor = Color.Blue
        TransparencyKey = Color.Blue
        DoubleBuffered = True
        AplicaRestaurarBorde()
    End Sub

    Protected Sub AplicaRestaurarBorde()
        PNL_AreaCliente.SetBounds(miBorde.Left, miBorde.Top, Me.Width - miBorde.Left - miBorde.Right, Me.Height - miBorde.Top - miBorde.Bottom)
    End Sub
    Protected Sub AplicaMaximizarBorde()
        PNL_AreaCliente.SetBounds(0, 0, Me.Width, Me.Height)
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg <> 132 Then ' OrElse m.Result.ToInt32() <> 1 Then
            Return
        End If
        Dim screenPoint As New Point(m.LParam.ToInt32())
        Dim clientPoint As Point = PointToClient(screenPoint)


        Dim GetId As Func(Of Integer, Integer, Integer, IntPtr) = Function(A, B, C)
                                                                      If clientPoint.X <= BORDE_SIZE Then
                                                                          Return New IntPtr(A)
                                                                      ElseIf clientPoint.X < (Size.Width - BORDE_SIZE) Then
                                                                          Return New IntPtr(B)
                                                                      Else
                                                                          Return New IntPtr(C)
                                                                      End If
                                                                  End Function
        'Lo curioso es quien hizo este codigo dejo los numeros en torno a cada posicion desde las cuales
        'se puede redimensionar
        If clientPoint.Y <= BORDE_SIZE Then
            m.Result = GetId(13, 12, 14)
        ElseIf clientPoint.Y <= (Size.Height - BORDE_SIZE) Then
            m.Result = GetId(10, 0, 11) ' m.Result = GetId(10, 2, 11) el 2 es para mover el formulario desde la propia interaccion con el formulario
        Else
            m.Result = GetId(16, 15, 17)
        End If
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, MyBase.MouseDown, PNL_Transparente.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub BTN_Cerrar_Click(sender As Object, e As EventArgs) Handles BTN_Cerrar.Click
        Me.Close()
        'Application.ExitThread()
    End Sub

    Dim EstaMaximizado As Boolean = False
    Dim form_fws As FormWindowState
    Dim form_size As Size
    Dim form_loc As Point
    Private Sub BTN_MinMax_Click(sender As Object, e As EventArgs) Handles BTN_MinMax.Click
        EstaMaximizado = Not EstaMaximizado
        If EstaMaximizado Then
            AplicaMaximizarBorde()
            form_fws = Me.WindowState
            form_size = Me.Size
            form_loc = Me.Location
            'Me.WindowState = FormWindowState.Maximized

            Dim mousePos As Point = Control.MousePosition
            Dim screen As Screen = Screen.FromPoint(mousePos)
            Dim screenName As String = screen.DeviceName
            Dim screenWidth As Integer = screen.Bounds.Width
            Dim screenHeight As Integer = screen.Bounds.Height
            ' Obtener la pantalla en la que se encuentra el puntero del mouse
            Dim currentScreen As Screen = Screen.FromPoint(Cursor.Position)

            ' Obtener el tamaño del área de trabajo de la pantalla actual (excluyendo la barra de tareas)
            Dim workingArea As Rectangle = currentScreen.WorkingArea
            Me.Location = workingArea.Location
            Me.Size = workingArea.Size
        Else
            AplicaRestaurarBorde()
            Me.WindowState = form_fws
            Me.Size = form_size
            Me.Location = form_loc
        End If
    End Sub

    Private Sub BTN_Ocultar_Click(sender As Object, e As EventArgs) Handles BTN_Ocultar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#Region "Imports dll"
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
#End Region
End Class
