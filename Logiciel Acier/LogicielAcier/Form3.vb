Imports System.Data
Imports System.Data.SqlClient
Public Class Form3
    Dim connec As New OleDb.OleDbConnection
    Dim ajout As New OleDb.OleDbCommand
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'connec.Close()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sql = "Insert Into Acier values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "')"
        Try
            ajout.Connection = connec
            ajout.CommandType = CommandType.Text
            ajout.CommandText = sql
            ajout.ExecuteNonQuery()
            MsgBox("Résultat enregistré",, "Approuver")
            Button3.PerformClick()
        Catch
            MsgBox("Vérifier votre Sélection (Peut-être en double) ")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "1"
        Button3.PerformClick()
        connec.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\XXXXXXX\VB.NET\Logiciel Acier\Acier.accdb"
        connec.Open()
        Label14.Text = "Base de données OK"
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If

    End Sub

End Class