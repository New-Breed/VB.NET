Imports System.Data
Imports System.Data.SqlClient

Public Class Form1 ''
    Dim connec As New OleDb.OleDbConnection
    Dim ajout As New OleDb.OleDbCommand
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'AcierDataSet.Acier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.AcierTableAdapter.Fill(Me.AcierDataSet.Acier)
        connec.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\XXXXXXX\VB.NET\Logiciel Acier\Acier.accdb"
        connec.Open()
        Button3.PerformClick()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        AcierBindingSource2.Filter = "Nom like '" & TextBox1.Text & "*'"
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AcierBindingSource2.Filter = "Nom like '" & TextBox1.Text & "*'"

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim code As String
        code = InputBox(" Votre Code : ", "Code")

        If code = "321" Then
            'DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            sql = " delete * from Acier WHERE Nom= ('" & TextBox2.Text & "')"

            ajout.Connection = connec
            ajout.CommandType = CommandType.Text
            ajout.CommandText = sql
            ajout.ExecuteNonQuery()
            MsgBox("Objet Sélection Supprimer",, "Supprimer")


        Else
            MsgBox("Code invalide", MsgBoxStyle.Critical)
        End If

        TextBox2.Text = ""

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim code As String
        code = InputBox(" Votre Code : ", "Code")

        If code = "123" Then

            sql = "UPDATE Acier Set Prix= '" & TextBox4.Text & "', DatePrix= '" & DateTimePicker1.Text & "' WHERE Nom ='" & TextBox3.Text & "' "

            ajout.Connection = connec
            ajout.CommandType = CommandType.Text
            ajout.CommandText = sql
            ajout.ExecuteNonQuery()
            MsgBox("Prix Enregistrer",, "Enregister")


        Else
            MsgBox("Code invalide", MsgBoxStyle.Critical)
        End If

        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox4.TextChanged
        If TextBox3.Text <> "" Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If
    End Sub
End Class