from math import *
from random import * 

def feladat1_5():
    a="alma"
    print(type(a))

    
    b="W"
    print(type(b))

    
    c=12
    print(type(c))

   
    d=1.5
    print(type(d))  

    

    e=True
    print(type(e))


def feladat6_9():
    szo=input("Kérek egy szót. ")
    print(szo)


    mondat=input("Kérek egy mondatot ")
    print(mondat)


    karakter=input("Kérek egy karaktert ")
    print(karakter)


    egész=int(input("Kérek egy egész számot "))
    print(egész, type(egész))

def feladat10():
    valós=float(input("Kérek egy válós számot "))
    print(valós, type(valós))
    print("2 *",valós,"=",2*valós)
    print("PI *",valós,"=",pi*valós)
    print("harmadik hatványa:", pow(valós,3))
    print("négyzetgyöke:",sqrt(valós))
    print("gyöke, két tízedesre kerekítés:", round(sqrt(valós),2))


def feladat11_16():
    veletlen=randint(10,50)
    print(veletlen)

    veletlen=randint(1,10)
    print(veletlen)

    veletlen=random()
    print(veletlen)

    veletlen=randrange(10,50+1)
    print(veletlen)

    egész=int(input("Kérek egy egész számot "))
    if egész % 2 == 0:
        print("A szám páros ")
    else:
        print("A szám páratlan ")
    if egész>0:
        print("A szám pozitív ")
    elif egész<0:
        print("A szám negatív ")
    else: 
        print("A szám null ")
    if egész>30:
        print("A szám nagyobb mint 30 ")
    else:
        print("A szám nem nagyobb, mint 30 ")
    
    egyik=int(input("Kérek egy egész számot "))
    másik=int(input("Kérek egy másik egész számot "))
    if egyik>másik:
        print("A nagyobb szám ", egyik)
    elif egyik<másik:
        print("A nagyobb szám ", másik)
    else:
        print("A két szám egyenlő ")
    print("A kisebb szám",(egyik,másik))



#itt kezdődik a főprogram
#feladat1_5()
#feladat6_9()
#feladat10()
feladat11_16()





