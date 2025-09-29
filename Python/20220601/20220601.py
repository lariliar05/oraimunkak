class Valtozas:
    def __init__(self, sor):
        darabok=sor.strip('\n').split(';')
        datum=darabok[0].split('.')
        self.ev=int(datum[0])
        self.honap=int(datum[1])
        self.nap=int(datum[2])
        self.benzinar=int(darabok[1])
        self.gazolajar=int(darabok[2])

from cgi import print_environ
from math import *
from operator import le
from random import *


def feladat():
    szoveg=input("Kérek egy szöveget.")
    mh = "aáéőűúóüöoóíi"
    db=0
    for item in szoveg:
        if item.lower() in mh:
            db=+1
    print(" A magánhangzok száma:",db)
    nagy="QQWERTZUIOPŐÚÓÜÖŰÁÉLKJHGFDSAÍYXCVBNM"
    vanbenne=False
    for item in szoveg:
        if item in nagy:
            vanbenne=True
            break
    if vanbenne==True:
        print("Van")
    else:
        print("Nincs")

def feladat2():
    szamok=[]
    for i in range(1,50+1):
        szamok.append(randint(10,100))

    szetvalogat(szamok)

def szetvalogat(adatok):
    prim=[11,13,17,19,23,19,31,37,41,43,47,53,59,61,63,65,67,70,73,79,83,89,91,97]
    l1=[]
    l2=[]
    for item in adatok:
        if item in prim:
            l1.append(item)
        else:
            l2.append(item)
    print(l1)
    print(l2)

def uzemanyag():
    f=open("uzemanyag.txt","r")
    belovas=f.readlines
    
    f.close
    valtozasok=[]
    for item in belovas:
        valtozasok.append(Valtozas(item))
    print("4.", len(belovas))
    kulombsegek=[]
    for item in valtozasok:
        kulombsegek.append(abs(item.benzinar-iten.olajar))
    print("4.",min(kulombsegek))
    print("5.", kulombsegek.count(min(kulombsegek)))
    vanbenne=False
    for item in valtozasok:
        if item.honap==2 and item.nap==29
        vanbenne=True
        break








    







#feladat1()
feladat2()
uzemanyag()
