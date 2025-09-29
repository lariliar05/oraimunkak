class Dobas:
    def __init__(self, egysor):
        darabok=egysor.strip().split(' ')
        self.elso=int(darabok[0])
        self.masodik=int(darabok[1])
        self.harmadik=int(darabok[2])
f=open("tarsas.txt","r")
beolvas=f.readlines()
f.close()
dobasok=[]
for item in beolvas:
    dobasok.append(Dobas(item))
print("Ennyi dobása van"len(dobasok)