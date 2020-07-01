namespace TugasPolyDanCol2.ClassInduk
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}
