


from random import  *

def feladat1():
    f=open("elsoiras.txt", "w", encoding="utf8")
    f.write("alma" +"\n")
    f.writelines("körte"+"\r")
    f.writelines("szilva")
    f.close()


def feladat2():
    f=open("szamok10ig.txt", "w")
    for i in range(1,10+1):
       if i<10:
           f.write(str(i)+", ")

       else:
           f.write(str(i))     
       
    
    
    f.close()

def feladat3():
    f=open("szamokegymasalatt.txt", "w")
    for i in range(1,10+1):
        if i<10:

            f.write(str(i)+"\r")
        else: 
            f.write(str(i))
                




    f.close()


def feladat4():
    f=open("negyzetszam.txt", "w")
    for i in range(1,11):
        if i<10:
           f.write(str(pow(i,2))+"\r")
        else:
            f.write(str(pow(i,2)))
        
        
    f.close()




def feladat5():
    f=open("veletlenek.txt" ,"w")
    for i in range(1,11):
        if random.randint(100,201):
            f.write(str(i)+"\r")
        else:
            f.write(str(i))



    f.close()



     








#feladat1()
#feladat2()
#feladat3()
#feladat4()
feladat5()

