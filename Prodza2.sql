Create database Prodza

use Prodza

Create Table Zaposleni
( id int Primary Key Identity(1,1),
  ime nvarchar(20) not null,
  prezime nvarchar(20) not null,
  zaposleni_email nvarchar(50) Not Null,
  zaposleni_loz nvarchar(100) Not Null,
  broj_telefona nvarchar (12),
  plata int
)

insert into Zaposleni(ime, prezime, zaposleni_email, zaposleni_loz, broj_telefona) values
('Ime1', 'P1', 'jaisamoja@gmail.com', 'jaisamoja', '069'),
('Ime2', 'P2', 'jaisamoja@gmail.com', 'jaisamoja', '069'),
('Ime3', 'P3', 'jaisamoja@gmail.com', 'jaisamoja', '069'),
('Ime4', 'P4', 'jaisamoja@gmail.com', 'jaisamoja', '069');

insert into Zaposleni(ime, prezime, zaposleni_email, zaposleni_loz, broj_telefona) values
('Ime1', 'P1', '1', '1', '069');


Create Table Proizvod
(	proizvod_id int Primary Key Identity(1,1),
	naziv_proizvoda nvarchar(100) Not Null,
	cena_proizvoda int not null,
	rok_trajanja date ,
)

insert into Proizvod (naziv_proizvoda, cena_proizvoda) values
('CocaCola', 100),
('Voda Voda Vodica', 69),
('lubenica', 600),
('Kikiriki puter', 200),
('Banana', 100),
('Sladoled Frikom', 120),
('Saandale', 500);


Create Table Kupac
(
  id int Primary Key Identity(1,1),
  ime nvarchar(20) not null,
  prezime nvarchar(20) not null,
  mail nvarchar(30),
  broj_telefona nvarchar (12),
)

drop table Kupac

insert into Kupac (ime, prezime, broj_telefona, mail) values
('Ime kupca1', 'Prezime kupca1', '069','staGod'),
('Ime kupca2', 'Prezime kupca2', '069' ,'staGod'),
('Ime kupca3', 'Prezime kupca3', '069','staGod'),
('Ime kupca4', 'Prezime kupca4', '069','staGod'),
('Ime kupca5', 'Prezime kupca5', '069','staGod'),
('Ime kupca6', 'Prezime kupca6', '069','staGod'),
('Ime kupca7', 'Prezime kupca7', '069','staGod'),
('Ime kupca8', 'Prezime kupca8', '069','staGod');



create table Prodavnica
(
	id int Primary Key Identity,
	naziv nvarchar(20),
	adresa nvarchar(20),
	kontakt_telefon nvarchar(20),
)



insert into Prodavnica (naziv, adresa, kontakt_telefon) values
('Kod micka', 'adresa prodavnice1','069'),
('Tamara', 'adresa prodavnice2','069'),
('Nana Shop', 'adresa prodavnice3','069');



Create table Kupovina
(
	id int Primary Key Identity,
	prodavnica_id int,
	zaposleni_id int,
	kupac_id int,
	proizvod_id int,
	kolicina int,
	datum date
	FOREIGN KEY (Prodavnica_id) REFERENCES Prodavnica(id),
	FOREIGN KEY (zaposleni_id) REFERENCES Zaposleni(id),
	FOREIGN KEY (kupac_id) REFERENCES Kupac(id),
	FOREIGN KEY (proizvod_id) REFERENCES Proizvod(proizvod_id),
)

insert into Kupovina (prodavnica_id, zaposleni_id, kupac_id, proizvod_id, kolicina) values
(3, 1,6, 7, 2),
(1, 4, 7, 2, 1),
(3, 3, 3, 3, 3),
(1,1,1,1,1),
(2, 2, 2 ,2 ,2),
(2, 1, 1, 4, 1),
(3, 3, 3, 3, 3),
(1,3, 5, 2, 2),
(1, 4, 8, 7, 8);

