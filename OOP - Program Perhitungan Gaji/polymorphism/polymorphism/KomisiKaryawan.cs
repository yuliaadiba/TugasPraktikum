using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class KomisiKaryawan : Karyawan
    {
        private decimal penjualanBruto;
        private decimal presentaseKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string nomerIdentitas, decimal penjualanBruto, decimal presentaseKomisi)
            : base(namaDepan, namaBelakang, nomerIdentitas)
        {
            PenjualanBruto = penjualanBruto;
            PresentaseKomisi = presentaseKomisi;
        }

        public decimal PenjualanBruto
        {
            get
            {
                return penjualanBruto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(penjualanBruto)} harus >= 0");
                }
                penjualanBruto = value;
            }
        }

        public decimal PresentaseKomisi
        {
            get
            {
                return presentaseKomisi;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(presentaseKomisi)} harus >= 0");
                }
                presentaseKomisi = value;
            }
        }

        public override decimal Penghasilan() => presentaseKomisi * penjualanBruto;

        public override string ToString() =>
            $" Nama karyawan\t\t: {base.ToString()}\n" +
            $" Penjualan bruto\t: {PenjualanBruto:C}\n" +
            $" Presentase komisi\t: {PresentaseKomisi:F2}";
    }
}
