using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPerhitunganGaji
{
    public class GajiPokokPlusKomisi : KomisiKaryawan
    {
        private decimal gajiPokok;
        public GajiPokokPlusKomisi(string namaDepan, string namaBelakang, string nomerIdentitas, decimal penjualanBruto, decimal presentaseKomisi, decimal gajiPokok)
            : base(namaDepan, namaBelakang, nomerIdentitas, penjualanBruto, presentaseKomisi)
        {
            GajiPokok = gajiPokok;
        }
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(gajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        public override decimal Penghasilan() => GajiPokok + base.Penghasilan();

        public override string ToString() =>
            $"Gaji pokok {base.ToString()}\nGaji pokok: {GajiPokok:C}";
    }
}
