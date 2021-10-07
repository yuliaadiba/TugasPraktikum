using System;
using System.Collections.Generic;

namespace ProgramPerhitunganGaji
{
    class Program
    {
        static void Main(string[] args)
        {
            var objekDibayarkan = new List<IPembayaran>() {
                new Tagihan("01234", "seat", 2, 375.00M),
                new Tagihan("56789", "tire", 4, 79.95M),
                new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M),
                new GajiKaryawan("Lisa", "Barnes", "888-88-8888", 1200.00M) };

            Console.WriteLine(" Tagihan dan Karyawan diproses secara polymorphism:\n");

            foreach (var dibayarkan in objekDibayarkan)
            {
                Console.WriteLine($"{dibayarkan}");
                Console.WriteLine($" Jumlah pembayaran\t: {dibayarkan.JumlahPembayaran():C}\n");
            }
        }
    }
}
