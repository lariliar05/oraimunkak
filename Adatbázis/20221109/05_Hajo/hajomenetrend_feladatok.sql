CREATE Database hajo
DEFAULT CHARSET set utf8
collate language utf8=Hungarian_CI



-- 1. Írassa ki a J1 hajójárat menetrendjét! Jelenjenek meg az indulási és érkezési állomások az időpontokkal együtt! 
Select honnan, hova, erkezik,
from hajo_menetrend
where jarat="J1";





-- 2. Listázza ki, hogy Balatonfüredről milyen állomások felé indulnak hajók 11 óra 30 perc és 12 óra 30 perc között (beleértve a megadott időpontokat is)!

Select hova,indul
From hajo_menetrend
where indul between '11:30' and '12:30';




-- 3. Adja meg, hogy a legkésőbben érkező hajó hánykor ér Balatonföldvárra?


Select érkezik
from hajo_menetrend
where hova=Balatonföldvár order by érkezik desk limit 1;

 -- vagy
Select erkezik
from hajo_menetrend
where hova= Balatonföldvár and érkezik=(Select max(érkezik) from hajo_menetrend)

-- 4. Az E2-es hajójáratnak mi a végállomása és hánykor érkezik oda!

-- vagy


-- 5. Mikor indul a legutolsó hajó?

Select indul
From hajo_menetrend
where indul last jarat



-- 6. Honnan indul az A4-es járat?

Select jarat
From hajo_menetrend
where azon


-- 7. Mely járatok érkeznek Siófokra?

Select erkezik
from hajo_menetrend
where Siófok

-- 8. Az M2-es járatnak mi a végállomása?
Select hova
From hajo_menetrend
where jarat: M2;

-- 9. Honnan indul az M6-os járat?
Select honnan
From hajo_menetrend
where jarat: M6;


-- 10. Adja meg a Szigligetről induló járatokat!

-- 11. Mikor érkezik hajó Badacsonyba?


-- 12. Mely járatok indulnak 11 óra után?

-- 13. Mely járatok érkeznek 17 óra után?

-- 14. Honnan indul a legelső hajó?

-- 15. Írassa ki azokat a járatokat, amelyek 11 órakor indulnak!
