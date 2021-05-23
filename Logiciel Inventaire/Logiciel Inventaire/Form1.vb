Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim connec As New OleDb.OleDbConnection
    Dim ajout As New OleDb.OleDbCommand
    Dim sql As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connec.Close()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'AcierDataSet.Acier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.AcierTableAdapter.Fill(Me.AcierDataSet.Acier)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AcierBindingSource.Filter = "Nom like '" & TextBox1.Text & "*'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ofd As New OpenFileDialog()

        'Va chercher la soumission déja fait pour la sortir de l inventaire quand la job à passer en mode fabrication
        ofd.Title = "Fichier Excel Soumission"
        ofd.InitialDirectory = "T:\Soumission"
        ofd.Filter = "Fichiers Excel|*.xlsx"
        ofd.Multiselect = False

        If (ofd.ShowDialog = Windows.Forms.DialogResult.OK) Then ' ---- Transféré info excel (Qté tolerie) dans la base de donnée Inventaire

            Dim ApExcel As Object
            Dim un, deux, trois, quatre, cinq, six, sept, huit, neuf, dix, once, douze As Double
            Dim itemun, itemdeux, itemtrois, itemquatre, itemcinq, itemsix, itemsept, itemhuit, itemneuf, itemdix, itemonce, itemdouze As String
            Dim un2, deux2, trois2, quatre2, cinq2, six2, sept2, huit2, neuf2, dix2, once2, douze2 As Double
            Dim itemun2, itemdeux2, itemtrois2, itemquatre2, itemcinq2, itemsix2, itemsept2, itemhuit2, itemneuf2, itemdix2, itemonce2, itemdouze2 As String

            ApExcel = CreateObject("Excel.application")
            ApExcel.Application.DisplayAlerts = False
            ApExcel.Workbooks.open(ofd.FileName)
            ApExcel.visible = False

            'Page Item1
            itemun = ApExcel.Sheets(3).Cells(11, 2).Value
            itemdeux = ApExcel.Sheets(3).Cells(12, 2).Value
            itemtrois = ApExcel.Sheets(3).Cells(13, 2).Value
            itemquatre = ApExcel.Sheets(3).Cells(14, 2).Value
            itemcinq = ApExcel.Sheets(3).Cells(15, 2).Value
            itemsix = ApExcel.Sheets(3).Cells(16, 2).Value
            itemsept = ApExcel.Sheets(3).Cells(17, 2).Value
            itemhuit = ApExcel.Sheets(3).Cells(18, 2).Value
            itemneuf = ApExcel.Sheets(3).Cells(19, 2).Value
            itemdix = ApExcel.Sheets(3).Cells(20, 2).Value
            itemonce = ApExcel.Sheets(3).Cells(21, 2).Value
            itemdouze = ApExcel.Sheets(3).Cells(22, 2).Value


            un = ApExcel.Sheets(3).Cells(11, 6).Value
            deux = ApExcel.Sheets(3).Cells(12, 6).Value
            trois = ApExcel.Sheets(3).Cells(13, 6).Value
            quatre = ApExcel.Sheets(3).Cells(14, 6).Value
            cinq = ApExcel.Sheets(3).Cells(15, 6).Value
            six = ApExcel.Sheets(3).Cells(16, 6).Value
            sept = ApExcel.Sheets(3).Cells(17, 6).Value
            huit = ApExcel.Sheets(3).Cells(18, 6).Value
            neuf = ApExcel.Sheets(3).Cells(19, 6).Value
            dix = ApExcel.Sheets(3).Cells(20, 6).Value
            once = ApExcel.Sheets(3).Cells(21, 6).Value
            douze = ApExcel.Sheets(3).Cells(22, 6).Value

            'Page Item2
            itemun2 = ApExcel.Sheets(5).Cells(11, 2).Value
            itemdeux2 = ApExcel.Sheets(5).Cells(12, 2).Value
            itemtrois2 = ApExcel.Sheets(5).Cells(13, 2).Value
            itemquatre2 = ApExcel.Sheets(5).Cells(14, 2).Value
            itemcinq2 = ApExcel.Sheets(5).Cells(15, 2).Value
            itemsix2 = ApExcel.Sheets(5).Cells(16, 2).Value
            itemsept2 = ApExcel.Sheets(5).Cells(17, 2).Value
            itemhuit2 = ApExcel.Sheets(5).Cells(18, 2).Value
            itemneuf2 = ApExcel.Sheets(5).Cells(19, 2).Value
            itemdix2 = ApExcel.Sheets(5).Cells(20, 2).Value
            itemonce2 = ApExcel.Sheets(5).Cells(21, 2).Value
            itemdouze2 = ApExcel.Sheets(5).Cells(22, 2).Value


            un2 = ApExcel.Sheets(5).Cells(11, 6).Value
            deux2 = ApExcel.Sheets(5).Cells(12, 6).Value
            trois2 = ApExcel.Sheets(5).Cells(13, 6).Value
            quatre2 = ApExcel.Sheets(5).Cells(14, 6).Value
            cinq2 = ApExcel.Sheets(5).Cells(15, 6).Value
            six2 = ApExcel.Sheets(5).Cells(16, 6).Value
            sept2 = ApExcel.Sheets(5).Cells(17, 6).Value
            huit2 = ApExcel.Sheets(5).Cells(18, 6).Value
            neuf2 = ApExcel.Sheets(5).Cells(19, 6).Value
            dix2 = ApExcel.Sheets(5).Cells(20, 6).Value
            once2 = ApExcel.Sheets(5).Cells(21, 6).Value
            douze2 = ApExcel.Sheets(5).Cells(22, 6).Value

            ApExcel.ActiveWorkbook.Close()
            ApExcel.quit()


            Dim listedetolerie As String
            listedetolerie = ("Checker Plate 1/8" + "Plaque 1" + "Plaque 1/16" + "Plaque 1/2" + "Plaque 1/4" + "Plaque 1/4 SS" + "Plaque 1/8" + "Plaque 1/8 SS" + "Plaque 1-1/4" + "Plaque 1-1/8" + "Plaque 1-3/8" + "Plaque 3/16" + "Plaque 3/16 SS" + "Plaque 3/4" + "Plaque 3/8" + "Plaque 3/8 Alu" + "Plaque 3/8 SS" + "Plaque 5/16" + "Plaque 5/8" + "Plaque 7/8" + "Sheet 10 Ga." + "Sheet 18 Ga." + "Sheet 11 Ga." + "Sheet 14 Ga." + "Sheet 16 Ga." + "Sheet 20 Ga.")

            If itemun <> "" Then
                If listedetolerie.Contains(itemun) Then
                    un = un / 50 * -1
                Else
                    un = un / 20 * -1
                End If
            End If

            If itemdeux <> "" Then
                If listedetolerie.Contains(itemdeux) Then
                    deux = deux / 50 * -1
                Else
                    deux = deux / 20 * -1
                End If
            End If

            If itemtrois <> "" Then
                If listedetolerie.Contains(itemtrois) Then
                    trois = trois / 50 * -1
                Else
                    trois = trois / 20 * -1
                End If
            End If

            If itemquatre <> "" Then
                If listedetolerie.Contains(itemquatre) Then
                    quatre = quatre / 50 * -1
                Else
                    quatre = quatre / 20 * -1
                End If
            End If

            If itemcinq <> "" Then
                If listedetolerie.Contains(itemcinq) Then
                    cinq = cinq / 50 * -1
                Else
                    cinq = cinq / 20 * -1
                End If
            End If

            If itemsix <> "" Then
                If listedetolerie.Contains(itemsix) Then
                    six = six / 50 * -1
                Else
                    six = six / 20 * -1
                End If
            End If

            If itemsept <> "" Then
                If listedetolerie.Contains(itemsept) Then
                    sept = sept / 50 * -1
                Else
                    sept = sept / 20 * -1
                End If
            End If

            If itemhuit <> "" Then
                If listedetolerie.Contains(itemhuit) Then
                    huit = huit / 50 * -1
                Else
                    huit = huit / 20 * -1
                End If
            End If

            If itemneuf <> "" Then
                If listedetolerie.Contains(itemneuf) Then
                    neuf = neuf / 50 * -1
                Else
                    neuf = neuf / 20 * -1
                End If
            End If

            If itemdix <> "" Then
                If listedetolerie.Contains(itemdix) Then
                    dix = dix / 50 * -1
                Else
                    dix = dix / 20 * -1
                End If
            End If

            If itemonce <> "" Then
                If listedetolerie.Contains(itemonce) Then
                    once = once / 50 * -1
                Else
                    once = once / 20 * -1
                End If
            End If

            If itemdouze <> "" Then
                If listedetolerie.Contains(itemdouze) Then
                    douze = douze / 50 * -1
                Else
                    douze = douze / 20 * -1
                End If
            End If


            Dim connec As New OleDb.OleDbConnection
            Dim ajout As New OleDb.OleDbCommand
            Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12 As String
            Dim sql21, sql22, sql23, sql24, sql25, sql26, sql27, sql28, sql29, sql120, sql121, sql122 As String

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

            sql21 = "UPDATE Acier Set Qté= Qté +'" & un2 & "'WHERE Nom ='" & itemun2 & "' "
            sql22 = "UPDATE Acier Set Qté= Qté +'" & deux2 & "'WHERE Nom ='" & itemdeux2 & "' "
            sql23 = "UPDATE Acier Set Qté= Qté +'" & trois2 & "'WHERE Nom ='" & itemtrois2 & "' "
            sql24 = "UPDATE Acier Set Qté= Qté +'" & quatre2 & "'WHERE Nom ='" & itemquatre2 & "' "
            sql25 = "UPDATE Acier Set Qté= Qté +'" & cinq2 & "'WHERE Nom ='" & itemcinq2 & "' "
            sql26 = "UPDATE Acier Set Qté= Qté +'" & six2 & "'WHERE Nom ='" & itemsix2 & "' "
            sql27 = "UPDATE Acier Set Qté= Qté +'" & sept2 & "'WHERE Nom ='" & itemsept2 & "' "
            sql28 = "UPDATE Acier Set Qté= Qté +'" & huit2 & "'WHERE Nom ='" & itemhuit2 & "' "
            sql29 = "UPDATE Acier Set Qté= Qté +'" & neuf2 & "'WHERE Nom ='" & itemneuf2 & "' "
            sql120 = "UPDATE Acier Set Qté= Qté +'" & dix2 & "'WHERE Nom ='" & itemdix2 & "' "
            sql121 = "UPDATE Acier Set Qté= Qté +'" & once2 & "'WHERE Nom ='" & itemonce2 & "' "
            sql122 = "UPDATE Acier Set Qté= Qté +'" & douze2 & "'WHERE Nom ='" & itemdouze2 & "' "


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

                ajout.CommandText = sql21
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql22
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql23
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql24
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql25
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql26
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql27
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql28
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql29
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql120
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql121
                ajout.ExecuteNonQuery()
                ajout.CommandText = sql122
                ajout.ExecuteNonQuery()
                MsgBox("La modification à bien été fait dans la Base de Donnée",, "Enregister")

            Catch
                MsgBox("Petit Problème ")
            End Try

        End If

        ' Redémarrage
        Process.Start("C:\Users\XXXXXXXXX\VB.NET\Logiciel Inventaire\Logiciel Inventaire.exe")
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub
End Class
