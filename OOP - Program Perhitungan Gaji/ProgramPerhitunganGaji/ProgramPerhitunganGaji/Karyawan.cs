﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPerhitunganGaji
{
    public abstract class Karyawan : IPembayaran
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomerIdentitas { get; }

        public Karyawan(string namaDepan, string namaBelakang, string nomerIdentitas)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomerIdentitas = nomerIdentitas;
        }

        public override string ToString() =>
            $"{NamaDepan} {NamaBelakang}\n" +
            $" Nomer identitas\t: {NomerIdentitas}";

        public abstract decimal Penghasilan();

        public decimal JumlahPembayaran() => Penghasilan();
    }
}
