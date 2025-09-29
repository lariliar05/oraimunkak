from random import * 
from math import *

def feladat31():
    for i in range(10,100+1):
        if i %7==3:
            print(i, end=" ")
        print()

def feladat32():
    szovegeslista=[]
    szovegeslista.append('alma')
    szovegeslista.append('körte')
    szovegeslista.append('szilva')
    szovegeslista.append('sárgabarack')
    szovegeslista.append('eper')
    print('lista elemeinek száma', len(szovegeslista))
    print(szovegeslista)
    for item in szovegeslista:
        print(item, end=' ')
    print()

def feladat34():
    karakterlista=[]
    karakterlista.append('1')
    karakterlista.append('2')
    karakterlista.append('B')
    karakterlista.append('S')
    karakterlista.append('Z')
    print(karakterlista)
    for item in karakterlista:
        print(item, end=' ')
def feladat36():
    egészlista=[2,4,6,8,10]
    egészlista.append(14)
    egészlista.append(randint(0,100))
    egészlista.append(int(input('kérek egy számot')))
    for i in range (5):
        for item in egészlista:
            print(item, end=' ')
 


def feladat40():
    véletlenek=[]
    for i in range(15):
        véletlenek.append(randint,(10,50+1))
    for item in véletlenek:
        print(item, end=' ')
    print('legnagyobb szám:', max(véletlenek))
    print('legkisebb szám:', min(véletlenek))
    print('számok összege', sum(véletlenek))


    
    párosok=[]
    for item in véletlenek:
        item %2=0
    
    for item in párosok:
        print(item, end=' ')

    for item in párosok:
        print('Páros Számok Összege', sum(párosok))

    for item in párosok:
        print('A Legnagyobb páros szám', max(párosok))





#itt kezdodik a főprogram
#feladat31()
#feladat32()
#feladat34()
#feladat36()
#feladat40





