Imports System.Data.SqlClient
Imports lastlogin
Public Class _Default
    Inherits Page
    Private db As New MSBUEntities

    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable
    Public Sql As String
    Public Sub ConnecDatabase()
        Try
            Conn = New SqlConnection
            Conn.ConnectionString = "DATA SOURCE=(DESKTOP-HMCU1O1);INITIAL CATALOG=MSBU;TRUSTED_CONNECTION=TRUE;INTEGRATED SECURITY=TRUE"
            Conn.Open()
        Catch ex As Exception
        End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        LoginSystem()
    End Sub
    Sub LoginSystem()

        If TxtUserID.Text = "" Then
            MsgBox("Username is Required!", MsgBoxStyle.Critical)
            TxtUserID.Focus()
        ElseIf TxtPassword.Text = "" Then
            MsgBox("Password is Required!", MsgBoxStyle.Critical)
            TxtPassword.Focus()
        Else
            Try
                ConnecDatabase()
                Sql = "Select * From [SIA].[dbo].[user] Where Username = @Username And Password = @Password;"
                cmd = New SqlCommand
                With cmd
                    .Connection = Conn
                    .CommandText = Sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Username", TxtUserID.Text)
                    .Parameters.AddWithValue("@Password", TxtPassword.Text)
                    .ExecuteNonQuery()
                End With
                da = New SqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    Dim Username, Password As String
                    Username = dt.Rows(0).Item("Username")
                    Password = dt.Rows(0).Item("Password")
                    If TxtUserID.Text = Username And TxtPassword.Text = Password Then
                        MsgBox("Welcome " & TxtUserID.Text)
                        TxtUserID.Text = ""
                        TxtPassword.Text = ""
                    ElseIf TxtUserID.Text <> Username Then
                        MsgBox("Username Doesn't Match!", MsgBoxStyle.Exclamation)
                        TxtUserID.Text = ""
                        TxtUserID.Focus()
                    ElseIf TxtPassword.Text <> Password Then
                        MsgBox("Password Doesn't Match!", MsgBoxStyle.Exclamation)
                        TxtPassword.Text = ""
                        TxtPassword.Focus()
                    Else
                        MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                        TxtPassword.Text = ""
                        TxtPassword.Focus()
                        TxtUserID.Text = ""
                        TxtPassword.Text = ""
                    End If
                End If
            End Try
        End If
    End Sub

End Class