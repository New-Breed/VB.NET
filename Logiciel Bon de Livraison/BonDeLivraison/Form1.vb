Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table '_Soudexmetal_2009DataSet11._T_CIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.T_CIETableAdapter.Fill(Me._Soudexmetal_2009DataSet11._T_CIE)

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        ComboBox1.Items.AddRange(New Object() {"Name...", "Name...", "Benoit Beauchemin", "Name...", "Name..."})

        ComboBox3.Items.AddRange(New Object() {"Soudex Métal", "Par le Client"})
        ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ComboBox4.Text = "1"
        ComboBox5.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ComboBox5.Text = "1"
        ComboBox6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox6.Text = "0"
        ComboBox7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox9.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox10.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox11.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox12.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox13.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox14.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        ComboBox15.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})

        ComboBox1.Text = ""
        TextBox6.Text = ""
        If ComboBox1.Text <> "" And TextBox6.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If ComboBox1.Text <> "" And TextBox6.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom, nomfull As String
        Dim ApExcel As Object

        nom = TextBox6.Text
        nom = nom.Replace("219", "419")
        nom = nom.Replace("220", "420")
        nom = nom.Replace("221", "421")
        nom = nom.Replace("222", "422")

        nomfull = nom + " - " + DateTimePicker1.Text

        ApExcel = CreateObject("Excel.application")
        ApExcel.Application.DisplayAlerts = False

        ApExcel.Workbooks.open("C:\Users\XXXXXXXXX\VB.NET\Logiciel Bon de Livraison\BON DE LIVRAISON.xlsx")

        ApExcel.visible = True

        ApExcel.Sheets(1).Cells(6, 5).Value = nom
        'Info
        ApExcel.Sheets(1).Cells(18, 1).Value = ComboBox1.Text
        ApExcel.Sheets(1).Cells(18, 7).Value = DateTimePicker1.Text
        ApExcel.Sheets(1).Cells(18, 4).Value = TextBox6.Text
        ApExcel.Sheets(1).Cells(18, 3).Value = TextBox5.Text
        ApExcel.Sheets(1).Cells(18, 2).Value = TextBox4.Text
        ApExcel.Sheets(1).Cells(18, 5).Value = ComboBox3.Text

        'Client
        ApExcel.Sheets(1).Cells(8, 2).Value = TextBox1.Text
        ApExcel.Sheets(1).Cells(11, 2).Value = TextBox2.Text
        ApExcel.Sheets(1).Cells(12, 2).Value = TextBox3.Text
        'Endroit Livraison
        ApExcel.Sheets(1).Cells(8, 5).Value = TextBox15.Text
        ApExcel.Sheets(1).Cells(9, 5).Value = TextBox12.Text
        ApExcel.Sheets(1).Cells(10, 5).Value = TextBox16.Text
        ApExcel.Sheets(1).Cells(11, 5).Value = TextBox2.Text
        ApExcel.Sheets(1).Cells(12, 5).Value = TextBox14.Text

        '#1
        ApExcel.Sheets(1).Cells(22, 1).Value = ComboBox4.Text
        ApExcel.Sheets(1).Cells(22, 2).Value = TextBox8.Text
        ApExcel.Sheets(1).Cells(22, 5).Value = ComboBox5.Text
        ApExcel.Sheets(1).Cells(22, 7).Value = ComboBox6.Text
        '#2
        ApExcel.Sheets(1).Cells(24, 1).Value = ComboBox9.Text
        ApExcel.Sheets(1).Cells(24, 2).Value = TextBox7.Text
        ApExcel.Sheets(1).Cells(24, 5).Value = ComboBox8.Text
        ApExcel.Sheets(1).Cells(24, 7).Value = ComboBox7.Text
        '#3
        ApExcel.Sheets(1).Cells(26, 1).Value = ComboBox12.Text
        ApExcel.Sheets(1).Cells(26, 2).Value = TextBox9.Text
        ApExcel.Sheets(1).Cells(26, 5).Value = ComboBox11.Text
        ApExcel.Sheets(1).Cells(26, 7).Value = ComboBox10.Text
        '#4
        ApExcel.Sheets(1).Cells(28, 1).Value = ComboBox15.Text
        ApExcel.Sheets(1).Cells(28, 2).Value = TextBox10.Text
        ApExcel.Sheets(1).Cells(28, 5).Value = ComboBox14.Text
        ApExcel.Sheets(1).Cells(28, 7).Value = ComboBox13.Text


        ApExcel.ActiveWorkbook.SaveAs(Filename:="C:\Users\XXXXXXXXX\VB.NET\Logiciel Bon de Livraison\" & nomfull & ".xlsx")
        ApExcel.ActiveWorkbook.Close()
        ApExcel.quit()

        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TCIEBindingSource.Filter = "Cie like '" & TextBox11.Text & "*'"
    End Sub
End Class

