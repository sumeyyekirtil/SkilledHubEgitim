            --SQL SERVER PROGRAMI TANITIMI

--Microsoft un �r�n�d�r.
--Veri takibi i�in genellikle sql kullan�l�r.
--SQL Server vs gibi bir veritaban� y�netim sistemi olup (SSMS)Management Studio ile �al���r.
--SSMS bir veritaban� y�netim sistemini y�netmek i�in kullan�lan bir GUI arac�d�r.
/*
Download i�lemi: Google - Sql Server Download 2022 - Download Developer Sql
Sql Server Kurulum (EXE): Basic - install
SSMS (Sql Server Management Studio) Download:
   1- Sql Server - Basic - install ssms - google ssms - 21 ssms install
   2-google ssms download - 21 ssms install
SSMS Kurulum (EXE): Yapay zeka 
*/

            --Ba�lant� Ekran�
/*
Ba�lant� adresine : Localhost / .  yaz�l�p ba�lan�l�r.

Authentication (Yetkinlik) : Ki�isel Bilgisayar �m demek i�in -> Windows Authentication
          Ba�ka server a ba�lanmak i�in ip / sap no name girilerek ba�lant� sa�lan�r.
*/

            --Object Explorer ve Men� Tan�m�
/*
Daha �nce i�lem yap�lmad�ysa veritaban� bo� gelebilir.
Yeni veritaban� olu�turmak i�in -> Databases - New databases
De�i�ken isimleri olu�tururken T�rk�e isimler kullanabiliriz fakat bo�luk ve T�rk�e karakterler kullanmamal�y�z.
Limited - Vt boyutu ne olmal�? Verilen alan �nemli ��nk� yer yetersizse vt �al��maz ve durur.
Path : Dosya yolu
*/

/*
sa� t�k - desing ->
Tablo dizayn alan� : 3 alan var
1-Kolon Ad� - COLUMN NAME
2-Veri Tipi - DATA TYPE
  *�nt - integer
  *Varchar - k�sa metin
  *Nvarchar - string
  *bit - boolean
  *datetime - tarih
  *numeric - numaralar
  *float - kesirli say�lar
  *datetimeoffset - d�nya saat-tarih
  *decimal - decimal
  *money - ticaret i�in geli�tirilmi� parasal i�lem
  *geography - co�rafya
  *char - karakter(tc vs.) (n li olanlar dil setlerini destekler)
  *text - yaz� (email)
  *ntext - uzun yaz� (adres)
  *bigint - say�lar� hassasiyetle kaydeder
3-Allow Nuls: Active - ��aretli (bo� ge�ilebilir)
*/

/*
sa� t�k - edit top 200 rows ->
Yaz�lan kolonlara tipine uygun veri girilebilir
sa� t�k - delete -> sat�r silindi
nvarchar tam alan� dolmad�sa kendisi doldurur bo�lukla
*/

/*
sa� t�k -> select top 1000 rows
kod bloklar� yaz�labilir
altta result k�sm�nda verileri g�rebiliriz
kolon adlar� yaz�l�d�r
*/

/*
Insert Into : veri ekleme

*/