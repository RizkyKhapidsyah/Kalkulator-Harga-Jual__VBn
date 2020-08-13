<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHargaJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.teksHargaRitel = New System.Windows.Forms.TextBox()
        Me.teksPersenDiskon = New System.Windows.Forms.TextBox()
        Me.teksHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelPesan = New System.Windows.Forms.Label()
        Me.tombolHitung = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harga Ritel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Persentase Diskon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Jual:"
        '
        'teksHargaRitel
        '
        Me.teksHargaRitel.Location = New System.Drawing.Point(173, 23)
        Me.teksHargaRitel.Name = "teksHargaRitel"
        Me.teksHargaRitel.Size = New System.Drawing.Size(184, 20)
        Me.teksHargaRitel.TabIndex = 3
        '
        'teksPersenDiskon
        '
        Me.teksPersenDiskon.Location = New System.Drawing.Point(173, 53)
        Me.teksPersenDiskon.Name = "teksPersenDiskon"
        Me.teksPersenDiskon.Size = New System.Drawing.Size(184, 20)
        Me.teksPersenDiskon.TabIndex = 4
        '
        'teksHargaJual
        '
        Me.teksHargaJual.Location = New System.Drawing.Point(173, 85)
        Me.teksHargaJual.Name = "teksHargaJual"
        Me.teksHargaJual.ReadOnly = True
        Me.teksHargaJual.Size = New System.Drawing.Size(184, 20)
        Me.teksHargaJual.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(342, 20)
        Me.TextBox1.TabIndex = 6
        '
        'labelPesan
        '
        Me.labelPesan.AutoSize = True
        Me.labelPesan.Location = New System.Drawing.Point(44, 145)
        Me.labelPesan.Name = "labelPesan"
        Me.labelPesan.Size = New System.Drawing.Size(0, 13)
        Me.labelPesan.TabIndex = 7
        '
        'tombolHitung
        '
        Me.tombolHitung.Location = New System.Drawing.Point(13, 184)
        Me.tombolHitung.Name = "tombolHitung"
        Me.tombolHitung.Size = New System.Drawing.Size(115, 35)
        Me.tombolHitung.TabIndex = 8
        Me.tombolHitung.Text = "Hitung Harga Jual"
        Me.tombolHitung.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(242, 184)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(115, 35)
        Me.tombolKeluar.TabIndex = 9
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormHargaJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 237)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolHitung)
        Me.Controls.Add(Me.labelPesan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.teksHargaJual)
        Me.Controls.Add(Me.teksPersenDiskon)
        Me.Controls.Add(Me.teksHargaRitel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHargaJual"
        Me.Text = "Kalkulator Harga Jual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teksHargaRitel As System.Windows.Forms.TextBox
    Friend WithEvents teksPersenDiskon As System.Windows.Forms.TextBox
    Friend WithEvents teksHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents labelPesan As System.Windows.Forms.Label
    Friend WithEvents tombolHitung As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
