// See https://aka.ms/new-console-template for more information
using modul7_group5;
using System;
using modul7_group5;
namespace modul7_group5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302210001_PRAKTIKAN dataMahasiswa = new DataMahasiswa1302210001_PRAKTIKAN();
            dataMahasiswa.ReadJSON();

            Console.ReadKey();
        }
    }
}
