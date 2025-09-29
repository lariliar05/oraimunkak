
def feladat17():
    szo=input("Kérek egy szót! ")
    print("A szó", len(szo) ," karakterből áll. ")

def feladat18():
    szo=input("Kérek egy szót! ")
    e=0
    for item in szo:
        if item=='e':
            e+=1
    
    print("A szóban ennyi",e,"  E karakter van. ")
    #print("A szó", szo.count('e') e betűt tartalmaza)

def feladat19():
    szo=input("Kérek egy szót! ")
    maganhangzok="aáiíoóőöüűúueéAÁIÍOÓÖŐÚUŰÜEÉ"
    MH=0
    for item in szo:
        if item in maganhangzok:
            MH+=1
    print("A szóban lévő magánhangzok száma", MH)
    
def feladat20(): #hiba
    mondat=input("Kérek egy mondatot! ")
    karakter=0
    for item in mondat:
        if item in karakter:
            karakter+=1
    print("A mondat",karakter,"ennyi betüből áll ")
    
def feladat21(): #hiba
    mondat=input("Kérek egy mondatot! ")
    e=0
    for item in mondat:
        #for item=='e':
        e+=1
    #print("Ennyi E",e,betü van benne)

def feladat24():
    mondat=input("Kérek egy mondatot! ")
    szavak=mondat.split(' ') #szavak lista
    szavakhossza=[]
    print("A mondat",len(szavak), "szóbol áll.")
    for item in szavak:
        print(item, "hossza", len(item))
        szavakhossza.append(len(item))
    for item in szavak:
        if len(item)==max(szavakhossza):
            print("A leghosszabb szó",item)

def feladat23():
    mondat=input("Kérek egy mondatot! ")
    szo=0
    for item in mondat:
        for item=='szo':
            szo+=1
     print("A mondat ennyi",M," szóbol áll. ")

def feladat26():
    









#Főprogram
#feladat17()
#feladat18()
#feladat19()
#feladat20()
#feladat21()
#feladat24()
#feladat23()
feladat26()