using System.Text.Json;



class DataMahasiswa1302210001_PRAKTIKAN
{
    public class Mahasiswa
    {
        public Biodata nama { get; set; }

        private char gender;
        private int age;
        private String address;
        private string course;

        public int nim { get; set; }

        public string fakultas { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(Biodata nama, char gender, int age, String address, String course)
        {
            this.nama = nama;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.course = course;
        }
    }

    public class Biodata
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public Biodata() { }

        public Biodata(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
    public void ReadJSON()
    {
        string file = "D:\\jurnal\\modul7_group5\\modul7_group5\\jsconfig1.json";
        string JSON = File.ReadAllText(file);
        Mahasiswa d = JsonSerializer.Deserialize<Mahasiswa>(JSON);
        Console.WriteLine($"Nama {d.nama.depan + " " + d.nama.belakang} dengan gender {d.} dari Fakultas {d.fakultas}");

    }
}