using System;
using System.Collections.Generic;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var karyawanTergaji = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            var karyawanPerJam = new GajiPerJam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var gajiPokokPlusKomisi = new GajiPokokPlusKomisi("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine(" Karyawan diproses secara individual:\n");

            Console.WriteLine($"{karyawanTergaji}\n Penghasilan\t\t: " + $"{karyawanTergaji.Penghasilan():C}\n");
            Console.WriteLine($"{karyawanPerJam}\n Penghasilan\t\t: " + $"{karyawanPerJam.Penghasilan():C}\n");
            Console.WriteLine($"{komisiKaryawan}\n Penghasilan\t\t: " + $"{komisiKaryawan.Penghasilan():C}\n");
            Console.WriteLine($"{gajiPokokPlusKomisi}\n Penghasilan\t\t: " + $"{gajiPokokPlusKomisi.Penghasilan():C}\n");

            var pegawai = new List<Karyawan>() { karyawanTergaji, karyawanPerJam, komisiKaryawan, gajiPokokPlusKomisi };

            Console.WriteLine(" Karyawan diproses secara polymorphism:\n");

            foreach (var krywn in pegawai)
            {
                Console.WriteLine(krywn);

                if (krywn is GajiPokokPlusKomisi)
                {
                    var karyawan = (GajiPokokPlusKomisi)krywn;

                    karyawan.GajiPokok *= 1.10M;
                    Console.WriteLine(" Gaji pokok setelah kenaikan 10%: " + $"{karyawan.GajiPokok:C}");
                }

                Console.WriteLine($" Penghasilan\t\t: {krywn.Penghasilan():C}\n");
            }

            for (int j = 0; j < pegawai.Count; j++)
            {
                Console.WriteLine($" Karyawan {j} adalah {pegawai[j].GetType()}");
            }
        }
    }
}
