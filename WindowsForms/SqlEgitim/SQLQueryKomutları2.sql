-- sql de tek sat�rl�k yorum i�in 2 tire kulan�l�r
/*
�oklu yorum sat�r�
i�in
yine / * * / kullan�l�r.
*/

/*
Database olu�turma ve ekleme, silmeden sonra Databases k�s�mlar�n� refresh edilmeli, refresh yap�lmazsa vt yok gibi hatalar ��kabilir.

Komutlarda B�y�k-K���k harf farketmez!
Vt isimleri kod kurallar�na uygun yaz�lmal�

Veri tan�mlama (veri saklanmas� i�in nesneler, pros�d�r, fonksiyonlar�n) tablolar�nda yap�lan de�i�iklik t�rleri:
Yeni tablo olu�turma : CREATE TABLE
Tabloda de�i�iklik yapma : ALTER TABLE
Tabloyu silmek : DROP TABLE
komutlar� kullan�l�r.
*/

/*
--Uzun yaz�lar� ekrana s��d�r�p, alt sat�rdan devam etmesi : Tools - Options -Text Editor - All Languages - Word Wrap (Sarmalama) - Active

  SQL komutlar� kullan�m ama�lar�na g�re �� genel kategoriye ayr�l�r. Bunlar:
        1-Veri Tan�mlama Dili (DDL- Data Definition Language): Tablo olu�turma, de�i�tirme ve silme i�lemleri i�in kullan�yoruz.
        2-Veri ��leme Dili (DML Data Manipulation Language): Veri girmek, de�i�tirmek, silmek ve verileri almak i�in kullan�lan komutlard�r.
        3-Veri Kontrol Dili (DCL-Data Control Language): Veritaban� kullan�c�s� veya rol� ile ilgili izinlerin d�zenlenmesini sa�lar.
*/

                     -- SQL KOMUTLARI
--!!Avaible database �al��t���m�z database olmal�, yoksa kod �al��maz!!

--Execute butonu: Girilen komutlar� �al��t�r�r.
                          --Temel Sql Komutlar�
                --Sql Komutlar�yla Veritaban� olu�turma
-- create database OrnekDb -- komutu �al��t�rmak i�in �st men�den execute veya k�sayolu f5

     --Veritaban� isim de�i�tirme
--alter database OrnekDb Modify name=OrnekDatabase

     --Veritaban� silme
--drop database OrnekDatabase

--�nce db ad� sonra tablo ad� yaz�l�p komut se�ilir. Db ad� se�iliyse tablo ad� yaz�larak istenilen i�lem komutu yaz�l�p �al��t�r�l�r. 

     --Sql Kod ile Veritaban�na Tablo Ekleme
--Mause ile yap�labilen k�sm�n kod ile yap�lan �ekli:
/*
create database OrnekDb
go
use OrnekDb --olu�turulan ornekDb veritaban�n� kullan
go
CREATE TABLE Personel (PersonelId int, Adi varchar(50), Soyadi varchar(50)); --ornekDb veritaban�na Personel ad�nda tablo ekle

--bu �ekilde var olan tabloya veri ekleyebiliriz
use OrnekDb --ornekdb veritaban�n� kullan
go --sonraki ad�ma ge�
create table Ogrenciler (Id int not null, Adi varchar (50) not null, Soyadi varchar(50) null); --tabloyu verdi�imiz alanlara g�re olu�tur alanlar�n bo� ge�ilme durumlar�n� da kulland�k

--Sql de db / tabloda de�i�iklik yapma (var olan tabloda de�i�iklik yapma) -alter ile-

Alter Table Personel Add Email varchar(250) --kolon ekleme yap�ld�

Alter Table Personel Alter Column Email varchar(50) --kolonu g�ncelledik 250 - 50

Alter Table Personel Add Ders varchar(50), Konu(50) --Tek seferde 1 den fazla kolon eklemek istenirse

Alter Table Personel Alter Column PersonelId int not null --kolonda g�ncelleme yapt�k

Alter TABLE Personel DROP COLUMN Email; --kolon silinir

Alter TABLE Personel ALTER COLUMN Soyadi nvarchar(75);

ALTER TABLE Personel ADD TCNo varchar(11); --tabloya kolon ekleme
*/