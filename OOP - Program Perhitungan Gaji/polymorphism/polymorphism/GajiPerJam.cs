using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class GajiPerJam : Karyawan
    {
        private decimal gaji; // gaji per jam
        private decimal jam; // jumlah jam kerja per minggu

        public GajiPerJam(string namaDepan, string namaBelakang, string nomerIdentitas, decimal gajiPerJam, decimal jumlahJam)
            : base(namaDepan, namaBelakang, nomerIdentitas)
        {
            Gaji = gajiPerJam;
            Jam = jumlahJam;
        }

        public decimal Gaji
        {
            get
            {
                return gaji;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(gaji)} harus >= 0");
                }
                gaji = value;
            }
        }

        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(jam)} harus >= 0");
                }
                jam = value;
            }
        }
        public override decimal Penghasilan()
        {
            if (jam <= 40)
                return Gaji * Jam;
            else
                return (40 * Gaji) + ((Jam - 40) * Gaji * 1.5M);
        }
        public override string ToString() =>
            $" Nama karyawan\t\t: {base.ToString()}\n" +
            $" Gaji per jam\t\t: {Gaji:C}\n Jumlah jam kerja\t: {Jam:F2}";
    }
}
