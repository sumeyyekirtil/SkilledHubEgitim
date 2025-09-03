                    --CRUD ÝÞLEMLERÝ
--Tablolara kayýt ekleme, kayýtlarý çekme, kayýt güncelleme ve silme iþlemlerine kýsaca C(Create), R(Read), U(Update), D(Delete) deriz.

--Tabloya veri ekleme
--Insert Into Personel (PersonelID, Adi, Soyadi) values (1, 'Mehmet', 'CENGÝZ')

--Eklenen Verileri Çekme
--select * from Personel

--Tabloda Tüm Alanlara Veri Ekleme
--Insert Into Personel values (4, 'Memet', 'alii', null, null, null)

--Tabloda Güncelleme Yapma
--Update Personel set Adi = 'Alp', Soyadi = 'Arslan' where PersonelID = 2 --þart koyulmazsa hepsini günceller

--Kayýt Silme
--delete from Personel where PersonelID = 4

--Veritabanýnýn Yedeðini Alma (Veri kurtarmak için)
--BACKUP DATABASE OrnekDb TO DISK = 'C:\DBYedek.bak';

/*
--Veritabaný Yedekten Geri Yükleme

USE master; --Geri yükleme için master veritabanýný kullanýyoruz
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE; --mevcut veritabanýný deðiþtirir
*/
--Tablodaki Tüm Verileri Silme
--TRUNCATE TABLE personel;
--select * from Personel;

--Tabloyu Silme
--Drop TABLE personel;