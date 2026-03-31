using System;
using System.Collections.Generic;

namespace modul5_103082400040
{
    // Class Penjumlahan (sudah ada dari branch sebelumnya)
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

    // ===== TAMBAHKAN CLASS INI =====
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i].ToUniversalTime()}");
            }
        }
    }
    // ===== AKHIR CLASS SimpleDataBase =====

    class Program
    {
        static void Main(string[] args)
        {
            // Test Generic Method
            Penjumlahan p = new Penjumlahan();
            long hasil = p.JumlahTigaAngka<long>(10, 30, 82);
            Console.WriteLine($"Hasil penjumlahan: {hasil}");

            // Test Generic Class
            SimpleDataBase<long> db = new SimpleDataBase<long>();
            db.AddNewData(10);
            db.AddNewData(30);
            db.AddNewData(82);

            Console.WriteLine("\n=== Database Contents ===");
            db.PrintAllData();
        }
    }
}