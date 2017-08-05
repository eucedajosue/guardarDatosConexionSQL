Public Class PropiedadesDeConexionForm
    Private criptografia As New Criptografia.Criptografia
    Dim nombreAplicacion As String

    Private Sub CerrarCMD_Click(sender As Object, e As EventArgs) Handles CerrarCMD.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub PropiedadesDeConexionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar_datos_del_form()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub cargar_datos_del_form()
        mostrar_nombre_aplicacion()
        mostrar_datos_guardados()
    End Sub

    Private Sub mostrar_datos_guardados()
        ServidorTXT.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("Servidor")
        UsuarioTXT.Text = criptografia.desencriptar(My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("Usuario"))
        ContrasenaTXT.Text = criptografia.desencriptar(My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("Contrasena"))
        BaseDatosTXT.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("BaseDatos")
        TiempoEsperaTXT.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("TiempoEspera")
        PuertoTXT.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(nombreAplicacion).GetValue("Puerto")
    End Sub

    Private Sub mostrar_nombre_aplicacion()
        NombreAplicacionTXT.Text = My.Settings.NombreAplicacion
        nombreAplicacion = My.Settings.NombreAplicacion
    End Sub

    Private Sub GuardarCMD_Click(sender As Object, e As EventArgs) Handles GuardarCMD.Click
        Try
            guardar_datos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub guardar_datos()
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("Servidor", ServidorTXT.Text)
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("Usuario", criptografia.encriptar(UsuarioTXT.Text))
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("Contrasena", criptografia.encriptar(ContrasenaTXT.Text))
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("BaseDatos", BaseDatosTXT.Text)
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("TiempoEspera", TiempoEsperaTXT.Text)
        My.Computer.Registry.CurrentUser.CreateSubKey("Software").CreateSubKey(nombreAplicacion).SetValue("Puerto", PuertoTXT.Text)
    End Sub
End Class
