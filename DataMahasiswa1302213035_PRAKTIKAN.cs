using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;



class DataMahasiswa1302210001_PRAKTIKAN
{
    public void ReadJSON()
    {
        Data d = JsonSerializer.Deserialize<Data>(File.ReadAllText("D:\\modul7_group5\\KPL_MODUL7_KEL5\\KPL_MODUL7_KEL5\\DataMahasiswa1302213035_PRAKTIKAN.json"));
        Console.WriteLine(d.firstName + " " + d.lastName);
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
