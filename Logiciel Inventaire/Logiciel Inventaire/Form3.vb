Public Class Form3
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'AcierDataSet.Acier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.AcierTableAdapter.Fill(Me.AcierDataSet.Acier)

        ComboBox1.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})
        ComboBox2.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})
        ComboBox3.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})
        ComboBox4.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})
        ComboBox5.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})
        ComboBox6.Items.AddRange(New Object() {"-1", "-0.25", "-0.5", "-0.75", "-2", "-5"})

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AcierBindingSource1.Filter = "Nom like '" & TextBox7.Text & "*'"
    End Sub
End Class