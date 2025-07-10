-- sql de tek sat�rl�k yorum i�in 2 tire kulan�l�r
/*
�oklu yorum sat�r�
i�in
yine / * * / kullan�l�r.
*/

/*
* SQL komutlar� kullan�m ama�lar�na g�re �� genel kategoriye ayr�l�r. Bunlar:
1-Veri Tan�mlama Dili (DDL- Data Definition Language): Tablo olu�turma, de�i�tirme ve silme i�lemleri i�in kullan�yoruz.
2-Veri ��leme Dili (DML Data Manipulation Language): Veri girmek, de�i�tirmek, silmek ve verileri almak i�in kullan�lan komutlar�
3-Veri Kontrol Dili (DCL-Data Control Language): Veritaban� kullan�c�s� veya rol� ile ilgili izinlerin d�zenlenmesini sa�lar.
*/
-- SQL KOMUTLARI
--Temel Sql Komutlar�
--Sql Komutlar�yla Veritaban� olu�turma
-- create database OrnekDb -- komutu �al��t�rmak i�in �st men�den execute veya k�sayolu f5

--Veritaban� isim de�i�tirme
--alter database OrnekDb Modify name=OrnekDatabase

--Veritaban� silme
--drop database OrnekDatabase

--Sql Kod ile Veritaban�na Tablo Ekleme
/*
create database OrnekDb
go
use OrnekDb --olu�turulan ornekDb veritaban�n� kullan
go
CREATE TABLE Personel (PersonelId int, Adi varchar(50), Soyadi varchar(50)); --ornekDb veritaban�na Personel ad�yla tablo ekle

--bu �ekilde var olan tabloya veri ekleyebiliriz
use OrnekDb --ornekdb veritaban�n� kullan
go --sonraki ad�ma ge�
create table Ogrenciler (Id int not null, Adi varchar (50) not null, Soyadi varchar(50) null); --tabloyu verdi�imiz alanlara g�re olu�tur alanlar�n bo� ge�ilme durumlar�n� da kulland�k

--Sql ile tabloda de�i�iklik yapma -alter ile-
Alter Table Personel Add Email varchar(250)

Alter Table Personel Alter Column Email varchar(50)

Alter Table Personel Add Ders varchar(50), Konu(50) --Tek seferde 1 den fazla kolon ekleme
Alter Table Personel Alter Column PersonelId int not null
Alter TABLE Personel Drop Column Email;
Alter TABLE Personel Alter Column Soyadi nvarchar(75)*/