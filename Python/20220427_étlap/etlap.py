class Etel:
    def __init__(self, egysor):
        darabok=egysor.strip('\n').split('\t')
        self.nev=darabok[0]
        self.ar=int(darabok[1])
        self.tipus=darabok[2]




f=open('etelek.txt','r')
beolvas=f.readlines()
f.close()
print(beolvas[0])
etelek=[]
for item in beolvas:
    etelek.append(Etel(item))
print(etelek[0].nev)
print(etelek[0].ar)
print(etelek[0].tipus)
print('2. feladat:', len(etelek), 'féle ételt kinál.')
osszeg_leves=0
db_leves=0
for item in etelek:
    if item.tipus.lower()=='leves':
        osszeg_leves=osszeg_leves+item.ar
        db_leves+=1
print('3. felaldat: A leves átlagosan', osszeg_leves/db_leves,'forintba kerül.')




