Imports System.IO
Imports System.Text
Imports System.Net

Public Class Form3
    Declare Function GetPrivateProfileStringA Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Declare Function WritePrivateProfileStringA Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Dim IniFile As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Settings.ini"

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Decteccion()
    End Sub

    Private Sub LoyalButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton1.Click
        SaveSettings()
        Close()
    End Sub

#Region "Chatbot"

    Dim appath = Application.StartupPath.ToString

    Private Sub TextBoxTEXTO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxTEXTO.KeyDown
        If TextBoxTEXTO.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                RichTextBox1.SelectionColor = Color.Cyan
                RichTextBox1.AppendText("YO: " & TextBoxTEXTO.Text & vbCrLf)
                RESPUESTAS(TextBoxTEXTO.Text)
                RichTextBox1.ScrollToCaret()
                TextBoxTEXTO.Clear()
            End If
        End If
    End Sub

    Public Sub RESPUESTAS(ByVal CLAVE As String)
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\DATOS.txt", BaseDatos.Text, True)
            If CLAVE.ToLower.Contains("eres") Then
                RichTextBox1.SelectionColor = Color.Yellow
                RichTextBox1.AppendText("BOT: " & "SOLO SOY UN PROGRAMA" & vbCrLf)
                RichTextBox1.ScrollToCaret()
            ElseIf CLAVE.ToLower.Contains("me duele") Then
                RichTextBox1.SelectionColor = Color.Yellow
                RichTextBox1.AppendText("BOT: " & "QUIZA DEBERIAS IR AL MEDICO" & vbCrLf)
                RichTextBox1.ScrollToCaret()
            Else
                Dim ENCONTRADO As Boolean = False
                Dim BASE As String = Application.StartupPath & "\DATOS.txt"
                For Each LINEA In File.ReadLines(BASE, Encoding.UTF7)
                    Dim DATOS As String() = LINEA.Split(":")
                    If CLAVE.ToLower.Contains(DATOS(0)) Then
                        RichTextBox1.SelectionColor = Color.Yellow
                        RichTextBox1.AppendText("BOT: " & DATOS(1) & vbCrLf)
                        RichTextBox1.ScrollToCaret()
                        ENCONTRADO = True
                        Exit For
                    End If
                Next
                If ENCONTRADO = False Then
                    RichTextBox1.SelectionColor = Color.Yellow
                    RichTextBox1.AppendText(("BOT: No se Encontro en la Base de Datos" & vbCrLf))
                    RichTextBox1.ScrollToCaret()
                End If
            End If
        Catch ex As Exception
            MsgBox(" PorFavor Descargar Base De Datos")
        End Try
    End Sub

#End Region

#Region "Actualizacion"

    Dim cliente As New WebClient

    Dim URL As String = cliente.DownloadString("https://pastebin.com/raw/UhexD3DY")

    Private Sub Decteccion()
        LoadSettings()
        If (BaseDatos.Text.Trim = "") = False Then
            Label3.ForeColor = Color.Green
            Label3.Text = "Status : Si Posees Base de Datos"
            LoyalButton2.Visible = True
        Else
            Label3.ForeColor = Color.Red
            Label3.Text = "Status : No Posees Base de Datos"
            LoyalButton3.Visible = True
        End If
    End Sub
    Private Sub Actualizer()
        Try
            If (URL = BaseDatos.Text) = False Then
                Label3.ForeColor = Color.Red
                Label3.Text = "Status : Base de Datos Desactualizada"
                LoyalButton3.Visible = True
                LoyalButton2.Visible = False
            Else
                Label3.ForeColor = Color.Green
                Label3.Text = "Status : Base de Datos Actualizada"
                LoyalButton2.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Descarga()
        Try
            Dim URL As String = cliente.DownloadString("https://pastebin.com/raw/UhexD3DY")
            BaseDatos.Text = URL
            SaveSettings()
            Label3.ForeColor = Color.Green
            Label3.Text = "Status : Base de Datos Actualizada"
            LoyalButton3.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoyalButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton2.Click
        Actualizer()
    End Sub

    Private Sub LoyalButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton3.Click
        Descarga()
    End Sub

    Function ReadIni(ByVal Section As String, ByVal Key As String, Optional ByVal DefaultValue As String = Nothing) As String
        Dim buffer As New System.Text.StringBuilder(260)
        GetPrivateProfileStringA(Section, Key, DefaultValue, buffer, buffer.Capacity, IniFile)
        Return buffer.ToString
    End Function

    Function WriteIni(ByVal Section As String, ByVal Key As String, ByVal Value As String) As Boolean
        Return (WritePrivateProfileStringA(Section, Key, Value, IniFile) <> 0)
    End Function

    Sub SaveSettings()
        WriteIni("Settings", "Base de datos", BaseDatos.Text)
    End Sub

    Sub LoadSettings()
        BaseDatos.Text = ReadIni("Settings", "Base de datos", Nothing)
    End Sub

    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

#End Region

    
End Class