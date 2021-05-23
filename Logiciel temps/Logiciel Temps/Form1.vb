Imports System
Imports System.Globalization
Imports System.Threading

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New Object() {"Benoit Beauchemin", "NAme1", "NAme2"})
        ComboBox2.Items.AddRange(New Object() {"D", "GP", "ES"}) ' D = Dessin GP = Gestion Projet  ES = Estimation
        ComboBox3.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox4.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox5.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox6.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox7.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox8.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox9.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox10.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox11.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox12.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox13.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox14.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox15.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox16.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox17.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox18.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox19.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox20.Items.AddRange(New Object() {"D", "GP", "ES"})
        ComboBox21.Items.AddRange(New Object() {"D", "GP", "ES"})

        Dim semaine As Integer
        'Semaine
        semaine = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTimePicker1.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        semaine = semaine - 1
        Label58.Text = semaine

        'Jour en chiffre
        Label59.Text = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(DateTimePicker1.Text)
        If Label59.Text = 1 Then
            Label59.Text = "Lundi"
        ElseIf Label59.Text = 2 Then
            Label59.Text = "Mardi"
        ElseIf Label59.Text = 3 Then
            Label59.Text = "Mercredi"
        ElseIf Label59.Text = 4 Then
            Label59.Text = "Jeudi"
        ElseIf Label59.Text = 5 Then
            Label59.Text = "Vendredi"
        End If

        ComboBox1.Text = ""

        If ComboBox1.Text <> "" Then
            Button19.Enabled = True
        Else
            Button19.Enabled = False
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click ' Start
        Label7.Text = DateTime.Now.ToString
        Timer1.Start()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click ' Stop
        Label9.Text = DateTime.Now.ToString
        Timer1.Stop()
        Label4.Text = ""
        Label4.Text = Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox28.Text) + Val(TextBox29.Text) + Val(TextBox30.Text)

    End Sub

    '-------------------------

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick ' Timer
        Label13.Text = Val(Label13.Text) + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 1
        TextBox11.Text = Val(TextBox11.Text) + Val(Label13.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox12.Text = Val(Label13.Text) + Val(TextBox12.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' 2
        TextBox13.Text = Val(Label13.Text) + Val(TextBox13.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox14.Text = Val(Label13.Text) + Val(TextBox14.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' 3
        TextBox15.Text = Val(Label13.Text) + Val(TextBox15.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox16.Text = Val(Label13.Text) + Val(TextBox16.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click ' 4
        TextBox17.Text = Val(Label13.Text) + Val(TextBox17.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox18.Text = Val(Label13.Text) + Val(TextBox18.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click ' 5
        TextBox19.Text = Val(Label13.Text) + Val(TextBox19.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox20.Text = Val(Label13.Text) + Val(TextBox20.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click ' 6
        TextBox21.Text = Val(Label13.Text) + Val(TextBox21.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox22.Text = Val(Label13.Text) + Val(TextBox22.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click ' 7
        TextBox23.Text = Val(Label13.Text) + Val(TextBox23.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox24.Text = Val(Label13.Text) + Val(TextBox24.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click ' 8
        TextBox25.Text = Val(Label13.Text) + Val(TextBox25.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox26.Text = Val(Label13.Text) + Val(TextBox26.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click ' 9
        TextBox27.Text = Val(Label13.Text) + Val(TextBox27.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox28.Text = Val(Label13.Text) + Val(TextBox28.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click ' 10
        TextBox29.Text = Val(Label13.Text) + Val(TextBox29.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox30.Text = Val(Label13.Text) + Val(TextBox30.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click ' Midi
        TextBox32.Text = Val(Label13.Text) + Val(TextBox32.Text)
        Label13.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click ' Fermer
        Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click ' Envoyer
        Dim nom As String

        nom = ComboBox1.Text + " - " + DateTimePicker1.Text
        Dim ApExcel As Object

        ApExcel = CreateObject("Excel.application")
        ApExcel.Application.DisplayAlerts = False
        If ComboBox1.Text = "Benoit Beauchemin" Then
            ApExcel.Workbooks.open("C:\Users\XXXXXXXXX\VB.NET\Logiciel temps\FeuilleTemp1.xlsm")
        ElseIf ComboBox1.Text = "NAme1" Then
            ApExcel.Workbooks.open("C:\Users\XXXXXXXXX\VB.NET\Logiciel temps\FeuilleTemp2.xlsm")
        ElseIf ComboBox1.Text = "NAme2" Then
            ApExcel.Workbooks.open("C:\Users\XXXXXXXXX\VB.NET\Logiciel temps\FeuilleTemp3.xlsm")
        End If


        ApExcel.visible = True

        If Label59.Text = "Lundi" Then

            '1
            ApExcel.Sheets(Label58.Text).Cells(7, 1).Value = TextBox1.Text
            ApExcel.Sheets(Label58.Text).Cells(7, 6).Value = (Val(TextBox11.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(7, 5).Value = ComboBox2.Text

            ApExcel.Sheets(Label58.Text).Cells(8, 6).Value = (Val(TextBox12.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(8, 5).Value = ComboBox4.Text

            '2
            ApExcel.Sheets(Label58.Text).Cells(9, 1).Value = TextBox2.Text
            ApExcel.Sheets(Label58.Text).Cells(9, 6).Value = (Val(TextBox13.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(9, 5).Value = ComboBox6.Text

            ApExcel.Sheets(Label58.Text).Cells(10, 6).Value = (Val(TextBox14.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(10, 5).Value = ComboBox8.Text

            '3
            ApExcel.Sheets(Label58.Text).Cells(11, 1).Value = TextBox3.Text
            ApExcel.Sheets(Label58.Text).Cells(11, 6).Value = (Val(TextBox15.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(11, 5).Value = ComboBox10.Text

            ApExcel.Sheets(Label58.Text).Cells(12, 6).Value = (Val(TextBox16.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(12, 5).Value = ComboBox12.Text

            '4
            ApExcel.Sheets(Label58.Text).Cells(13, 1).Value = TextBox4.Text
            ApExcel.Sheets(Label58.Text).Cells(13, 6).Value = (Val(TextBox17.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(13, 5).Value = ComboBox14.Text

            ApExcel.Sheets(Label58.Text).Cells(14, 6).Value = (Val(TextBox18.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(14, 5).Value = ComboBox16.Text

            '5
            ApExcel.Sheets(Label58.Text).Cells(15, 1).Value = TextBox5.Text
            ApExcel.Sheets(Label58.Text).Cells(15, 6).Value = (Val(TextBox19.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(15, 5).Value = ComboBox18.Text

            ApExcel.Sheets(Label58.Text).Cells(16, 6).Value = (Val(TextBox20.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(16, 5).Value = ComboBox20.Text

            '6
            ApExcel.Sheets(Label58.Text).Cells(17, 1).Value = TextBox6.Text
            ApExcel.Sheets(Label58.Text).Cells(17, 6).Value = (Val(TextBox21.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(17, 5).Value = ComboBox3.Text

            ApExcel.Sheets(Label58.Text).Cells(18, 6).Value = (Val(TextBox22.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(18, 5).Value = ComboBox5.Text


            '7
            ApExcel.Sheets(Label58.Text).Cells(19, 1).Value = TextBox7.Text
            ApExcel.Sheets(Label58.Text).Cells(19, 6).Value = (Val(TextBox23.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(19, 5).Value = ComboBox7.Text

            ApExcel.Sheets(Label58.Text).Cells(20, 6).Value = (Val(TextBox24.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(20, 5).Value = ComboBox9.Text


            '8
            ApExcel.Sheets(Label58.Text).Cells(21, 1).Value = TextBox8.Text
            ApExcel.Sheets(Label58.Text).Cells(21, 6).Value = (Val(TextBox25.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(21, 5).Value = ComboBox11.Text

            ApExcel.Sheets(Label58.Text).Cells(22, 6).Value = (Val(TextBox26.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(22, 5).Value = ComboBox13.Text


            '9
            ApExcel.Sheets(Label58.Text).Cells(23, 1).Value = TextBox9.Text
            ApExcel.Sheets(Label58.Text).Cells(23, 6).Value = (Val(TextBox27.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(23, 5).Value = ComboBox15.Text

            ApExcel.Sheets(Label58.Text).Cells(24, 6).Value = (Val(TextBox28.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(24, 5).Value = ComboBox17.Text


            '10
            ApExcel.Sheets(Label58.Text).Cells(25, 1).Value = TextBox10.Text
            ApExcel.Sheets(Label58.Text).Cells(25, 6).Value = (Val(TextBox29.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(25, 5).Value = ComboBox19.Text

            ApExcel.Sheets(Label58.Text).Cells(26, 6).Value = (Val(TextBox30.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(26, 5).Value = ComboBox21.Text

        End If

        If Label59.Text = "Mardi" Then

            '1
            ApExcel.Sheets(Label58.Text).Cells(7, 1).Value = TextBox1.Text
            ApExcel.Sheets(Label58.Text).Cells(7, 8).Value = (Val(TextBox11.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(7, 7).Value = ComboBox2.Text

            ApExcel.Sheets(Label58.Text).Cells(8, 8).Value = (Val(TextBox12.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(8, 7).Value = ComboBox4.Text

            '2
            ApExcel.Sheets(Label58.Text).Cells(9, 1).Value = TextBox2.Text
            ApExcel.Sheets(Label58.Text).Cells(9, 8).Value = (Val(TextBox13.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(9, 7).Value = ComboBox6.Text

            ApExcel.Sheets(Label58.Text).Cells(10, 8).Value = (Val(TextBox14.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(10, 7).Value = ComboBox8.Text

            '3
            ApExcel.Sheets(Label58.Text).Cells(11, 1).Value = TextBox3.Text
            ApExcel.Sheets(Label58.Text).Cells(11, 8).Value = (Val(TextBox15.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(11, 7).Value = ComboBox10.Text

            ApExcel.Sheets(Label58.Text).Cells(12, 8).Value = (Val(TextBox16.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(12, 7).Value = ComboBox12.Text

            '4
            ApExcel.Sheets(Label58.Text).Cells(13, 1).Value = TextBox4.Text
            ApExcel.Sheets(Label58.Text).Cells(13, 8).Value = (Val(TextBox17.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(13, 7).Value = ComboBox14.Text

            ApExcel.Sheets(Label58.Text).Cells(14, 8).Value = (Val(TextBox18.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(14, 7).Value = ComboBox16.Text

            '5
            ApExcel.Sheets(Label58.Text).Cells(15, 1).Value = TextBox5.Text
            ApExcel.Sheets(Label58.Text).Cells(15, 8).Value = (Val(TextBox19.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(15, 7).Value = ComboBox18.Text

            ApExcel.Sheets(Label58.Text).Cells(16, 8).Value = (Val(TextBox20.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(16, 7).Value = ComboBox20.Text

            '6
            ApExcel.Sheets(Label58.Text).Cells(17, 1).Value = TextBox6.Text
            ApExcel.Sheets(Label58.Text).Cells(17, 8).Value = (Val(TextBox21.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(17, 7).Value = ComboBox3.Text

            ApExcel.Sheets(Label58.Text).Cells(18, 8).Value = (Val(TextBox22.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(18, 7).Value = ComboBox5.Text


            '7
            ApExcel.Sheets(Label58.Text).Cells(19, 1).Value = TextBox7.Text
            ApExcel.Sheets(Label58.Text).Cells(19, 8).Value = (Val(TextBox23.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(19, 7).Value = ComboBox7.Text

            ApExcel.Sheets(Label58.Text).Cells(20, 8).Value = (Val(TextBox24.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(20, 7).Value = ComboBox9.Text


            '8
            ApExcel.Sheets(Label58.Text).Cells(21, 1).Value = TextBox8.Text
            ApExcel.Sheets(Label58.Text).Cells(21, 8).Value = (Val(TextBox25.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(21, 7).Value = ComboBox11.Text

            ApExcel.Sheets(Label58.Text).Cells(22, 8).Value = (Val(TextBox26.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(22, 7).Value = ComboBox13.Text


            '9
            ApExcel.Sheets(Label58.Text).Cells(23, 1).Value = TextBox9.Text
            ApExcel.Sheets(Label58.Text).Cells(23, 8).Value = (Val(TextBox27.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(23, 7).Value = ComboBox15.Text

            ApExcel.Sheets(Label58.Text).Cells(24, 8).Value = (Val(TextBox28.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(24, 7).Value = ComboBox17.Text


            '10
            ApExcel.Sheets(Label58.Text).Cells(25, 1).Value = TextBox10.Text
            ApExcel.Sheets(Label58.Text).Cells(25, 8).Value = (Val(TextBox29.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(25, 7).Value = ComboBox19.Text

            ApExcel.Sheets(Label58.Text).Cells(26, 8).Value = (Val(TextBox30.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(26, 7).Value = ComboBox21.Text

        End If

        If Label59.Text = "Mercredi" Then

            '1
            ApExcel.Sheets(Label58.Text).Cells(7, 1).Value = TextBox1.Text
            ApExcel.Sheets(Label58.Text).Cells(7, 10).Value = (Val(TextBox11.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(7, 9).Value = ComboBox2.Text

            ApExcel.Sheets(Label58.Text).Cells(8, 10).Value = (Val(TextBox12.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(8, 9).Value = ComboBox4.Text

            '2
            ApExcel.Sheets(Label58.Text).Cells(9, 1).Value = TextBox2.Text
            ApExcel.Sheets(Label58.Text).Cells(9, 10).Value = (Val(TextBox13.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(9, 9).Value = ComboBox6.Text

            ApExcel.Sheets(Label58.Text).Cells(10, 10).Value = (Val(TextBox14.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(10, 9).Value = ComboBox8.Text

            '3
            ApExcel.Sheets(Label58.Text).Cells(11, 1).Value = TextBox3.Text
            ApExcel.Sheets(Label58.Text).Cells(11, 10).Value = (Val(TextBox15.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(11, 9).Value = ComboBox10.Text

            ApExcel.Sheets(Label58.Text).Cells(12, 10).Value = (Val(TextBox16.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(12, 9).Value = ComboBox12.Text

            '4
            ApExcel.Sheets(Label58.Text).Cells(13, 1).Value = TextBox4.Text
            ApExcel.Sheets(Label58.Text).Cells(13, 10).Value = (Val(TextBox17.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(13, 9).Value = ComboBox14.Text

            ApExcel.Sheets(Label58.Text).Cells(14, 10).Value = (Val(TextBox18.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(14, 9).Value = ComboBox16.Text

            '5
            ApExcel.Sheets(Label58.Text).Cells(15, 1).Value = TextBox5.Text
            ApExcel.Sheets(Label58.Text).Cells(15, 10).Value = (Val(TextBox19.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(15, 9).Value = ComboBox18.Text

            ApExcel.Sheets(Label58.Text).Cells(16, 10).Value = (Val(TextBox20.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(16, 9).Value = ComboBox20.Text

            '6
            ApExcel.Sheets(Label58.Text).Cells(17, 1).Value = TextBox6.Text
            ApExcel.Sheets(Label58.Text).Cells(17, 10).Value = (Val(TextBox21.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(17, 9).Value = ComboBox3.Text

            ApExcel.Sheets(Label58.Text).Cells(18, 10).Value = (Val(TextBox22.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(18, 9).Value = ComboBox5.Text


            '7
            ApExcel.Sheets(Label58.Text).Cells(19, 1).Value = TextBox7.Text
            ApExcel.Sheets(Label58.Text).Cells(19, 10).Value = (Val(TextBox23.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(19, 9).Value = ComboBox7.Text

            ApExcel.Sheets(Label58.Text).Cells(20, 10).Value = (Val(TextBox24.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(20, 9).Value = ComboBox9.Text


            '8
            ApExcel.Sheets(Label58.Text).Cells(21, 1).Value = TextBox8.Text
            ApExcel.Sheets(Label58.Text).Cells(21, 10).Value = (Val(TextBox25.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(21, 9).Value = ComboBox11.Text

            ApExcel.Sheets(Label58.Text).Cells(22, 10).Value = (Val(TextBox26.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(22, 9).Value = ComboBox13.Text


            '9
            ApExcel.Sheets(Label58.Text).Cells(23, 1).Value = TextBox9.Text
            ApExcel.Sheets(Label58.Text).Cells(23, 10).Value = (Val(TextBox27.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(23, 9).Value = ComboBox15.Text

            ApExcel.Sheets(Label58.Text).Cells(24, 10).Value = (Val(TextBox28.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(24, 9).Value = ComboBox17.Text


            '10
            ApExcel.Sheets(Label58.Text).Cells(25, 1).Value = TextBox10.Text
            ApExcel.Sheets(Label58.Text).Cells(25, 10).Value = (Val(TextBox29.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(25, 9).Value = ComboBox19.Text

            ApExcel.Sheets(Label58.Text).Cells(26, 10).Value = (Val(TextBox30.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(26, 9).Value = ComboBox21.Text

        End If

        If Label59.Text = "Jeudi" Then

            '1
            ApExcel.Sheets(Label58.Text).Cells(7, 1).Value = TextBox1.Text
            ApExcel.Sheets(Label58.Text).Cells(7, 12).Value = (Val(TextBox11.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(7, 11).Value = ComboBox2.Text

            ApExcel.Sheets(Label58.Text).Cells(8, 12).Value = (Val(TextBox12.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(8, 11).Value = ComboBox4.Text

            '2
            ApExcel.Sheets(Label58.Text).Cells(9, 1).Value = TextBox2.Text
            ApExcel.Sheets(Label58.Text).Cells(9, 12).Value = (Val(TextBox13.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(9, 11).Value = ComboBox6.Text

            ApExcel.Sheets(Label58.Text).Cells(10, 12).Value = (Val(TextBox14.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(10, 11).Value = ComboBox8.Text

            '3
            ApExcel.Sheets(Label58.Text).Cells(11, 1).Value = TextBox3.Text
            ApExcel.Sheets(Label58.Text).Cells(11, 12).Value = (Val(TextBox15.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(11, 11).Value = ComboBox10.Text

            ApExcel.Sheets(Label58.Text).Cells(12, 12).Value = (Val(TextBox16.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(12, 11).Value = ComboBox12.Text

            '4
            ApExcel.Sheets(Label58.Text).Cells(13, 1).Value = TextBox4.Text
            ApExcel.Sheets(Label58.Text).Cells(13, 12).Value = (Val(TextBox17.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(13, 11).Value = ComboBox14.Text

            ApExcel.Sheets(Label58.Text).Cells(14, 12).Value = (Val(TextBox18.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(14, 11).Value = ComboBox16.Text

            '5
            ApExcel.Sheets(Label58.Text).Cells(15, 1).Value = TextBox5.Text
            ApExcel.Sheets(Label58.Text).Cells(15, 12).Value = (Val(TextBox19.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(15, 11).Value = ComboBox18.Text

            ApExcel.Sheets(Label58.Text).Cells(16, 12).Value = (Val(TextBox20.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(16, 11).Value = ComboBox20.Text

            '6
            ApExcel.Sheets(Label58.Text).Cells(17, 1).Value = TextBox6.Text
            ApExcel.Sheets(Label58.Text).Cells(17, 12).Value = (Val(TextBox21.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(17, 11).Value = ComboBox3.Text

            ApExcel.Sheets(Label58.Text).Cells(18, 12).Value = (Val(TextBox22.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(18, 11).Value = ComboBox5.Text


            '7
            ApExcel.Sheets(Label58.Text).Cells(19, 1).Value = TextBox7.Text
            ApExcel.Sheets(Label58.Text).Cells(19, 12).Value = (Val(TextBox23.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(19, 11).Value = ComboBox7.Text

            ApExcel.Sheets(Label58.Text).Cells(20, 12).Value = (Val(TextBox24.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(20, 11).Value = ComboBox9.Text


            '8
            ApExcel.Sheets(Label58.Text).Cells(21, 1).Value = TextBox8.Text
            ApExcel.Sheets(Label58.Text).Cells(21, 12).Value = (Val(TextBox25.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(21, 11).Value = ComboBox11.Text

            ApExcel.Sheets(Label58.Text).Cells(22, 12).Value = (Val(TextBox26.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(22, 11).Value = ComboBox13.Text


            '9
            ApExcel.Sheets(Label58.Text).Cells(23, 1).Value = TextBox9.Text
            ApExcel.Sheets(Label58.Text).Cells(23, 12).Value = (Val(TextBox27.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(23, 11).Value = ComboBox15.Text

            ApExcel.Sheets(Label58.Text).Cells(24, 12).Value = (Val(TextBox28.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(24, 11).Value = ComboBox17.Text


            '10
            ApExcel.Sheets(Label58.Text).Cells(25, 1).Value = TextBox10.Text
            ApExcel.Sheets(Label58.Text).Cells(25, 12).Value = (Val(TextBox29.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(25, 11).Value = ComboBox19.Text

            ApExcel.Sheets(Label58.Text).Cells(26, 12).Value = (Val(TextBox30.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(26, 11).Value = ComboBox21.Text

        End If

        If Label59.Text = "Vendredi" Then

            '1
            ApExcel.Sheets(Label58.Text).Cells(7, 1).Value = TextBox1.Text
            ApExcel.Sheets(Label58.Text).Cells(7, 14).Value = (Val(TextBox11.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(7, 13).Value = ComboBox2.Text

            ApExcel.Sheets(Label58.Text).Cells(8, 14).Value = (Val(TextBox12.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(8, 13).Value = ComboBox4.Text

            '2
            ApExcel.Sheets(Label58.Text).Cells(9, 1).Value = TextBox2.Text
            ApExcel.Sheets(Label58.Text).Cells(9, 14).Value = (Val(TextBox13.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(9, 13).Value = ComboBox6.Text

            ApExcel.Sheets(Label58.Text).Cells(10, 14).Value = (Val(TextBox14.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(10, 13).Value = ComboBox8.Text

            '3
            ApExcel.Sheets(Label58.Text).Cells(11, 1).Value = TextBox3.Text
            ApExcel.Sheets(Label58.Text).Cells(11, 14).Value = (Val(TextBox15.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(11, 13).Value = ComboBox10.Text

            ApExcel.Sheets(Label58.Text).Cells(12, 14).Value = (Val(TextBox16.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(12, 13).Value = ComboBox12.Text

            '4
            ApExcel.Sheets(Label58.Text).Cells(13, 1).Value = TextBox4.Text
            ApExcel.Sheets(Label58.Text).Cells(13, 14).Value = (Val(TextBox17.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(13, 13).Value = ComboBox14.Text

            ApExcel.Sheets(Label58.Text).Cells(14, 14).Value = (Val(TextBox18.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(14, 13).Value = ComboBox16.Text

            '5
            ApExcel.Sheets(Label58.Text).Cells(15, 1).Value = TextBox5.Text
            ApExcel.Sheets(Label58.Text).Cells(15, 14).Value = (Val(TextBox19.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(15, 13).Value = ComboBox18.Text

            ApExcel.Sheets(Label58.Text).Cells(16, 14).Value = (Val(TextBox20.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(16, 13).Value = ComboBox20.Text

            '6
            ApExcel.Sheets(Label58.Text).Cells(17, 1).Value = TextBox6.Text
            ApExcel.Sheets(Label58.Text).Cells(17, 14).Value = (Val(TextBox21.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(17, 13).Value = ComboBox3.Text

            ApExcel.Sheets(Label58.Text).Cells(18, 14).Value = (Val(TextBox22.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(18, 13).Value = ComboBox5.Text


            '7
            ApExcel.Sheets(Label58.Text).Cells(19, 1).Value = TextBox7.Text
            ApExcel.Sheets(Label58.Text).Cells(19, 14).Value = (Val(TextBox23.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(19, 13).Value = ComboBox7.Text

            ApExcel.Sheets(Label58.Text).Cells(20, 14).Value = (Val(TextBox24.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(20, 13).Value = ComboBox9.Text


            '8
            ApExcel.Sheets(Label58.Text).Cells(21, 1).Value = TextBox8.Text
            ApExcel.Sheets(Label58.Text).Cells(21, 14).Value = (Val(TextBox25.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(21, 13).Value = ComboBox11.Text

            ApExcel.Sheets(Label58.Text).Cells(22, 14).Value = (Val(TextBox26.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(22, 13).Value = ComboBox13.Text


            '9
            ApExcel.Sheets(Label58.Text).Cells(23, 1).Value = TextBox9.Text
            ApExcel.Sheets(Label58.Text).Cells(23, 14).Value = (Val(TextBox27.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(23, 13).Value = ComboBox15.Text

            ApExcel.Sheets(Label58.Text).Cells(24, 14).Value = (Val(TextBox28.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(24, 13).Value = ComboBox17.Text


            '10
            ApExcel.Sheets(Label58.Text).Cells(25, 1).Value = TextBox10.Text
            ApExcel.Sheets(Label58.Text).Cells(25, 14).Value = (Val(TextBox29.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(25, 13).Value = ComboBox19.Text

            ApExcel.Sheets(Label58.Text).Cells(26, 14).Value = (Val(TextBox30.Text) / 60)
            ApExcel.Sheets(Label58.Text).Cells(26, 13).Value = ComboBox21.Text

        End If

        'ApExcel.ActiveWorkbook.SaveAs(Filename:="C:\Users\Utilisateur\Desktop\" & nom & ".xlsm")
        ApExcel.ActiveWorkbook.Save
        ApExcel.ActiveWorkbook.Close()
        ApExcel.quit()

        MsgBox("Votre Temps c'est bien envoyer !!! ")
    End Sub


    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        ComboBox2.Text = ""
        ComboBox4.Text = ""
        ComboBox6.Text = ""
        ComboBox8.Text = ""
        ComboBox10.Text = ""
        ComboBox12.Text = ""
        ComboBox14.Text = ""
        ComboBox16.Text = ""
        ComboBox18.Text = ""
        ComboBox20.Text = ""
        ComboBox3.Text = ""
        ComboBox5.Text = ""
        ComboBox7.Text = ""
        ComboBox9.Text = ""
        ComboBox11.Text = ""
        ComboBox13.Text = ""
        ComboBox15.Text = ""
        ComboBox17.Text = ""
        ComboBox19.Text = ""
        ComboBox21.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.Text <> "" Then
            Button19.Enabled = True
        Else
            Button19.Enabled = False
        End If
    End Sub

End Class