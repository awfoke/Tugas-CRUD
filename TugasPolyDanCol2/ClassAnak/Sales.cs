using System.Transactions;
using TugasPolyDanCol2.ClassInduk;

namespace TugasPolyDanCol2.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public int Jumlahpenjualan { get; set; }
        public int Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
