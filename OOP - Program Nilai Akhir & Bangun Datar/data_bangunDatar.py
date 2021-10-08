class persegi_panjang:
    
    def __init__(self, panjang, lebar):
        self.panjang = panjang
        self.lebar = lebar

    def keliling(self):
        keliling = float(2 * (self.panjang + self.lebar))
        return keliling

    def luas(self):
        luas = float(self.panjang * self.lebar)
        return luas

    def cetak(self):
        print('keliling: ' + str(self.keliling()) + 'cm²')
        print('luas: ' + str(self.luas()) + 'cm²')

class segitiga:

    def __init__(self, sisiA, sisiB, sisiC):
        self.sisiA = sisiA
        self.sisiB = sisiB
        self.sisiC = sisiC

    def keliling(self):
        keliling = self.sisiA + self.sisiB + self.sisiC
        return keliling

    def luas(self):
        luas = 0.5 * self.sisiA * self.sisiB
        return luas
        
    def cetak(self):
        print('keliling: ' + str(self.keliling()) + 'cm²')
        print('luas: ' + str(self.luas()) + 'cm²')

class trapesium:
    
    def __init__(self, a, b, s, t):
        self.a = a
        self.b = b
        self.s = s
        self.t = t

    def keliling(self):
        keliling = self.a + self.b + self.s + self.t
        return keliling

    def luas(self):
        luas = 0.5 * (self.a + self.b) * self.t
        return luas

    def cetak(self):
        print('keliling: ' + str(self.keliling()) + 'cm²')
        print('luas: ' + str(self.luas()) + 'cm²')