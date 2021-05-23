<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AcierBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcierDataSet = New Logiciel_Acier.AcierDataSet()
        Me.AcierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcierTableAdapter = New Logiciel_Acier.AcierDataSetTableAdapters.AcierTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AcierBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatérielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThicknessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(850, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Acier Rechercher:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(318, 177)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 29)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "1"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(713, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 44)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Chercher"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(438, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Effacer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(116, 280)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 44)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Ajout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Exemple de recherche:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(409, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sheet - L - Checker Plate - Welded - Expanded "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(347, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "HSS Carré - HSS Ronds - W - C - Ronds"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(801, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(172, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Aide Mémoire"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Logiciel_Acier.My.Resources.Resources.Soudex_Metal
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AcierBindingSource1
        '
        Me.AcierBindingSource1.DataMember = "Acier"
        Me.AcierBindingSource1.DataSource = Me.AcierDataSet
        '
        'AcierDataSet
        '
        Me.AcierDataSet.DataSetName = "AcierDataSet"
        Me.AcierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcierBindingSource
        '
        Me.AcierBindingSource.DataMember = "Acier"
        Me.AcierBindingSource.DataSource = Me.AcierDataSet
        '
        'AcierTableAdapter
        '
        Me.AcierTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 38)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Supprimer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(11, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 38)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Modification"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 29)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = "1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(277, 29)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "1"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(54, 66)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(103, 29)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prix :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomDataGridViewTextBoxColumn, Me.LbsDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn, Me.MatérielDataGridViewTextBoxColumn, Me.AmpDataGridViewTextBoxColumn, Me.ThicknessDataGridViewTextBoxColumn, Me.DatePrixDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AcierBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(4, 403)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(979, 283)
        Me.DataGridView1.TabIndex = 12
        '
        'AcierBindingSource2
        '
        Me.AcierBindingSource2.DataMember = "Acier"
        Me.AcierBindingSource2.DataSource = Me.AcierDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(374, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 107)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 62)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.Width = 325
        '
        'LbsDataGridViewTextBoxColumn
        '
        Me.LbsDataGridViewTextBoxColumn.DataPropertyName = "Lbs"
        Me.LbsDataGridViewTextBoxColumn.HeaderText = "Lbs"
        Me.LbsDataGridViewTextBoxColumn.Name = "LbsDataGridViewTextBoxColumn"
        Me.LbsDataGridViewTextBoxColumn.Width = 80
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        Me.PrixDataGridViewTextBoxColumn.Width = 80
        '
        'MatérielDataGridViewTextBoxColumn
        '
        Me.MatérielDataGridViewTextBoxColumn.DataPropertyName = "Matériel"
        Me.MatérielDataGridViewTextBoxColumn.HeaderText = "Matériel"
        Me.MatérielDataGridViewTextBoxColumn.Name = "MatérielDataGridViewTextBoxColumn"
        '
        'AmpDataGridViewTextBoxColumn
        '
        Me.AmpDataGridViewTextBoxColumn.DataPropertyName = "Amp"
        Me.AmpDataGridViewTextBoxColumn.HeaderText = "Amp"
        Me.AmpDataGridViewTextBoxColumn.Name = "AmpDataGridViewTextBoxColumn"
        '
        'ThicknessDataGridViewTextBoxColumn
        '
        Me.ThicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness"
        Me.ThicknessDataGridViewTextBoxColumn.HeaderText = "Thickness"
        Me.ThicknessDataGridViewTextBoxColumn.Name = "ThicknessDataGridViewTextBoxColumn"
        '
        'DatePrixDataGridViewTextBoxColumn
        '
        Me.DatePrixDataGridViewTextBoxColumn.DataPropertyName = "DatePrix"
        Me.DatePrixDataGridViewTextBoxColumn.HeaderText = "DatePrix"
        Me.DatePrixDataGridViewTextBoxColumn.Name = "DatePrixDataGridViewTextBoxColumn"
        Me.DatePrixDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(985, 698)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acier Soudex Metal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents AcierDataSet As AcierDataSet
    Friend WithEvents AcierBindingSource As BindingSource
    Friend WithEvents AcierTableAdapter As AcierDataSetTableAdapters.AcierTableAdapter
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AcierBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents AcierBindingSource2 As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LbsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatérielDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThicknessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatePrixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
