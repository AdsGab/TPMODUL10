namespace tpmodul10_1302223050
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string Nama, string NIM)
        {
            this.Nama = Nama;
            this.NIM = NIM;
        }
    }
}