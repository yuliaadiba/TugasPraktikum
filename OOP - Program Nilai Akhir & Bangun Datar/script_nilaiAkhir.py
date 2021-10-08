from data_nilaiAkhir import Nilai

namaMhs = input("Masukkan Nama Mahasiswa: ")
nim = input("Masukkan NIM: ")
nPartisipasi = input("Masukkan Nilai Partisipasi: ")
nTugas = input("Masukkan Nilai Tugas: ")
nUTS = input("Masukkan Nilai UTS: ")
nUAS = input("Masukkan Nilai UAS: ")

mhs1 = Nilai(nim,namaMhs,nTugas,nPartisipasi,nUTS,nUAS)
print("Nilai: ",round(mhs1.nilaiAkhir()))
print("Nilai Konversi: ",mhs1.nilaiHuruf())