0. Hozza létre a szeleromuvek adatbázist!
CREATE DATABASE szeleromuvek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci

--  Importálja az adatbázisába az 1_tablak.sql fájlt!
--  Importálja az adatbázisába a 2_helyszin.sql fájlt!
--  Importálja az adatbázisába a 3_megye.sql fájlt!
--  Importálja az adatbázisába a  4_torony.sql fájlt! 
KÉSZ!


-- 1. feladat: Készítsen lekérdezést, amely a széltoronnyal rendelkező települések nevét ábécérendben listázza ki!
SELECT nev FROM szeleromuvek_helyszin 
ORDER BY ASC


-- 2. feladat: Írassa ki lekérdezés segítségével azon települések nevét, ahol 2009 után állítottak széltornyot! A listában minden településnév csak egyszer szerepeljen!

SELECT nev FROM szeleromuvek_helyszin AND szeleromuvek_torony 
WHERE > 2009


-- 3. feladat: Készítsen lekérdezést, amely megadja annak a településnek a nevét és az üzembe helyezés évét, ahol először állítottak széltornyot! (Elegendő csak egy adatsort megjelenítenie.)


-- 4. feladat: Határozza meg régiónként, hogy hány településen van szélerőmű! A lista a települések száma szerint csökkenően jelenjen meg!


-- 5. feladat: Készítsen lekérdezést, amely településenként kiszámítja, hogy az ott található tornyoknak összesen mekkora a teljesítménye! A lekérdezés a települések nevét és a kiszámított teljesítményértékeket jelenítse meg!









