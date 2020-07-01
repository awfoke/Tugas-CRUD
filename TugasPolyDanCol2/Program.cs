using System;
using System.Collections.Generic;
using System.Linq;
using TugasPolyDanCol2.ClassAnak;
using TugasPolyDanCol2.ClassInduk;

namespace TugasPolyDanCol2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listkaryawan = new List<Karyawan>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==Sistem Informasi Karyawan==");
                Console.WriteLine("[1] Tambah Karyawan");
                Console.WriteLine("[2] Ubah Data Karyawan");
                Console.WriteLine("[3] Tampilkan Karyawan");
                Console.WriteLine("[4] Hapus Karyawan");
                Console.WriteLine("[5] Keluar");
                Console.Write("Pilihan:");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        CreateKaryawan(listkaryawan);
                        break;
                    case 2:
                        UpdateKaryawan(listkaryawan);
                        break;
                    case 3:
                        ReadKaryawan(listkaryawan);
                        break;
                    case 4:
                        DeleteKaryawan(listkaryawan);
                        break;
                }
                if (pilihan == 5)
                    break;
            }
        }

        private static void CreateKaryawan(List<Karyawan> listkaryawan)
        {
            Console.Clear();
            Console.WriteLine("==Menambah Karyawan==\n");
            Console.WriteLine("Kategori Karyawan:");
            Console.WriteLine("[1] Karywan Tetap");
            Console.WriteLine("[2] Karywan Harian");
            Console.WriteLine("[3] Sales");
            Console.Write("Pilihan:");
            int kategori = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (kategori == 1)
                CreateKaryawanTetap();
            else if (kategori == 2)
                CreateKaryawanHarian();
            else
                CreateSales();

            void CreateKaryawanTetap()
            {
                KaryawanTetap karyawantetap = new KaryawanTetap();
                Console.Write("Nama Karyawan:");
                karyawantetap.Nama = Console.ReadLine();
                Console.Write("NIK Karyawan:");
                karyawantetap.Nik = Console.ReadLine();
                Console.Write("Gaji Bulanan:");
                karyawantetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                listkaryawan.Add(karyawantetap);
            }

            void CreateKaryawanHarian()
            {
                KaryawanHarian karyawanharian = new KaryawanHarian();
                Console.Write("Nama Karyawan:");
                karyawanharian.Nama = Console.ReadLine();
                Console.Write("NIK Karyawan:");
                karyawanharian.Nik = Console.ReadLine();
                Console.Write("Upah Per Jam:");
                karyawanharian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                Console.Write("NIK:");
                karyawanharian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                listkaryawan.Add(karyawanharian);
            }

            void CreateSales()
            {
                Sales sales = new Sales();
                Console.Write("Nama Karyawan: ");
                sales.Nama = Console.ReadLine();
                Console.Write("NIK Karyawan: ");
                sales.Nik = Console.ReadLine();
                Console.Write("Jumlah Penjualan: ");
                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                Console.Write("Komisi: ");
                sales.Komisi = (int)Convert.ToDouble(Console.ReadLine());
                listkaryawan.Add(sales);
            }
            Console.WriteLine("\n\nData Berhasil Ditambahkan");
            Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
            Console.ReadKey();
        }

        private static void UpdateKaryawan(List<Karyawan> listkaryawan)
        {
            bool ditemukan = false;
            Console.Clear();
            Console.WriteLine("==Update Data Karyawan==\n");
            Console.Write("Masukan NIK: ");
            String searchNik = Console.ReadLine();
            foreach (Karyawan karyawan in listkaryawan)
            {
                if (karyawan.Nik == searchNik)
                {
                    if (karyawan is KaryawanTetap)
                        UpdateKaryawanTetap();
                    else if (karyawan is KaryawanHarian)
                        UpdateKaryawanHarian();
                    else
                        UpdateSales();
                    ditemukan = true;
                    break;
                }
            }

            void UpdateKaryawanTetap()
            {
                foreach (KaryawanTetap karyawantetap in listkaryawan.Where(karyawantetap
                => karyawantetap.Nik == searchNik))
                {
                    Console.WriteLine("[1] Nama: " + karyawantetap.Nama);
                    Console.WriteLine("[2] NIK: " + karyawantetap.Nik);
                    Console.WriteLine("[3] Gaji Bulanan: " + karyawantetap.GajiBulanan);
                    Console.Write("Pilih Data yang akan di update: ");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Write("\nUpdate Nama:");
                            karyawantetap.Nama = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\nUpdate NIK:");
                            karyawantetap.Nik = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\nUpdate Gaji Bulannan:");
                            karyawantetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }
            }

            void UpdateKaryawanHarian()
            {
                foreach (KaryawanHarian karyawanharian in listkaryawan.Where(karyawanharian
                => karyawanharian.Nik == searchNik))
                {
                    Console.WriteLine("[1] Nama: " + karyawanharian.Nama);
                    Console.WriteLine("[2] NIK: " + karyawanharian.Nik);
                    Console.WriteLine("[3] Upah: " + karyawanharian.UpahPerJam);
                    Console.WriteLine("[4] Jumlah Jam Kerja: " + karyawanharian.JumlahJamKerja);
                    Console.Write("Pilih Data yang akan di update: ");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Write("\nUpdate Nama:");
                            karyawanharian.Nama = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\nUpdate NIK:");
                            karyawanharian.Nik = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\nUpdate Upah:");
                            karyawanharian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("\nUpdate Jumlah Jam Kerja:");
                            karyawanharian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }
            }

            void UpdateSales()
            {
                foreach (Sales sales in listkaryawan.Where(sales
                => sales.Nik == searchNik))
                {
                    Console.WriteLine("[1] Nama: " + sales.Nama);
                    Console.WriteLine("[2] NIK: " + sales.Nik);
                    Console.WriteLine("[3] Komisi: " + sales.Komisi);
                    Console.WriteLine("[4] Jumlah Penjualan: " + sales.JumlahPenjualan);
                    Console.Write("Pilih Data yang akan di update: ");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Write("\nUpdate Nama: ");
                            sales.Nama = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\nUpdate NIK: ");
                            sales.Nik = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("\nUpdate Jumlah Penjualan: ");
                            sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("\nUpdate Komisi: ");
                            sales.Komisi = (int)Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }
            }
            if (ditemukan == false)
            {
                Console.WriteLine("\n\nNIK Tidak ditemukan");
                Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\nData Berhasil Diupdate");
                Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
                Console.ReadKey();
            }
        }

        private static void ReadKaryawan(List<Karyawan> listkaryawan)
        {
            Console.Clear();
            Console.WriteLine("==Menampilkan Seluruh Karyawan==\n");
            int nourut = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.Write("{0}. NIK : {1}, Nama: {2}, Gaji: {3} |",
                    nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                ShowValue(karyawan);
                nourut++;
            }

            void ShowValue(object karyawan)
            {
                if (karyawan is KaryawanTetap)
                {
                    Console.WriteLine("Karyawan Tetap");
                }
                else if (karyawan is KaryawanHarian)
                {
                    Console.WriteLine("Karyawan Harian");
                }
                else
                {
                    Console.WriteLine("Sales");
                }
            }
            Console.WriteLine("\n\nTekan ENTER untuk kembali ke Home");
            Console.ReadKey();
        }

        private static void DeleteKaryawan(List<Karyawan> listkaryawan)
        {
            bool ditemukan = false;
            Console.Clear();
            Console.WriteLine("==Hapus Data Karyawan==\n");
            Console.Write("Masukan NIK: ");
            String rmNik = Console.ReadLine();
            int nourut = 0;
            foreach (Karyawan karyawan in listkaryawan)
            {
                if (karyawan.Nik == rmNik)
                {
                    ditemukan = true;
                    break;
                }
                nourut++;
            }
            if (ditemukan == false)
            {
                Console.WriteLine("\n\nNIK Tidak ditemukan");
                Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
                Console.ReadKey();
            }
            else
            {
                listkaryawan.RemoveAt(nourut);
                Console.WriteLine("\n\nData Berhasil di Hapus");
                Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
                Console.ReadKey();
            }
        }
    }
}
