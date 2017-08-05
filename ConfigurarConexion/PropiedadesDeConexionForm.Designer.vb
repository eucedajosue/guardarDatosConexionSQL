<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropiedadesDeConexionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProbarConexionCMD = New System.Windows.Forms.Button()
        Me.PuertoTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TiempoEsperaTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BaseDatosTXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContrasenaTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsuarioTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServidorTXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuardarCMD = New System.Windows.Forms.Button()
        Me.CerrarCMD = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NombreAplicacionTXT = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ProbarConexionCMD)
        Me.GroupBox1.Controls.Add(Me.PuertoTXT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TiempoEsperaTXT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BaseDatosTXT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ContrasenaTXT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.UsuarioTXT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ServidorTXT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 237)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servidor SQL"
        '
        'ProbarConexionCMD
        '
        Me.ProbarConexionCMD.Location = New System.Drawing.Point(238, 192)
        Me.ProbarConexionCMD.Name = "ProbarConexionCMD"
        Me.ProbarConexionCMD.Size = New System.Drawing.Size(120, 23)
        Me.ProbarConexionCMD.TabIndex = 6
        Me.ProbarConexionCMD.Text = "Probar Conexión"
        Me.ProbarConexionCMD.UseVisualStyleBackColor = True
        '
        'PuertoTXT
        '
        Me.PuertoTXT.Location = New System.Drawing.Point(134, 166)
        Me.PuertoTXT.Name = "PuertoTXT"
        Me.PuertoTXT.Size = New System.Drawing.Size(224, 20)
        Me.PuertoTXT.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Puerto:"
        '
        'TiempoEsperaTXT
        '
        Me.TiempoEsperaTXT.Location = New System.Drawing.Point(134, 140)
        Me.TiempoEsperaTXT.Name = "TiempoEsperaTXT"
        Me.TiempoEsperaTXT.Size = New System.Drawing.Size(224, 20)
        Me.TiempoEsperaTXT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tiempo de espera:"
        '
        'BaseDatosTXT
        '
        Me.BaseDatosTXT.Location = New System.Drawing.Point(134, 114)
        Me.BaseDatosTXT.Name = "BaseDatosTXT"
        Me.BaseDatosTXT.Size = New System.Drawing.Size(224, 20)
        Me.BaseDatosTXT.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Base de datos:"
        '
        'ContrasenaTXT
        '
        Me.ContrasenaTXT.Location = New System.Drawing.Point(134, 88)
        Me.ContrasenaTXT.Name = "ContrasenaTXT"
        Me.ContrasenaTXT.Size = New System.Drawing.Size(224, 20)
        Me.ContrasenaTXT.TabIndex = 2
        Me.ContrasenaTXT.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contraseña:"
        '
        'UsuarioTXT
        '
        Me.UsuarioTXT.Location = New System.Drawing.Point(134, 62)
        Me.UsuarioTXT.Name = "UsuarioTXT"
        Me.UsuarioTXT.Size = New System.Drawing.Size(224, 20)
        Me.UsuarioTXT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario:"
        '
        'ServidorTXT
        '
        Me.ServidorTXT.Location = New System.Drawing.Point(134, 36)
        Me.ServidorTXT.Name = "ServidorTXT"
        Me.ServidorTXT.Size = New System.Drawing.Size(224, 20)
        Me.ServidorTXT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del servidor:"
        '
        'GuardarCMD
        '
        Me.GuardarCMD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuardarCMD.Location = New System.Drawing.Point(236, 290)
        Me.GuardarCMD.Name = "GuardarCMD"
        Me.GuardarCMD.Size = New System.Drawing.Size(75, 23)
        Me.GuardarCMD.TabIndex = 3
        Me.GuardarCMD.Text = "Guardar"
        Me.GuardarCMD.UseVisualStyleBackColor = True
        '
        'CerrarCMD
        '
        Me.CerrarCMD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CerrarCMD.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarCMD.Location = New System.Drawing.Point(317, 290)
        Me.CerrarCMD.Name = "CerrarCMD"
        Me.CerrarCMD.Size = New System.Drawing.Size(75, 23)
        Me.CerrarCMD.TabIndex = 4
        Me.CerrarCMD.Text = "Cerrar"
        Me.CerrarCMD.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre de la Aplicación:"
        '
        'NombreAplicacionTXT
        '
        Me.NombreAplicacionTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NombreAplicacionTXT.Location = New System.Drawing.Point(150, 15)
        Me.NombreAplicacionTXT.Name = "NombreAplicacionTXT"
        Me.NombreAplicacionTXT.ReadOnly = True
        Me.NombreAplicacionTXT.Size = New System.Drawing.Size(224, 13)
        Me.NombreAplicacionTXT.TabIndex = 0
        '
        'PropiedadesDeConexionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CerrarCMD
        Me.ClientSize = New System.Drawing.Size(412, 347)
        Me.Controls.Add(Me.CerrarCMD)
        Me.Controls.Add(Me.GuardarCMD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NombreAplicacionTXT)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PropiedadesDeConexionForm"
        Me.Text = "Propiedades de la conexión al servidor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProbarConexionCMD As Button
    Friend WithEvents PuertoTXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TiempoEsperaTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContrasenaTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UsuarioTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ServidorTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GuardarCMD As Button
    Friend WithEvents CerrarCMD As Button
    Friend WithEvents BaseDatosTXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NombreAplicacionTXT As TextBox
End Class
