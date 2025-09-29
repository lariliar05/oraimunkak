def feladat1(szam):
    
    if  szam<16:
        print("A szám tízszerese", szam*10)
    else:
        print("A szám harmada", round(szam/3,2))

def feladat2(a):
    if a%2==0:
        print("A megadott szám páros!" )
    else:
        print("A megadott szám páratlan! ")

def feladat3(b):
    if 10<b<50:
        if b//10==1:
            print("tízesek")
        elif b//10==2:
            print("huszasok")
        elif b//10==3:
            print("harmincasok")
        else:
            print("negyvenesek")

            
    else:
        print("A szám nem esik 10 és 50 közé. ")

def feladat4(c):
    if 12<c<25:
        if c%2==0:
            print("A szám páros ")
        else:
            print("A szám páratlan ")
    else:
        print("A szám nem 12 és 25 közé ")
    print("A másik megoldás ")
    if 12<c<25 and c%2==0:
        print("A szám páros ")
    else:
        print("A szám nem esik az intervallumban vagy nem páros ")

def feladatc1():
    for i in range(1,17+1):
        print(i*3, end=" ")

def feladatc2():
    for i in range(1,16+1):
        print(pow(2,i), end=" ")

def feladatc3():
    for i in range(1,6):
        for j in range(1,16):
            print(i*j, end=" ")
        print()

def feladatc4():
    for i in range(1,25+1):
        if i*7%4==0:
            print(i*7, end=" ")

def feladatc5():
    a=2
    b=3
    c=5
    print("a=",a,"b=",b,"c=",c,"V=", a*b*c)
    for i in range(1,5):
        a=a+1
        b=b+2
        c=c+3
        print("a=",a,"b=",b,"c=",c,"V=", a*b*c)

def feladatc6():
    for i in range(15,92+1):
        print(i, end=" ")

def feladatc7():
    for i in range(100,400+1):
        if i//4:
            print(i, end=" ")

def feladatc10():
    a=5
    A=6*a*a
    lep=17
    print("A=",6*a*a)
    for i in range():
        lep=a+2;
        print("A=",6*a*a)
        










# itt kezdödik a főprogram
szam=int(input("Kérek egy számot! "))
#feladat1(szam)
#feladat2(szam)
#feladat3(szam)
#feladat4(szam)
#feladatc1()
#feladatc2()
#feladatc3()
#feladatc4()
#feladatc5()
#feladatc6()
#feladatc7() 
feladatc10()