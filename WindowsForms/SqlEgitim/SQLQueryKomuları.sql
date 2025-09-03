                    --CRUD ��LEMLER�
--Tablolara kay�t ekleme, kay�tlar� �ekme, kay�t g�ncelleme ve silme i�lemlerine k�saca C(Create), R(Read), U(Update), D(Delete) deriz.

--Tabloya veri ekleme
--Insert Into Personel (PersonelID, Adi, Soyadi) values (1, 'Mehmet', 'CENG�Z')

--Eklenen Verileri �ekme
--select * from Personel

--Tabloda T�m Alanlara Veri Ekleme
--Insert Into Personel values (4, 'Memet', 'alii', null, null, null)

--Tabloda G�ncelleme Yapma
--Update Personel set Adi = 'Alp', Soyadi = 'Arslan' where PersonelID = 2 --�art koyulmazsa hepsini g�nceller

--Kay�t Silme
--delete from Personel where PersonelID = 4

--Veritaban�n�n Yede�ini Alma (Veri kurtarmak i�in)
--BACKUP DATABASE OrnekDb TO DISK = 'C:\DBYedek.bak';

/*
--Veritaban� Yedekten Geri Y�kleme

USE master; --Geri y�kleme i�in master veritaban�n� kullan�yoruz
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE; --mevcut veritaban�n� de�i�tirir
*/
--Tablodaki T�m Verileri Silme
--TRUNCATE TABLE personel;
--select * from Personel;

--Tabloyu Silme
--Drop TABLE personel;