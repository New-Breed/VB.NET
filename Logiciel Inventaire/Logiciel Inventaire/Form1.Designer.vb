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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtéDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatérielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThicknessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcierDataSet = New Logiciel_Inventaire.AcierDataSet()
        Me.AcierTableAdapter = New Logiciel_Inventaire.AcierDataSetTableAdapters.AcierTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Chercher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Commande / Soumission"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(458, 416)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Fermer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(421, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 38)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Projet en Fabrication"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomDataGridViewTextBoxColumn, Me.QtéDataGridViewTextBoxColumn, Me.DimDataGridViewTextBoxColumn, Me.MatérielDataGridViewTextBoxColumn, Me.ThicknessDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AcierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 264)
        Me.DataGridView1.TabIndex = 7
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.Width = 200
        '
        'QtéDataGridViewTextBoxColumn
        '
        Me.QtéDataGridViewTextBoxColumn.DataPropertyName = "Qté"
        Me.QtéDataGridViewTextBoxColumn.HeaderText = "Qté"
        Me.QtéDataGridViewTextBoxColumn.Name = "QtéDataGridViewTextBoxColumn"
        Me.QtéDataGridViewTextBoxColumn.Width = 60
        '
        'DimDataGridViewTextBoxColumn
        '
        Me.DimDataGridViewTextBoxColumn.DataPropertyName = "Dim"
        Me.DimDataGridViewTextBoxColumn.HeaderText = "Dim"
        Me.DimDataGridViewTextBoxColumn.Name = "DimDataGridViewTextBoxColumn"
        Me.DimDataGridViewTextBoxColumn.Width = 80
        '
        'MatérielDataGridViewTextBoxColumn
        '
        Me.MatérielDataGridViewTextBoxColumn.DataPropertyName = "Matériel"
        Me.MatérielDataGridViewTextBoxColumn.HeaderText = "Matériel"
        Me.MatérielDataGridViewTextBoxColumn.Name = "MatérielDataGridViewTextBoxColumn"
        Me.MatérielDataGridViewTextBoxColumn.Width = 80
        '
        'ThicknessDataGridViewTextBoxColumn
        '
        Me.ThicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness"
        Me.ThicknessDataGridViewTextBoxColumn.HeaderText = "Thickness"
        Me.ThicknessDataGridViewTextBoxColumn.Name = "ThicknessDataGridViewTextBoxColumn"
        Me.ThicknessDataGridViewTextBoxColumn.Width = 60
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.Width = 60
        '
        'AcierBindingSource
        '
        Me.AcierBindingSource.DataMember = "Acier"
        Me.AcierBindingSource.DataSource = Me.AcierDataSet
        '
        'AcierDataSet
        '
        Me.AcierDataSet.DataSetName = "AcierDataSet"
        Me.AcierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcierTableAdapter
        '
        Me.AcierTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 29)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Mode Manuel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 466)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logiciel Inventaire"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AcierDataSet As AcierDataSet
    Friend WithEvents AcierBindingSource As BindingSource
    Friend WithEvents AcierTableAdapter As AcierDataSetTableAdapters.AcierTableAdapter
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtéDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatérielDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThicknessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
