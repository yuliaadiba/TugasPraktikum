using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class KomisiKaryawan : object
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomerIdentitas { get; }
        
        private decimal penjualanBruto;
        private decimal presentaseKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string nomerIdentitas, decimal penjualanBruto, decimal presentaseKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomerIdentitas = nomerIdentitas; 
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

        public decimal Penghasilan() => presentaseKomisi * penjualanBruto;

        public override string ToString() =>
            $" Nama karyawan\t\t: {NamaDepan} {NamaBelakang}\n" +
            $" Nomer identitas\t: {NomerIdentitas}\n" +
            $" Penjualan bruto\t: {PenjualanBruto:C}\n" +
            $" Presentase komisi\t: {PresentaseKomisi:F2}";
    }
}
