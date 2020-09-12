Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration

Module Conexion

    Public strConexion As String = "Data Source=" & ConfigurationManager.AppSettings("servidorX") & ";Database=" & ConfigurationManager.AppSettings("baseX") & ";Uid=" & ConfigurationManager.AppSettings("usuarioX") & ";Pwd=" & ConfigurationManager.AppSettings("claveX") & ";"

End Module
