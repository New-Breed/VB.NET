Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged
        Dim mm, rep As Decimal

        If IsNumeric(TextBox1.Text) Then
            mm = TextBox1.Text
            rep = mm * 25.4
            Label58.Text = rep
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox2.Text) Then
            mm = TextBox2.Text
            rep = mm / 25.4
            Label64.Text = rep
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox3.Text) Then
            mm = TextBox3.Text
            rep = mm / 144
            Label67.Text = rep
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox4.Text) Then
            mm = TextBox4.Text
            rep = mm * 144
            Label70.Text = rep
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox5.Text) Then
            mm = TextBox5.Text
            rep = mm * 10.764
            Label73.Text = rep
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox6.Text) Then
            mm = TextBox6.Text
            rep = mm * 3.281
            Label76.Text = rep
        End If
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox7.Text) Then
            mm = TextBox7.Text
            rep = mm / 92903
            Label79.Text = rep
        End If
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox8.Text) Then
            mm = TextBox8.Text
            rep = mm / 2.205
            Label82.Text = rep
        End If
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox9.Text) Then
            mm = TextBox9.Text
            rep = mm * 2.205
            Label85.Text = rep
        End If
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dim mm, rep As Single

        If IsNumeric(TextBox10.Text) Then
            mm = TextBox10.Text
            rep = mm / 12
            Label88.Text = rep
        End If
    End Sub

End Class