# 🖥️ Pemrograman Visual — Pertemuan 2: Komponen Visual & Event Handling

[![D3 Teknik Informatika USU](https://img.shields.io/badge/Prodi-D3_Teknik_Informatika_USU-006633?style=for-the-badge&logo=academic-cap&logoColor=white)](https://usu.ac.id)
[![Mata Kuliah](https://img.shields.io/badge/Matkul-Pemrograman_Visual-8A2BE2?style=for-the-badge)](#)
[![IDE](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-Visual_Basic_.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/visual-basic/)

Dokumentasi praktikum **Pertemuan 2** mata kuliah Pemrograman Visual pada Program Studi **D3 Teknik Informatika, Universitas Sumatera Utara (USU)**. Materi pada pertemuan ini berfokus pada pengenalan **Komponen Visual (Controls)**, manipulasi **Properties**, serta penerapan **Event Handling** dasar menggunakan bahasa **Visual Basic (.NET Framework)** di Microsoft Visual Studio.

---

## 📌 Identitas Praktikan

| Informasi | Detail |
| :--- | :--- |
| **Nama Mahasiswa** | Fikri |
| **Repositori Utama** | [FikriOrb/pemrograman-visual](https://github.com/FikriOrb/pemrograman-visual) |
| **Program Studi** | D3 Teknik Informatika |
| **Fakultas / Kampus** | Vokasi / Universitas Sumatera Utara |
| **Materi Praktikum** | Pertemuan 2 — Komponen Visual & Event Handling |

---

## 💡 Konsep Dasar Komponen Visual & Form

Pada lingkungan **Windows Forms (WinForms)**, antarmuka pengguna dibangun di atas sebuah jendela yang disebut **Form** dengan menempatkan berbagai komponen GUI visual di atasnya:

1. **Form (`System.Windows.Forms.Form`)**  
   Kontainer utama tempat seluruh elemen antarmuka (*UI*) diletakkan dan berinteraksi.
2. **Komponen Visual (*Controls*)**  
   Elemen grafis interaktif seperti tombol, kotak input teks, label, dan checkbox yang digunakan pengguna untuk berinteraksi dengan aplikasi.
3. **Properties (Atribut)**  
   Karakteristik dari sebuah komponen yang menentukan nama variabel, tampilan visual, posisi, hingga perilakunya. Properti dapat diatur melalui jendela **Properties (F4)** saat *design time* maupun secara terprogram (*run time*).

---

## ⚙️ Event & Event-Driven Programming

Aplikasi GUI modern bekerja berbasis **Event-Driven Programming**, di mana alur program dijalankan saat terjadi peristiwa (*event*) tertentu:

* **Event**: Aksi yang dihasilkan dari interaksi pengguna (misalnya mengklik tombol `Click`, mengubah isi teks `TextChanged`) atau dari sistem (misalnya saat form dimuat `Load`).
* **Event Handler**: Sub-prosedur khusus dalam kode yang merespons event tersebut. Dalam Visual Basic, event handler ditandai dengan sintaks `Handles <NamaKomponen>.<NamaEvent>`.

---

## 🛠️ Komponen Utama yang Digunakan

Pada praktikum Pertemuan 2 ini, digunakan 3 jenis komponen dasar Windows Forms:

| Komponen | Nama Variabel (*Design Name*) | Fungsi & Peranan |
| :--- | :--- | :--- |
| **Label** | `Label1`, `Label2`, `Label3` | Menampilkan teks statis sebagai petunjuk input (*Nama*, *NIM*, *KOM*). |
| **TextBox** | `nama`, `nim`, `kom` | Kotak input interaktif untuk menerima data teks dari pengguna. |
| **Button** | `tampilkan`, `hapus`, `keluar` | Tombol aksi untuk memicu fungsi eksekusi program (*Tampilkan*, *Hapus*, *Keluar*). |

---

## 📝 Implementasi Kode Program (`Form1.vb`)

Berikut adalah kode sumber (*source code*) lengkap yang diimplementasikan pada `Form1.vb`:

```vb
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tampilkan_Click(sender As Object, e As EventArgs) Handles tampilkan.Click
        MessageBox.Show("Hello!" & vbCrLf &
            "Nama: " & nama.Text & vbCrLf &
            "NIM: " & nim.Text & vbCrLf &
            "KOM : " & kom.Text
        )
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        nama.Clear()
        nim.Clear()
        kom.Clear()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class
```

---

## 🔍 Penjelasan Logika & Sintaksis

### 1. Menampilkan Pesan (`tampilkan_Click`)
```vb
MessageBox.Show("Hello!" & vbCrLf &
    "Nama: " & nama.Text & vbCrLf &
    "NIM: " & nim.Text & vbCrLf &
    "KOM : " & kom.Text
)
```
* **`MessageBox.Show()`**: Menampilkan kotak dialog modal (*pop-up*) berisi pesan konfirmasi/informasi.
* **Operator `&`**: Digunakan untuk menggabungkan (*string concatenation*) antara teks string statis dengan nilai input dari properti `.Text` komponen `TextBox`.
* **`vbCrLf`**: Konstanta bawaan Visual Basic (*Carriage Return + Line Feed*) untuk membuat baris baru pada string.

### 2. Mengosongkan Input (`hapus_Click`)
```vb
nama.Clear()
nim.Clear()
kom.Clear()
```
* **`nama.Clear()`**: Method bawaan pada kontrol `TextBox` yang berfungsi untuk menghapus seluruh teks di dalam kotak input `nama`, `nim`, dan `kom` secara bersamaan.

### 3. Menutup Form (`keluar_Click`)
```vb
Me.Close()
```
* **`Me.Close()`**: Keyword `Me` merepresentasikan instance form aktif saat ini (`Form1`), dan method `.Close()` dipanggil untuk menutup form serta menghentikan jalannya aplikasi.

---

## 🚀 Alur Pengujian Aplikasi

1. **Jalankan Aplikasi**: Tekan `F5` atau tombol **Start** pada Visual Studio.
2. **Input Data**: Isikan data pada kotak teks `Nama`, `NIM`, dan `KOM`.
3. **Uji Tombol Tampilkan**: Klik tombol **Tampilkan**, aplikasi akan mengeluarkan *Message Box* dialog yang menampilkan data gabungan yang diinputkan.
4. **Uji Tombol Hapus**: Klik tombol **Hapus**, seluruh isian pada ketiga `TextBox` akan dibersihkan (*cleared*).
5. **Uji Tombol Keluar**: Klik tombol **Keluar**, form akan ditutup secara aman.

---

<div align="center">
  <p>📚 <i>Repositori Praktikum Pemrograman Visual — D3 Teknik Informatika Universitas Sumatera Utara</i></p>
</div>
