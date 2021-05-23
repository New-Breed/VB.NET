Imports System.Net.Mail

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table '_Soudexmetal_2009DataSet._T_CIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.T_CIETableAdapter.Fill(Me._Soudexmetal_2009DataSet._T_CIE)

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        'Item Top
        ComboBox5.Items.AddRange(New Object() {"Achat", "Soumission"})
        ComboBox78.Items.AddRange(New Object() {"Benoit Beauchemin", "Name...", "Name...", "Name...", "Name..."})
        ComboBox4.Items.AddRange(New Object() {"Soudex Métal", "Vous"})
        '#1
        ComboBox1.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox2.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox6.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox7.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#2
        ComboBox8.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox11.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox12.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox10.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox9.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#3
        ComboBox13.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox16.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox17.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox15.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox14.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#4
        ComboBox18.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox21.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox22.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox20.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox19.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#5
        ComboBox23.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox26.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox27.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox25.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox24.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#6
        ComboBox28.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox31.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox32.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox30.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox29.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#7
        ComboBox33.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox36.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox37.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox35.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox34.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#8
        ComboBox38.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox41.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox42.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox40.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox39.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#9
        ComboBox43.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox46.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox47.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox45.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox44.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#10
        ComboBox48.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox51.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox52.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox50.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox49.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#11
        ComboBox53.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox56.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox57.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox55.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox54.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#12
        ComboBox58.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox61.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox62.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox60.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox59.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#13
        ComboBox63.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox66.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox67.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox65.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox64.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#14
        ComboBox68.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox71.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox72.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox70.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox69.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})
        '#15
        ComboBox73.Items.AddRange(New Object() {"5'X 10'", "20'"})
        ComboBox76.Items.AddRange(New Object() {"Tôleries", "Matériaux", "Quincailleries", "Articles de Bureau", "Outils"})
        ComboBox77.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox75.Items.AddRange(New Object() {"Plaque 1/4 ", "Sheet 10 Ga ", "HSS Carré 2x2x1/4 ", "Checker Plate 1/8 ", "L 2x2x1/4 ", "W 6x6x20 ", "C 3x1.41x4.1 ", "Vis ", "Boulons ", "Paquets de Papier "})
        ComboBox74.Items.AddRange(New Object() {"Acier", "Aluminium", "Stainless", "Galvanisé"})

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' Recherche
        TCIEBindingSource.Filter = "Cie like '" & TextBox1.Text & "*'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' ENVOYER résultat par mail et dans base de données
        Dim nom As String
        Dim numBonLiv As String

        Dim ApExcel As Object

        ApExcel = CreateObject("Excel.application")
        ApExcel.Application.DisplayAlerts = False

        ApExcel.Workbooks.open("C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\ACHAT.xlsx")
        ApExcel.visible = True

        'Fournisseur
        ApExcel.Sheets(1).Cells(10, 3).Value = TextBox3.Text
        ApExcel.Sheets(1).Cells(11, 3).Value = TextBox4.Text
        ApExcel.Sheets(1).Cells(12, 3).Value = TextBox5.Text
        ApExcel.Sheets(1).Cells(13, 3).Value = TextBox8.Text
        ApExcel.Sheets(1).Cells(14, 3).Value = TextBox9.Text

        ' Entête
        ApExcel.Sheets(1).Cells(11, 7).Value = DateTimePicker2.Text
        ApExcel.Sheets(1).Cells(14, 7).Value = DateTimePicker1.Text
        ApExcel.Sheets(1).Cells(2, 6).Value = ComboBox5.Text
        ApExcel.Sheets(1).Cells(9, 7).Value = ComboBox78.Text
        ApExcel.Sheets(1).Cells(19, 2).Value = TextBox2.Text
        ApExcel.Sheets(1).Cells(20, 2).Value = TextBox10.Text
        ApExcel.Sheets(1).Cells(19, 7).Value = TextBox11.Text

        ApExcel.Sheets(1).Cells(21, 7).Value = ComboBox4.Text


        'If TextBox11.Text = "221" Then
        numBonLiv = TextBox11.Text
        numBonLiv = numBonLiv.Replace("221", "321")

        ApExcel.Sheets(1).Cells(16, 7).Value = numBonLiv
        'End If

        nom = numBonLiv + " - " + DateTimePicker2.Text

        'item1
        ApExcel.Sheets(1).Cells(25, 2).Value = ComboBox2.Text
        ApExcel.Sheets(1).Cells(25, 3).Value = ComboBox6.Text
        ApExcel.Sheets(1).Cells(25, 6).Value = ComboBox1.Text
        ApExcel.Sheets(1).Cells(25, 7).Value = ComboBox7.Text
        ApExcel.Sheets(1).Cells(25, 9).Value = ComboBox3.Text

        'item2
        ApExcel.Sheets(1).Cells(26, 2).Value = ComboBox11.Text
        ApExcel.Sheets(1).Cells(26, 3).Value = ComboBox10.Text
        ApExcel.Sheets(1).Cells(26, 6).Value = ComboBox8.Text
        ApExcel.Sheets(1).Cells(26, 7).Value = ComboBox9.Text
        ApExcel.Sheets(1).Cells(26, 9).Value = ComboBox12.Text

        'item3
        ApExcel.Sheets(1).Cells(27, 2).Value = ComboBox16.Text
        ApExcel.Sheets(1).Cells(27, 3).Value = ComboBox15.Text
        ApExcel.Sheets(1).Cells(27, 6).Value = ComboBox13.Text
        ApExcel.Sheets(1).Cells(27, 7).Value = ComboBox14.Text
        ApExcel.Sheets(1).Cells(27, 9).Value = ComboBox17.Text

        'item4
        ApExcel.Sheets(1).Cells(28, 2).Value = ComboBox21.Text
        ApExcel.Sheets(1).Cells(28, 3).Value = ComboBox20.Text
        ApExcel.Sheets(1).Cells(28, 6).Value = ComboBox18.Text
        ApExcel.Sheets(1).Cells(28, 7).Value = ComboBox19.Text
        ApExcel.Sheets(1).Cells(28, 9).Value = ComboBox22.Text

        'item5
        ApExcel.Sheets(1).Cells(29, 2).Value = ComboBox26.Text
        ApExcel.Sheets(1).Cells(29, 3).Value = ComboBox25.Text
        ApExcel.Sheets(1).Cells(29, 6).Value = ComboBox23.Text
        ApExcel.Sheets(1).Cells(29, 7).Value = ComboBox24.Text
        ApExcel.Sheets(1).Cells(29, 9).Value = ComboBox27.Text

        'item6
        ApExcel.Sheets(1).Cells(30, 2).Value = ComboBox31.Text
        ApExcel.Sheets(1).Cells(30, 3).Value = ComboBox30.Text
        ApExcel.Sheets(1).Cells(30, 6).Value = ComboBox28.Text
        ApExcel.Sheets(1).Cells(30, 7).Value = ComboBox29.Text
        ApExcel.Sheets(1).Cells(30, 9).Value = ComboBox32.Text

        'item7
        ApExcel.Sheets(1).Cells(31, 2).Value = ComboBox36.Text
        ApExcel.Sheets(1).Cells(31, 3).Value = ComboBox35.Text
        ApExcel.Sheets(1).Cells(31, 6).Value = ComboBox33.Text
        ApExcel.Sheets(1).Cells(31, 7).Value = ComboBox34.Text
        ApExcel.Sheets(1).Cells(31, 9).Value = ComboBox37.Text

        'item8
        ApExcel.Sheets(1).Cells(32, 2).Value = ComboBox41.Text
        ApExcel.Sheets(1).Cells(32, 3).Value = ComboBox40.Text
        ApExcel.Sheets(1).Cells(32, 6).Value = ComboBox38.Text
        ApExcel.Sheets(1).Cells(32, 7).Value = ComboBox39.Text
        ApExcel.Sheets(1).Cells(32, 9).Value = ComboBox42.Text

        'item9
        ApExcel.Sheets(1).Cells(33, 2).Value = ComboBox46.Text
        ApExcel.Sheets(1).Cells(33, 3).Value = ComboBox45.Text
        ApExcel.Sheets(1).Cells(33, 6).Value = ComboBox43.Text
        ApExcel.Sheets(1).Cells(33, 7).Value = ComboBox44.Text
        ApExcel.Sheets(1).Cells(33, 9).Value = ComboBox47.Text

        'item10
        ApExcel.Sheets(1).Cells(34, 2).Value = ComboBox51.Text
        ApExcel.Sheets(1).Cells(34, 3).Value = ComboBox50.Text
        ApExcel.Sheets(1).Cells(34, 6).Value = ComboBox48.Text
        ApExcel.Sheets(1).Cells(34, 7).Value = ComboBox49.Text
        ApExcel.Sheets(1).Cells(34, 9).Value = ComboBox52.Text

        'item11
        ApExcel.Sheets(1).Cells(35, 2).Value = ComboBox56.Text
        ApExcel.Sheets(1).Cells(35, 3).Value = ComboBox55.Text
        ApExcel.Sheets(1).Cells(35, 6).Value = ComboBox53.Text
        ApExcel.Sheets(1).Cells(35, 7).Value = ComboBox54.Text
        ApExcel.Sheets(1).Cells(35, 9).Value = ComboBox57.Text

        'item12
        ApExcel.Sheets(1).Cells(36, 2).Value = ComboBox61.Text
        ApExcel.Sheets(1).Cells(36, 3).Value = ComboBox60.Text
        ApExcel.Sheets(1).Cells(36, 6).Value = ComboBox58.Text
        ApExcel.Sheets(1).Cells(36, 7).Value = ComboBox59.Text
        ApExcel.Sheets(1).Cells(36, 9).Value = ComboBox62.Text

        'item13
        ApExcel.Sheets(1).Cells(37, 2).Value = ComboBox66.Text
        ApExcel.Sheets(1).Cells(37, 3).Value = ComboBox65.Text
        ApExcel.Sheets(1).Cells(37, 6).Value = ComboBox63.Text
        ApExcel.Sheets(1).Cells(37, 7).Value = ComboBox64.Text
        ApExcel.Sheets(1).Cells(37, 9).Value = ComboBox67.Text

        'item14
        ApExcel.Sheets(1).Cells(38, 2).Value = ComboBox71.Text
        ApExcel.Sheets(1).Cells(38, 3).Value = ComboBox70.Text
        ApExcel.Sheets(1).Cells(38, 6).Value = ComboBox68.Text
        ApExcel.Sheets(1).Cells(38, 7).Value = ComboBox69.Text
        ApExcel.Sheets(1).Cells(38, 9).Value = ComboBox72.Text

        'item15
        ApExcel.Sheets(1).Cells(39, 2).Value = ComboBox76.Text
        ApExcel.Sheets(1).Cells(39, 3).Value = ComboBox75.Text
        ApExcel.Sheets(1).Cells(39, 6).Value = ComboBox73.Text
        ApExcel.Sheets(1).Cells(39, 7).Value = ComboBox74.Text
        ApExcel.Sheets(1).Cells(39, 9).Value = ComboBox77.Text


        ApExcel.ActiveWorkbook.SaveAs(Filename:="C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\" & nom & ".xlsx")
        ApExcel.ActiveWorkbook.Close()
        ApExcel.quit()

        ' Base de donnée ----------


        Dim un, deux, trois, quatre, cinq, six, sept, huit, neuf, dix, once, douze, treize, quatorz, quinze As Double
        Dim itemun, itemdeux, itemtrois, itemquatre, itemcinq, itemsix, itemsept, itemhuit, itemneuf, itemdix, itemonce, itemdouze, itemtreize, itemquatorz, itemquinze As String



        itemun = ComboBox6.Text
        itemdeux = ComboBox10.Text
        itemtrois = ComboBox15.Text
        itemquatre = ComboBox20.Text
        itemcinq = ComboBox25.Text
        itemsix = ComboBox30.Text
        itemsept = ComboBox35.Text
        itemhuit = ComboBox40.Text
        itemneuf = ComboBox45.Text
        itemdix = ComboBox50.Text
        itemonce = ComboBox55.Text
        itemdouze = ComboBox60.Text
        itemtreize = ComboBox65.Text
        itemquatorz = ComboBox70.Text
        itemquinze = ComboBox75.Text


        un = ComboBox3.Text
        deux = ComboBox12.Text
        trois = ComboBox17.Text
        quatre = ComboBox22.Text
        cinq = ComboBox27.Text
        six = ComboBox32.Text
        sept = ComboBox37.Text
        huit = ComboBox42.Text
        neuf = ComboBox47.Text
        dix = ComboBox52.Text
        once = ComboBox57.Text
        douze = ComboBox62.Text
        treize = ComboBox67.Text
        quatorz = ComboBox72.Text
        quinze = ComboBox77.Text



        Dim listedetolerie As String
        listedetolerie = ("Sheet 10 Ga." + "Plaque 1" + "Plaque 1/2" + "Plaque 1/4" + "Plaque 3/8" + "Plaque 3/16" + "Plaque 5/8" + "Plaque 3/4" + "Plaque 5/16" + "Plaque 1-1/8" + "Plaque 1-3/8" + "Plaque 1-1/4" + "Plaque 1/8" + "Plaque 1/16" + "Plaque 1/8 SS" + "Plaque 1/4 SS" + "Plaque 3/8 SS" + "Plaque 7/8" + "Sheet 20 Ga." + "Sheet 16 Ga." + "Checker Plate 1/8")

        If itemun <> "" Then
            If listedetolerie.Contains(itemun) Then
                un = un / 1
            End If
        End If

        If itemdeux <> "" Then
            If listedetolerie.Contains(itemdeux) Then
                deux = deux / 1
            End If
        End If

        If itemtrois <> "" Then
            If listedetolerie.Contains(itemtrois) Then
                trois = trois / 1
            End If
        End If

        If itemquatre <> "" Then
            If listedetolerie.Contains(itemquatre) Then
                quatre = quatre / 1
            End If
        End If

        If itemcinq <> "" Then
            If listedetolerie.Contains(itemcinq) Then
                cinq = cinq / 1
            End If
        End If

        If itemsix <> "" Then
            If listedetolerie.Contains(itemsix) Then
                six = six / 1
            End If
        End If

        If itemsept <> "" Then
            If listedetolerie.Contains(itemsept) Then
                sept = sept / 1
            End If
        End If

        If itemhuit <> "" Then
            If listedetolerie.Contains(itemhuit) Then
                huit = huit / 1
            End If
        End If

        If itemneuf <> "" Then
            If listedetolerie.Contains(itemneuf) Then
                neuf = neuf / 1
            End If
        End If

        If itemdix <> "" Then
            If listedetolerie.Contains(itemdix) Then
                dix = dix / 1
            End If
        End If

        If itemonce <> "" Then
            If listedetolerie.Contains(itemonce) Then
                once = once / 1
            End If
        End If

        If itemdouze <> "" Then
            If listedetolerie.Contains(itemdouze) Then
                douze = douze / 1
            End If
        End If

        If itemtreize <> "" Then
            If listedetolerie.Contains(itemtreize) Then
                treize = treize / 1
            End If
        End If

        If itemquatorz <> "" Then
            If listedetolerie.Contains(itemquatorz) Then
                quatorz = quatorz / 1
            End If
        End If

        If itemquinze <> "" Then
            If listedetolerie.Contains(itemquinze) Then
                quinze = quinze / 1
            End If
        End If


        Dim connec As New OleDb.OleDbConnection
        Dim ajout As New OleDb.OleDbCommand
        Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12, sql13, sql14, sql15 As String
        Dim Tsql1, Tsql2, Tsql3, Tsql4, Tsql5, Tsql6, Tsql7, Tsql8, Tsql9, Tsql10, Tsql11, Tsql12, Tsql13, Tsql14, Tsql15 As String
        connec.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\Acier.accdb"
        connec.Open()

        sql1 = "UPDATE Acier Set Qté= Qté +'" & un & "'WHERE Nom ='" & itemun & "' "
        sql2 = "UPDATE Acier Set Qté= Qté +'" & deux & "'WHERE Nom ='" & itemdeux & "' "
        sql3 = "UPDATE Acier Set Qté= Qté +'" & trois & "'WHERE Nom ='" & itemtrois & "' "
        sql4 = "UPDATE Acier Set Qté= Qté +'" & quatre & "'WHERE Nom ='" & itemquatre & "' "
        sql5 = "UPDATE Acier Set Qté= Qté +'" & cinq & "'WHERE Nom ='" & itemcinq & "' "
        sql6 = "UPDATE Acier Set Qté= Qté +'" & six & "'WHERE Nom ='" & itemsix & "' "
        sql7 = "UPDATE Acier Set Qté= Qté +'" & sept & "'WHERE Nom ='" & itemsept & "' "
        sql8 = "UPDATE Acier Set Qté= Qté +'" & huit & "'WHERE Nom ='" & itemhuit & "' "
        sql9 = "UPDATE Acier Set Qté= Qté +'" & neuf & "'WHERE Nom ='" & itemneuf & "' "
        sql10 = "UPDATE Acier Set Qté= Qté +'" & dix & "'WHERE Nom ='" & itemdix & "' "
        sql11 = "UPDATE Acier Set Qté= Qté +'" & once & "'WHERE Nom ='" & itemonce & "' "
        sql12 = "UPDATE Acier Set Qté= Qté +'" & douze & "'WHERE Nom ='" & itemdouze & "' "
        sql13 = "UPDATE Acier Set Qté= Qté +'" & treize & "'WHERE Nom ='" & itemtreize & "' "
        sql14 = "UPDATE Acier Set Qté= Qté +'" & quatorz & "'WHERE Nom ='" & itemquatorz & "' "
        sql15 = "UPDATE Acier Set Qté= Qté +'" & quinze & "'WHERE Nom ='" & itemquinze & "' "

        Tsql1 = "UPDATE Acier Set TOTAL= TOTAL +'" & un & "'WHERE Nom ='" & itemun & "' "
        Tsql2 = "UPDATE Acier Set TOTAL= TOTAL +'" & deux & "'WHERE Nom ='" & itemdeux & "' "
        Tsql3 = "UPDATE Acier Set TOTAL= TOTAL +'" & trois & "'WHERE Nom ='" & itemtrois & "' "
        Tsql4 = "UPDATE Acier Set TOTAL= TOTAL +'" & quatre & "'WHERE Nom ='" & itemquatre & "' "
        Tsql5 = "UPDATE Acier Set TOTAL= TOTAL +'" & cinq & "'WHERE Nom ='" & itemcinq & "' "
        Tsql6 = "UPDATE Acier Set TOTAL= TOTAL +'" & six & "'WHERE Nom ='" & itemsix & "' "
        Tsql7 = "UPDATE Acier Set TOTAL= TOTAL +'" & sept & "'WHERE Nom ='" & itemsept & "' "
        Tsql8 = "UPDATE Acier Set TOTAL= TOTAL +'" & huit & "'WHERE Nom ='" & itemhuit & "' "
        Tsql9 = "UPDATE Acier Set TOTAL= TOTAL +'" & neuf & "'WHERE Nom ='" & itemneuf & "' "
        Tsql10 = "UPDATE Acier Set TOTAL= TOTAL +'" & dix & "'WHERE Nom ='" & itemdix & "' "
        Tsql11 = "UPDATE Acier Set TOTAL= TOTAL +'" & once & "'WHERE Nom ='" & itemonce & "' "
        Tsql12 = "UPDATE Acier Set TOTAL= TOTAL +'" & douze & "'WHERE Nom ='" & itemdouze & "' "
        Tsql13 = "UPDATE Acier Set TOTAL= TOTAL +'" & treize & "'WHERE Nom ='" & itemtreize & "' "
        Tsql14 = "UPDATE Acier Set TOTAL= TOTAL +'" & quatorz & "'WHERE Nom ='" & itemquatorz & "' "
        Tsql15 = "UPDATE Acier Set TOTAL= TOTAL +'" & quinze & "'WHERE Nom ='" & itemquinze & "' "


        Try
            ajout.Connection = connec
            ajout.CommandType = CommandType.Text
            ajout.CommandText = sql1
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql2
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql3
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql4
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql5
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql6
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql7
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql8
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql9
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql10
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql11
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql12
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql13
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql14
            ajout.ExecuteNonQuery()
            ajout.CommandText = sql15
            ajout.ExecuteNonQuery()

            ajout.CommandText = Tsql1
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql2
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql3
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql4
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql5
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql6
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql7
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql8
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql9
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql10
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql11
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql12
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql13
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql14
            ajout.ExecuteNonQuery()
            ajout.CommandText = Tsql15
            ajout.ExecuteNonQuery()

        Catch
            MsgBox("Petit Problème ")
        End Try


        Dim myMail As New MailMessage()
        Dim SMTP As New SmtpClient("ca.smtp.linkeo.com")

        If ComboBox78.Text = "Benoit Beauchemin" Then
            myMail.From = New MailAddress("bbeauchemin@XXXXXXX.ca") 'Expéditeur
            SMTP.Port = ("587") 'Port SMTP
            SMTP.Credentials = New System.Net.NetworkCredential("bbeauchemin@XXXXXXX.ca", "MotDePass") 'Mail + Pass
            SMTP.EnableSsl = True
        End If

        myMail.To.Add("bbeauchemin@XXXXXX.ca") 'Destinataire
        myMail.Subject = (nom) 'Sujet
        myMail.Body = ("Je vous envoie une demande en pièce joint. Merci ") 'Mesage 

        Dim data = New Net.Mail.Attachment("C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\" & nom & ".xlsx") 'Où est le fichier
        myMail.Attachments.Add(data) ' Mettre le fichier en pièce joint

        SMTP.Send(myMail) 'Envoyer Mail 


        MsgBox("Commande Envoyer. Merci !!! ")
        Close()

        ' Redémarrage 
        Process.Start("C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\Logiciel Inventaire.exe")
        Form1.Close()

    End Sub

End Class