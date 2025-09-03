                   --SQL SERVER PROGRAMI TANITIMI

--Microsoft un �r�n�d�r.
--Veri takibi i�in genellikle sql kullan�l�r.
--SQL Server VS gibi bir veritaban� y�netim sistemi olup (SSMS)Management Studio ile �al���r.
--SSMS bir veritaban� y�netim sistemini y�netmek i�in kullan�lan bir GUI arac�d�r.
/*
Download i�lemi: Google - Sql Server Download 2022 - Download Developer Sql
Sql Server Kurulum (EXE): Basic - install
SSMS (Sql Server Management Studio) Download:
   1- Sql Server - Basic - install ssms - google ssms - 21 ssms install
   2- google ssms download - 21 ssms install
SSMS Kurulum (EXE): Yapay zeka 
*/

                        --Ba�lant� Ekran�
/*
Ba�lant� adresine : Localhost / .  yaz�l�p ba�lan�l�r.

Authentication (Yetkinlik) : Ki�isel Bilgisayar �m demek i�in -> Windows Authentication
          Ba�ka server a ba�lanmak i�in ip / sap no name girilerek ba�lant� sa�lan�r.
*/

            --Object Explorer ve Men� Tan�t�m�
/*
Daha �nce i�lem yap�lmad�ysa veritaban� bo� gelebilir.
Yeni veritaban� olu�turmak i�in -> Databases - New databases
De�i�ken isimleri olu�tururken T�rk�e isimler kullanabiliriz fakat bo�luk ve T�rk�e karakterler kullanmamal�y�z.
Limited - Vt boyutu ne olmal�? Verilen alan �nemli ��nk� yer yetersizse vt �al��maz ve durur.
Path : Dosya yolu
*/

-- sql de tek sat�rl�k yorum i�in 2 tire kulan�l�r
/*
�oklu yorum sat�r�
i�in
yine / * * / kullan�l�r.
*/

/*
Database olu�turma ve ekleme, silmeden sonra Databases k�s�mlar�n� refresh edilmeli, refresh yap�lmazsa vt yok gibi hatalar ��kabilir.

Komutlarda B�y�k-K���k harf farketmez!
Vt isimleri isimlendirme kurallar�na uygun yaz�lmal�

Veri tan�mlama (veri saklanmas� i�in nesneler, pros�d�r, fonksiyonlar�n) tablolar�nda yap�lan de�i�iklik t�rleri:
Yeni tablo olu�turma : CREATE TABLE
Tabloda de�i�iklik yapma : ALTER TABLE
Tabloyu silmek : DROP TABLE
komutlar� kullan�l�r.
*/

/*
--Uzun yaz�lar� ekrana s��d�r�p, alt sat�rdan devam etmesi : Tools - Options -Text Editor - All Languages - Word Wrap (Sarmalama) - Active

  SQL komutlar� kullan�m ama�lar�na g�re �� genel kategoriye ayr�l�r. Bunlar:
        1-Veri Tan�mlama Dili (DDL - Data Definition Language): Tablo olu�turma, de�i�tirme ve silme i�lemleri i�in kullan�yoruz.
        2-Veri ��leme Dili (DML - Data Manipulation Language): Veri girmek, de�i�tirmek, silmek ve verileri almak i�in kullan�lan komutlard�r.
        3-Veri Kontrol Dili (DCL - Data Control Language): Veritaban� kullan�c�s� veya rol� ile ilgili izinlerin d�zenlenmesini sa�lar.
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
--Mouse ile yap�labilen k�sm�n kod ile yap�lan �ekli:
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

Alter Table Personel Add Ders varchar(50), Konu varchar(50) --Tek seferde 1 den fazla kolon eklemek istenirse

Alter Table Personel Alter Column PersonelId int not null --kolonda g�ncelleme yapt�k

Alter TABLE Personel DROP COLUMN Email; --kolon silinir

Alter TABLE Personel ALTER COLUMN Soyadi nvarchar(75);

ALTER TABLE Personel ADD TCNo varchar(11); --tabloya kolon ekleme
*/