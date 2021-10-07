using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var pegawai = new KomisiKaryawan("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            Console.WriteLine($" Informasi karyawan diperoleh dari properties dan methods:\n");

            Console.WriteLine($" Nama depan\t\t: {pegawai.NamaDepan}");
            Console.WriteLine($" Nama belakang\t\t: {pegawai.NamaBelakang}");
            Console.WriteLine($" Nomer identitas\t: {pegawai.NomerIdentitas}");
            Console.WriteLine($" Penjualan bruto\t: {pegawai.PenjualanBruto:C}");
            Console.WriteLine($" Presentase komisi\t: {pegawai.PresentaseKomisi:F2}");
            Console.WriteLine($" Penghasilan\t\t: {pegawai.Penghasilan():C}");

            pegawai.PenjualanBruto = 5000.00M;
            pegawai.PresentaseKomisi = .1M;

            Console.WriteLine($"\n Updated informasi karyawan diperoleh dari ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($" Penghasilan\t\t: {pegawai.Penghasilan():C}");
        }
    }
}
