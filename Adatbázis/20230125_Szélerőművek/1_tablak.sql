CREATE TABLE szeleromuvek_helyszin (
  id int(2) PRIMARY KEY AUTO_INCREMENT NOT NULL,
  nev varchar(30)  NOT NULL,
  megyeid int(2) NOT NULL
  );

CREATE TABLE szeleromuvek_megye (
  id int(2) PRIMARY KEY AUTO_INCREMENT NOT NULL,
  nev varchar(30) ,
  regio varchar(30) NOT NULL
);

CREATE TABLE szeleromuvek_torony (
  id int(2) PRIMARY KEY AUTO_INCREMENT NOT NULL,
  darab int(3) NOT NULL,
  teljesitmeny int(5) NOT NULL,
  kezdev int(5) NOT NULL,
  helyszinid int(2) NOT NULL
  );