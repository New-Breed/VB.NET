Imports System
Imports System.Globalization
Imports System.Threading

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New Object() {"Benoit Beauchemin", "Name...", "Name..."})

        ComboBox2.Items.AddRange(New Object() {"À FAIRE", ""})
        ComboBox3.Items.AddRange(New Object() {"À FAIRE", ""})
        ComboBox4.Items.AddRange(New Object() {"À FAIRE", ""})
        ComboBox5.Items.AddRange(New Object() {"À FAIRE", ""})

        ComboBox6.Items.AddRange(New Object() {"TOUT FAIRE", "PLANS FOURNIS", "SEULEMENT CEUX DES PLANS ", "# ", ""})
        ComboBox7.Items.AddRange(New Object() {"TOUT FAIRE", "PLANS FOURNIS", "SEULEMENT CEUX DES PLANS ", "# ", ""})
        ComboBox8.Items.AddRange(New Object() {"TOUT FAIRE", "PLANS FOURNIS", "SEULEMENT CEUX DES PLANS ", "# ", ""})
        ComboBox9.Items.AddRange(New Object() {"TOUT FAIRE", "PLANS FOURNIS", "# ", ""})


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom As String

        nom = TextBox1.Text + " - " + DateTimePicker1.Text
        Dim ApExcel As Object

        ApExcel = CreateObject("Excel.application")
        ApExcel.Application.DisplayAlerts = False
        ApExcel.Workbooks.open("C:\Users\XXXXXXX\VB.NET\Logiciel Projet Plancher\VIE.xlsx")

        ApExcel.visible = True


        ApExcel.Sheets(1).Cells(4, 7).Value = TextBox1.Text
        ApExcel.Sheets(1).Cells(6, 6).Value = TextBox6.Text
        ApExcel.Sheets(1).Cells(9, 6).Value = ComboBox1.Text
        ApExcel.Sheets(1).Cells(8, 6).Value = DateTimePicker1.Text
        ApExcel.Sheets(1).Cells(8, 8).Value = DateTimePicker2.Text


        ApExcel.Sheets(1).Cells(12, 6).Value = ComboBox2.Text
        ApExcel.Sheets(1).Cells(13, 6).Value = ComboBox6.Text
        ApExcel.Sheets(1).Cells(14, 7).Value = TextBox3.Text
        ApExcel.Sheets(1).Cells(15, 7).Value = TextBox7.Text
        If ComboBox2.Text <> "" Then
            ApExcel.Sheets(1).Cells(12, 5).Interior.ColorIndex = 1
        End If



        ApExcel.Sheets(1).Cells(23, 6).Value = ComboBox3.Text
        ApExcel.Sheets(1).Cells(24, 6).Value = ComboBox7.Text
        ApExcel.Sheets(1).Cells(25, 7).Value = TextBox2.Text
        ApExcel.Sheets(1).Cells(26, 7).Value = TextBox8.Text
        ApExcel.Sheets(1).Cells(25, 6).Value = TextBox41.Text
        If ComboBox3.Text <> "" Then
            ApExcel.Sheets(1).Cells(23, 5).Interior.ColorIndex = 1
        End If


        ApExcel.Sheets(1).Cells(34, 6).Value = ComboBox4.Text
        ApExcel.Sheets(1).Cells(35, 6).Value = ComboBox8.Text
        ApExcel.Sheets(1).Cells(36, 7).Value = TextBox4.Text
        ApExcel.Sheets(1).Cells(37, 7).Value = TextBox9.Text
        ApExcel.Sheets(1).Cells(36, 6).Value = TextBox48.Text
        If ComboBox4.Text <> "" Then
            ApExcel.Sheets(1).Cells(34, 5).Interior.ColorIndex = 1
        End If


        ApExcel.Sheets(1).Cells(45, 6).Value = ComboBox5.Text
        ApExcel.Sheets(1).Cells(46, 6).Value = ComboBox9.Text
        ApExcel.Sheets(1).Cells(47, 7).Value = TextBox5.Text
        ApExcel.Sheets(1).Cells(48, 7).Value = TextBox10.Text
        ApExcel.Sheets(1).Cells(47, 6).Value = TextBox55.Text
        If ComboBox5.Text <> "" Then
            ApExcel.Sheets(1).Cells(45, 5).Interior.ColorIndex = 1
        End If

        If CheckBox1.Checked = True Then
            ApExcel.Sheets(1).Cells(50, 4).Interior.ColorIndex = 1
            ApExcel.Sheets(1).Cells(50, 5).value = "OUI"
        End If

        ApExcel.ActiveWorkbook.SaveAs(Filename:="C:\Users\XXXXXXX\VB.NET\Logiciel Projet Plancher\" & nom & ".xlsx")
        ApExcel.ActiveWorkbook.Close()
        ApExcel.quit()

        Close()
    End Sub

End Class
