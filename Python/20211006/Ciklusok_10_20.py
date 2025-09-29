#13.feladat Írasd ki 2 első tizenhat pozitív egész kitevőjű hatványát (2, 4, 8, 16, 32,…)
'''
for i in range(1,16):
    print(pow(2,i), end=" ")
print()
for i in range(i,17):
    print("2 a",i, "Hatványon:", pow(2,i))
#Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóinak az összegét!
a=int(input("Kérek egy pozitív egész számot!"))
osszeg=0
for i in range(1,a):
    if a%i==0:
        osszeg+=i
print("A(z)",a, "osztoinak összege", osszeg)
'''
for i in range(-30,30):
    print(i,)






