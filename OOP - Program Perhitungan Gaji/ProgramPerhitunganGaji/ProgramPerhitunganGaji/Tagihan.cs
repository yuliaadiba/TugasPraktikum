using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPerhitunganGaji
{
    public class Tagihan : IPembayaran
    {
        public string NomerBagian { get; }
        public string Deskripsi { get; }

        private int jumlah;
        private decimal hargaPerItem;

        public Tagihan(string nomerBagian, string deskripsi, int jumlah, decimal hargaPerItem)
        {
            NomerBagian = nomerBagian;
            Deskripsi = deskripsi;
            Jumlah = jumlah;
            HargaPerItem = hargaPerItem;
        }

        public int Jumlah
        {
            get
            {
                return jumlah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jumlah)} harus >= 0");
                }
                jumlah = value;
            }
        }

        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerItem)} harus >= 0");
                }
                hargaPerItem = value;
            }
        }

        public override string ToString() =>
            $" Tagihan:\n Nomer bagian\t\t: {NomerBagian} ({Deskripsi})" +
            $"\n Jumlah\t\t\t: {Jumlah}\n Harga per item\t\t: {HargaPerItem:C}";

        public decimal JumlahPembayaran() => Jumlah * HargaPerItem;
    }
}
