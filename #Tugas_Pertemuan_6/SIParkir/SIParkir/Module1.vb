Imports System.Windows.Forms
Imports System.Collections.Generic

Module Module1
    ' ============================================================
    ' Module Global - SI Parkir
    ' ============================================================

    Public strUsername As String = ""

    Public dictUsers As New System.Collections.Generic.Dictionary(Of String, String)

    ' Struktur data untuk satu record parkir
    Public Structure DataParkir
        Public NoPlat As String
        Public Jenis As String
        Public WaktuMasuk As String
        Public Harga As Integer
        Public WaktuKeluar As String
    End Structure

    ' List global untuk menyimpan semua transaksi parkir (masuk & keluar)
    Public listTransaksi As New List(Of DataParkir)

    ' List untuk kendaraan yang SEDANG parkir
    Public listParkir As New List(Of DataParkir)

    Sub InitUsers()
        dictUsers.Add("admin", "admin123")
        dictUsers.Add("petugas", "parkir123")
    End Sub

    ' Struktur data untuk satu record langganan
    Public Structure DataLangganan
        Public ID As Integer
        Public Nama As String
        Public NoPlat As String
        Public Jenis As String
        Public Biaya As String
        Public Expired As String
    End Structure

    ' List global untuk menyimpan data langganan
    Public listLangganan As New List(Of DataLangganan)

End Module
