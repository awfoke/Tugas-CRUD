using TugasPolyDanCol2.ClassInduk;

namespace TugasPolyDanCol2.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public int Gajibulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
