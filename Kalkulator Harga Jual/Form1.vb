Public Class FormHargaJual
    Private decRitel As Decimal     'Untuk memuat harga ritel
    Private decPersen As Decimal    'Untuk memuat persentase diskon

    Private Function ValidasiBidangMasukan() As Boolean
        'Mencoba mengkonversi setiap bidang masukan. Menghasilkan False jika
        'bidang tak valid, dan menampilkan pesan error relevan

        If Not Decimal.TryParse(teksHargaRitel.Text, decRitel) Then
            labelPesan.Text = "Harga ritel harus numerik"
            Return False
        End If

        If Not Decimal.TryParse(teksPersenDiskon.Text, decPersen) Then
            labelPesan.Text = "Persentase diskon harus numerik"
            Return False
        End If

        Return True
    End Function

    Function HitungHargaJual(ByVal decRitel As Decimal, ByVal decPersen As Decimal) As Decimal
        'Menghitung dan menghasilkan harga jual
        Dim decHargaJual As Decimal

        decHargaJual = decRitel - (decRitel * decPersen)
        Return decHargaJual
    End Function

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        Dim decHargaJual As Decimal

        'Membersihkan pesan sebelumnya
        labelPesan.Text = String.Empty

        'Jika masukan valid, tampilkan harga jual
        If ValidasiBidangMasukan() Then
            decHargaJual = HitungHargaJual(decRitel, decPersen)
            teksHargaJual.Text = "Rp. " & decHargaJual.ToString()
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        Me.Close()
    End Sub
End Class
