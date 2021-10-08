class Nilai:

    def __init__(self,nama,nim,nPartisipasi,nTugas,nUTS,nUAS):
        self.nim = nim
        self.nama = nama
        self.nTugas = nTugas
        self.nPartisipasi = nPartisipasi
        self.nUTS = nUTS
        self.nUAS = nUAS
    
    def nilaiAkhir(self):
        return (0.3 * float(self.nTugas)+0.2*float(self.nPartisipasi)+0.2*float(self.nUTS)+0.3*float(self.nUAS))

    def nilaiHuruf(self):
        if 85 <= self.nilaiAkhir() < 100:
            return '4(A)'

        elif 80 <= self.nilaiAkhir() < 85:
            return '3.75(A-)'

        elif 75 <= self.nilaiAkhir() < 80:
            return '3.5(B+)'

        elif 70 <= self.nilaiAkhir() < 75:
            return '3(B)'

        elif 65 <= self.nilaiAkhir() < 70:
            return '2.75(B-)'

        elif 60 <= self.nilaiAkhir() < 65:
            return '2.5(C+)'

        elif 55 <= self.nilaiAkhir() < 60:
            return '2(C)'
        
        elif 40 <= self.nilaiAkhir() < 55:
            return '1(D)'

        elif 0 <= self.nilaiAkhir() < 40:
            return '0(E)'