using System;

namespace modul5_103082400040
{
    // TAMBahkan class ini
    public class Penjumlahan
    {
        public dynamic JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Panggil method
            Penjumlahan p = new Penjumlahan();
            long hasil = p.JumlahTigaAngka<long>(10, 30, 82);
            Console.WriteLine($"Hasil penjumlahan: {hasil}");
        }
    }
}