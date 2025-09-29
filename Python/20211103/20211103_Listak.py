from random import *
'''
def alapok():
   
listam=[5]
elemekszama=int(input('Add meg az elemek számát!'))
for i in range(0, elemekszama):
    listam.append(randint(1,100))
print(listam)
print(listam[0])
print(listam[-1]) #Utolsó elem
print(listam[0:4]) #0,1,2,3 indexű elemeket írja ki
print(listam[2:5]) #2,3,4 indexű elemet adja
print(listam[7:]) #7-es indeyűtől a végéig
print(listam[:5]) #0-tól a 4-es indexig
listam[5]='alma'
print(listam)
for item in listam:
    print(item, end=" ")
print()
print(len(listam)) #elemek száma
print(listam.index('alma')) #indeyét fogja megadni
#print(listam.index('körte')) # a körte index
listam.pop() #utolsó elem eltávolítására szolgál a POP
listam.remove('alma') # adott elem eltávolítása
listam.pop(3)
#del listam[2] #törölte a listát 
#listam.clear() #Tisztitott eggyet
listam.reverse() #fordított sorrend
listam.sort() #sorba rendezfor item in listam:
listam.insert(3,'körte') # adott indexet helyre beszúrása
    print(item, end=" ")
print()
'''


def feladat1():
    elemszam=int(input("Kérem az elemek számát"))
    szamok=[]
    for i in range(1,elemszam):
        szamok.append(randint(1,50))
    print(szamok)
    prl=0
    for item in szamok:
        if item%2==1:
            prl+=1
    print("A páratlan száma", prl)

def feladat2():
    elemszam=int(input("Kérem az elemek számát"))
    szamok=[]
    for i in range(1,elemszam):
        szamok.append(randint(1,50))
    print(szamok)
    osszeg=0
    parosok=[]
    for item in szamok:
        if item %2==0:
            osszeg+=item
            parosok.append(item)
    print("A párosok összege",osszeg)
    print(parosok)
    print(sum(parosok))

def feladat3():
    lemszam=int(input("Kérem az elemek számát"))
    szamok=[]
    for i in range(1,elemszam):
        szamok.append(randint(1,50))
    print(szamok)
    for i in range(0,len(szamok)): #itt az i az index
        if item %2==0:
            print(szamok[i],'sorszáma:', i+1)







#feladat1()
#feladat2()
#feladat3()























