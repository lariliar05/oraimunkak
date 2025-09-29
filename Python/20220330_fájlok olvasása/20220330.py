class Vercsoport:
    def __init__(self, egysor): #konstruktor kedző értékek beállításáért felel.
        darabok=egysor.strip().split(" ")
        self.vercs=darabok[0]
        self.rh=darabok[1]




def cipo():
    f=open("cipomeret.txt","r")
    sor=f.readline()
    print(sor)
    f.close()
    meretek=sor.strip().split(' ')
    # strip levágja szóközöket az elejéről és a végéről
    # split feldarabolja a szóköz mentén
    # balról jobbra hajtja végre az utasításokat
    print(meretek)
    meret=[]
    for item in meretek:
        meret.append(int(item))
        print(item)
    print("db:", len(meret))
    print("min:", min(meret))
    print("max:", max(meret))
    print("összeg:", sum(meret))
    print("átlag",sum(meret)/len(meret))


def primek12ig():
    f=open("primek12ig.txt", "r")
    # soronként
    alma=[]
    while True:
        sor=f.readline()
        if len(sor)==0:
            break
        else:
            alma.append(int(sor))
            
    f.close()
    print(alma)
    for item in alma:
        print(item, end=" ")
    # soronként listába 
    f=open("primek12ig.txt", "r")
    listam=f.readlines()
    korte=[]
    for item in listam:
        korte.append(int(item))

    print(korte)
    
    
    f.close()




def vercsoport():
    f=open("vercsoportok.txt","r")
    beolvas=f.readlines()
    f.close()
    Vercsoportok=[]
    for item in beolvas:
        Vercsoportok.append(Vercsoport(item))
    print(Vercsoportok[0].vercs)
    print(Vercsoportok[0].rh)
    db_ab=0
    for item in Vercsoportok:
        if item.vercs.lower()=='ab':
            db_ab+=1
    print("Az AB vércsoportúak száma", db_ab)

    db_rh=0
    for item in Vercsoportok:
        if item.rh=="-":
            db_rh+=1
    print("Az rh faktorok száma",db_rh)
    print("A fálj", len(Vercsoportok))
    
    db_ab=0
    for itemm in Vercsoportok:
        if item.vercs=='0' and item.rh=='-':
            db_ab+=1
    print(" A nulla negatív vércsoportuak száma", db_ab)


    f=open("vercsoportok.txt")
    sor=f.read()
    print(sor.count('0 -'))
    f.close()






#cipo()
#primek12ig()
vercsoport()