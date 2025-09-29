-- 1. Importálja a tabla.sql fájl tartalmát az adatbázisába!

-- 2. Importálja az egyeni.sql fájl tartalmát az előző pontban létrehozott táblába!
	
-- 3. Adja meg az aranyérmesek nevét, olimpia idejét, helyszínét, időpont alapján növekvő sorrendben


-- 4. Adja meg a müncheni olimpia érmeseinek nevét, helyezését!


-- 5. Kárpáti Rudolf melyik olimpián és milyen helyezést ért el?


-- 5/a Kik voltak a Stockholmi olimpia érmesei?


-- 6. Hány dobogós helyezést értek el a magyarok?
SELECT COUNT(orszag)
FROM kard_egyeni
WHERE helyezes


-- 6/a Fuchs Jenő hány olimpiai érmet szerzett?
SELECT nev
From kard_egyeni
WHERE nev="Fuchs Jenő" and helyezes

-- 7. Melyik olimpián (év, város) szereztek az olaszok először érmet?


-- 8. Kik a magyar dobogósok? Mindenki csak egyszer szerepeljen a helyezések számával.
SELECT nev
FROM kard_egyeni
WHERE helyezes<=3 and nev=1


-- 9. Adja meg az 1900 és 1950 közötti nem magyar érmesek nevét, országát, időpontját, helyezését!

-- 10. Ki nyert többször aranyérmet?
SELECT nev
FROM kard_egyeni
WHERE helyezes(MAX), nev


-- 11. Melyik ország hány aranyérmet szerzett?
SELECT orszag
FROM kard_egyeni
WHERE orszag="aranyérem" and helyezes






-- 12. Melyik városban rendeztek többször olimpiát?


-- 13. 1950 előtt ki nyert azonos érmet Kovács Pállal?






	