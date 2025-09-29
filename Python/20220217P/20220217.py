#listák
#listanév7[]
#emelemei indexeljük, 0-tól kezdödik az indexelés: listanév[3]
#elemek hozzáadása: listanév.append(érték)
#listanév[0]="alma", listanév[1]=12.3
#listanév[érték1, érték2, érték3,....]
#tetszőleges típusú adatok tartalmazhat.
#sum(), min(), max() számtípus

def feladat1():
    #első 20 négyzetszám listába tétele.
    negyeztszamok=["alma","körte"]
    for i in range(1,20+1):
        negyeztszamok.append(pow(i,2))
    print(negyeztszamok)
    for item in negyeztszamok:
        print(item,end=" ")

def feladat2():
    harmasszorzo=[]
    for i in range(1,30+1):
         harmasszorzo.append(i*3)
    for item in harmasszorzo:
        print(item, end=" ")
        print()
    print(len(harmasszorzo))
    print(sum(harmasszorzo))
    print(min(harmasszorzo))
    print(max(harmasszorzo))
















#feladat1()
#feladat2()










