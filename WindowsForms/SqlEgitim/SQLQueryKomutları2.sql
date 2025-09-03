                   --SQL SERVER PROGRAMI TANITIMI

--Microsoft un ürünüdür.
--Veri takibi için genellikle sql kullanýlýr.
--SQL Server VS gibi bir veritabaný yönetim sistemi olup (SSMS)Management Studio ile çalýþýr.
--SSMS bir veritabaný yönetim sistemini yönetmek için kullanýlan bir GUI aracýdýr.
/*
Download iþlemi: Google - Sql Server Download 2022 - Download Developer Sql
Sql Server Kurulum (EXE): Basic - install
SSMS (Sql Server Management Studio) Download:
   1- Sql Server - Basic - install ssms - google ssms - 21 ssms install
   2- google ssms download - 21 ssms install
SSMS Kurulum (EXE): Yapay zeka 
*/

                        --Baðlantý Ekraný
/*
Baðlantý adresine : Localhost / .  yazýlýp baðlanýlýr.

Authentication (Yetkinlik) : Kiþisel Bilgisayar ým demek için -> Windows Authentication
          Baþka server a baðlanmak için ip / sap no name girilerek baðlantý saðlanýr.
*/

            --Object Explorer ve Menü Tanýtýmý
/*
Daha önce iþlem yapýlmadýysa veritabaný boþ gelebilir.
Yeni veritabaný oluþturmak için -> Databases - New databases
Deðiþken isimleri oluþtururken Türkçe isimler kullanabiliriz fakat boþluk ve Türkçe karakterler kullanmamalýyýz.
Limited - Vt boyutu ne olmalý? Verilen alan önemli çünkü yer yetersizse vt çalýþmaz ve durur.
Path : Dosya yolu
*/

-- sql de tek satýrlýk yorum için 2 tire kulanýlýr
/*
çoklu yorum satýrý
için
yine / * * / kullanýlýr.
*/

/*
Database oluþturma ve ekleme, silmeden sonra Databases kýsýmlarýný refresh edilmeli, refresh yapýlmazsa vt yok gibi hatalar çýkabilir.

Komutlarda Büyük-Küçük harf farketmez!
Vt isimleri isimlendirme kurallarýna uygun yazýlmalý

Veri tanýmlama (veri saklanmasý için nesneler, prosödür, fonksiyonlarýn) tablolarýnda yapýlan deðiþiklik türleri:
Yeni tablo oluþturma : CREATE TABLE
Tabloda deðiþiklik yapma : ALTER TABLE
Tabloyu silmek : DROP TABLE
komutlarý kullanýlýr.
*/

/*
--Uzun yazýlarý ekrana sýðdýrýp, alt satýrdan devam etmesi : Tools - Options -Text Editor - All Languages - Word Wrap (Sarmalama) - Active

  SQL komutlarý kullaným amaçlarýna göre üç genel kategoriye ayrýlýr. Bunlar:
        1-Veri Tanýmlama Dili (DDL - Data Definition Language): Tablo oluþturma, deðiþtirme ve silme iþlemleri için kullanýyoruz.
        2-Veri Ýþleme Dili (DML - Data Manipulation Language): Veri girmek, deðiþtirmek, silmek ve verileri almak için kullanýlan komutlardýr.
        3-Veri Kontrol Dili (DCL - Data Control Language): Veritabaný kullanýcýsý veya rolü ile ilgili izinlerin düzenlenmesini saðlar.
*/

                          -- SQL KOMUTLARI
--!!Avaible database çalýþtýðýmýz database olmalý, yoksa kod çalýþmaz!!
--Execute butonu: Girilen komutlarý çalýþtýrýr.

                          --Temel Sql Komutlarý
                --Sql Komutlarýyla Veritabaný oluþturma
-- create database OrnekDb -- komutu çalýþtýrmak için üst menüden execute veya kýsayolu f5

                --Veritabaný isim deðiþtirme
--alter database OrnekDb Modify name=OrnekDatabase

                --Veritabaný silme
--drop database OrnekDatabase

--Önce db adý sonra tablo adý yazýlýp komut seçilir. Db adý seçiliyse tablo adý yazýlarak istenilen iþlem komutu yazýlýp çalýþtýrýlýr. 

                --Sql Kod ile Veritabanýna Tablo Ekleme
--Mouse ile yapýlabilen kýsmýn kod ile yapýlan þekli:
/*
create database OrnekDb
go
use OrnekDb --oluþturulan ornekDb veritabanýný kullan
go
CREATE TABLE Personel (PersonelId int, Adi varchar(50), Soyadi varchar(50)); --ornekDb veritabanýna Personel adýnda tablo ekle

--bu þekilde var olan tabloya veri ekleyebiliriz
use OrnekDb --ornekdb veritabanýný kullan
go --sonraki adýma geç
create table Ogrenciler (Id int not null, Adi varchar (50) not null, Soyadi varchar(50) null); --tabloyu verdiðimiz alanlara göre oluþtur alanlarýn boþ geçilme durumlarýný da kullandýk

--Sql de db / tabloda deðiþiklik yapma (var olan tabloda deðiþiklik yapma) -alter ile-

Alter Table Personel Add Email varchar(250) --kolon ekleme yapýldý

Alter Table Personel Alter Column Email varchar(50) --kolonu güncelledik 250 - 50

Alter Table Personel Add Ders varchar(50), Konu varchar(50) --Tek seferde 1 den fazla kolon eklemek istenirse

Alter Table Personel Alter Column PersonelId int not null --kolonda güncelleme yaptýk

Alter TABLE Personel DROP COLUMN Email; --kolon silinir

Alter TABLE Personel ALTER COLUMN Soyadi nvarchar(75);

ALTER TABLE Personel ADD TCNo varchar(11); --tabloya kolon ekleme
*/