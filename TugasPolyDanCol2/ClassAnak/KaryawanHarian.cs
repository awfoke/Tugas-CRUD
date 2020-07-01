using TugasPolyDanCol2.ClassInduk;

namespace TugasPolyDanCol2.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double Upahperjam { get; set; }
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public int Jumlahjamkerja { get; set; }

        public override double Gaji()
        {
            return Upahperjam * JumlahJamKerja;
        }
    }
}
