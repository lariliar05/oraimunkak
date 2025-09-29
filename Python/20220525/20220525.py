class Magassag:
    def __init__(self, egysor):
        darabok=egysor.strip('\n').split('\t')
        self.orszag = darabok[0]
        self.foldrajzi_hely = darabok[1]
        self.magassag = int(darabok[2])
from math import *



"""
def feladat1():
    a=float(input("Kérem az a oldalt! "))
    b=float(input("Kérem az b oldalt! "))
    c=float(input("Kérem az c oldalt! "))
    f=sqrt(a*a+b*b+c*c)
    print("f=",f)


def feladat2():
    mondat = input("Kérek egy mondatot. ")
    felhasznalo = input("Kérek egy felhasználot. ")
    darab=(mondat.count(felhasznalo))
    print("Ennyi felhasználot tartalmaz: ", darab)
"""
def feladat3():
    f=open("tengerszint.txt",'r')
    beolvas=f.readlines()
    f.close()
    orszagok=[]
    for item in beolvas:
        orszagok.append(Magassag(item))
    print("10.", len(orszagok))
    db5000=0
    for item in orszagok:
        if item.magassag>5000:
            db5000=+1
    print(db5000)
    vanbenne=False
    for item in orszagok:
        if item.magassag==3000:
            vanbenne=True
        if vanbenne==True:
            print("van")
        else:
            print("nincs")
    g=open("magasak.txt")
    for item in orszagok():
        if item.magassag>7500:
            g.write(item.orszag+"")
    










#feladat1()
#feladat2()
feladat3()