from data_bangunDatar import persegi_panjang
from data_bangunDatar import segitiga
from data_bangunDatar import trapesium

print("-- Persegi Panjang --")
input_p = int(input("Masukkan panjang: "))
input_l = int(input("Masukkan lebar: "))

pp = persegi_panjang(input_p, input_l)
pp.keliling()
pp.luas()
pp.cetak()

print("-- Segitiga Siku-Siku --")
input_sA = int(input("Masukkan sisi a (tinggi): "))
input_sB = int(input("Masukkan sisi b (alas): "))
input_sC = int(input("Masukkan sisi c: "))

sgt = segitiga(input_sA, input_sB, input_sC)
sgt.keliling()
sgt.luas()
sgt.cetak()

print("-- Trapesium Siku-Siku --")
input_a = int(input("masukkan sisi a: "))
input_b = int(input("masukkan sisi b: "))
input_s = int(input("masukkan sisi miring: "))
input_t = int(input("masukkan sisi tinggi: "))

tpr = trapesium(input_a, input_b, input_s, input_t)
tpr.keliling()
tpr.luas()
tpr.cetak()