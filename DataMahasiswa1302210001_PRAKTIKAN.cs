<<<<<<< HEAD
﻿using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;



class DataMahasiswa1302210001_PRAKTIKAN
{
    public void ReadJSON()
    {
        Data d = JsonSerializer.Deserialize<Data>(File.ReadAllText("D:\\jurnal\\modul7_group5\\modul7_group5\\jsconfig1.json"));
        Console.WriteLine(d.firstName+ " " + d.lastName);
        Console.WriteLine(d.age);
        Console.WriteLine(d.gender);
        Console.WriteLine(d.address.streetAddress);
        Console.WriteLine(d.address.city);
        Console.WriteLine(d.address.state);
        foreach (var item in d.courses)
        {
            Console.WriteLine(item.code + " " + item.name);
        }

    }
    public class Data
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }

    }
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
 
=======
﻿using System.Text.Json;



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
>>>>>>> a4d224535a53e651600aa454890cd0f1a51b42ab
