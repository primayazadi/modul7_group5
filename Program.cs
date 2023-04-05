using KPL_MODUL7_KEL5;
using System;
using KPL_MODUL7_KEL5;
namespace KPL_MODUL7_KEL5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302213035_PRAKTIKAN dataMahasiswa = new DataMahasiswa1302213035_PRAKTIKAN();
            dataMahasiswa.ReadJSON();

            Console.ReadKey();
        }
    }
}