using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPerhitunganGaji
{
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string namaDepan, string namaBelakang, string nomerIdentitas, decimal gajiMingguan)
            : base(namaDepan, namaBelakang, nomerIdentitas)
        {
            GajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }

        public override decimal Penghasilan() => GajiMingguan;

        public override string ToString() =>
            $" Nama karyawan\t\t: {base.ToString()}\n" +
            $" Gaji mingguan\t\t: {GajiMingguan:C}";
    }
}
