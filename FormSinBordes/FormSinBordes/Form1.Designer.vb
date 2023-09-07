<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        OFD_ = New OpenFileDialog()
        Panel1 = New Panel()
        Label1 = New Label()
        PNL_AreaCliente = New Panel()
        PNL_Transparente = New Panel()
        BTN_Cerrar = New Button()
        BTN_MinMax = New Button()
        BTN_Ocultar = New Button()
        PNL_AreaCliente.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.Location = New Point(6, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(144, 37)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Location = New Point(6, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 45)
        Label1.TabIndex = 1
        Label1.Text = "Abajo derecha si quieres cerrar" & vbCrLf & "En lo amarillo y transparente si quieres mover el formualrio" & vbCrLf & "A los laterales si quiereres rediensionar"
        ' 
        ' PNL_AreaCliente
        ' 
        PNL_AreaCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PNL_AreaCliente.BackColor = SystemColors.Control
        PNL_AreaCliente.BorderStyle = BorderStyle.FixedSingle
        PNL_AreaCliente.Controls.Add(PNL_Transparente)
        PNL_AreaCliente.Controls.Add(BTN_Cerrar)
        PNL_AreaCliente.Controls.Add(BTN_MinMax)
        PNL_AreaCliente.Controls.Add(BTN_Ocultar)
        PNL_AreaCliente.Controls.Add(Panel1)
        PNL_AreaCliente.Controls.Add(Label1)
        PNL_AreaCliente.Location = New Point(5, 5)
        PNL_AreaCliente.Margin = New Padding(0)
        PNL_AreaCliente.Name = "PNL_AreaCliente"
        PNL_AreaCliente.Size = New Size(390, 390)
        PNL_AreaCliente.TabIndex = 2
        ' 
        ' PNL_Transparente
        ' 
        PNL_Transparente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PNL_Transparente.BackColor = Color.Blue
        PNL_Transparente.BorderStyle = BorderStyle.FixedSingle
        PNL_Transparente.Location = New Point(6, 6)
        PNL_Transparente.Name = "PNL_Transparente"
        PNL_Transparente.Size = New Size(376, 49)
        PNL_Transparente.TabIndex = 5
        ' 
        ' BTN_Cerrar
        ' 
        BTN_Cerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BTN_Cerrar.BackColor = Color.Silver
        BTN_Cerrar.FlatAppearance.BorderSize = 0
        BTN_Cerrar.FlatStyle = FlatStyle.Flat
        BTN_Cerrar.Location = New Point(359, 359)
        BTN_Cerrar.Margin = New Padding(0)
        BTN_Cerrar.Name = "BTN_Cerrar"
        BTN_Cerrar.Size = New Size(23, 23)
        BTN_Cerrar.TabIndex = 4
        BTN_Cerrar.Text = "X"
        BTN_Cerrar.UseVisualStyleBackColor = False
        ' 
        ' BTN_MinMax
        ' 
        BTN_MinMax.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BTN_MinMax.BackColor = Color.Silver
        BTN_MinMax.FlatAppearance.BorderSize = 0
        BTN_MinMax.FlatStyle = FlatStyle.Flat
        BTN_MinMax.Location = New Point(335, 359)
        BTN_MinMax.Margin = New Padding(0)
        BTN_MinMax.Name = "BTN_MinMax"
        BTN_MinMax.Size = New Size(23, 23)
        BTN_MinMax.TabIndex = 3
        BTN_MinMax.Text = "■"
        BTN_MinMax.UseVisualStyleBackColor = False
        ' 
        ' BTN_Ocultar
        ' 
        BTN_Ocultar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BTN_Ocultar.BackColor = Color.Silver
        BTN_Ocultar.FlatAppearance.BorderSize = 0
        BTN_Ocultar.FlatStyle = FlatStyle.Flat
        BTN_Ocultar.Location = New Point(311, 359)
        BTN_Ocultar.Margin = New Padding(0)
        BTN_Ocultar.Name = "BTN_Ocultar"
        BTN_Ocultar.Size = New Size(23, 23)
        BTN_Ocultar.TabIndex = 2
        BTN_Ocultar.Text = "_"
        BTN_Ocultar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        ClientSize = New Size(400, 400)
        Controls.Add(PNL_AreaCliente)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "CGE"
        TransparencyKey = Color.Blue
        PNL_AreaCliente.ResumeLayout(False)
        PNL_AreaCliente.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents OFD_ As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PNL_AreaCliente As Panel
    Friend WithEvents BTN_Cerrar As Button
    Friend WithEvents BTN_MinMax As Button
    Friend WithEvents BTN_Ocultar As Button
    Friend WithEvents PNL_Transparente As Panel
End Class
