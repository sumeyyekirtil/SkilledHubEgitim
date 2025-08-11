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
Select * from : veri �ekme
Update : veri g�ncelleme
delete from : veri silme
where : �art / ko�ul
Drop TABLE : tabloyu silme
TRUNCATE TABLE : tablodaki t�m verileri silme
*/

/*
BACKUP DATABASE OrnekDb TO DISK = 'C:\DBYedek.bak';  : Veritaban� yedekleme
yedek vt uzant�lar� .bak olur
*/

/* Yedek Al�nan yerden geri y�kleme :
USE master;
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE;
*/
--Database hakk�nda query yazmak i�in;
--_Database -> sa� t�k -> new query

/*
select * from _Tabloadi : tablodaki t�m verileri �ekme
select ProductName, UnitPrice from Products : tablodaki se�ilen verileri �ekme

select ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products : Tablodaki Alanlara Alias(Takma �sim) vererek �a��rma (k��eli paraantez kullanmak i�in [] kullan�l�r)

select p.ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products p : Tabloya Alias(Takma �sim) vererek �a��rma (bo�luk ile verildi)
*/

/*    Select Top �fadesi :Sorgu sonucunda t�m kay�tlar yerine belirli say�da kayd� �ekmemizi sa�lar

SELECT TOP (50) * FROM _Tabloadi  --> 50 veri getirir
*/
/*
SELECT * FROM Products order by  _Tabloadi asc  --tabloadina g�re k���kten b�y��e s�ralar 
SELECT * FROM Products order by UnitsInStock desc -tabloadina g�re k���kten b�y��e s�ralar (desc tersten s�rala)
*/
/*
                      SQL OPERAT�RLER�
	             1-SQL Aritmetik Operat�rler
		   
    --Toplama (+)
SELECT 10 + 8
    --��kartma (-)
SELECT (30 - 12)
    --�arpma (*)
SELECT 9 * 2
    --B�lme (/)
SELECT 36/2
    --Modulo (%)
SELECT 18 % 2
     
	              2-SQL Kar��la�t�rma Operat�rleri

				         --E�ittir (=)
SELECT * FROM Products WHERE UnitPrice = 18;  --de�er = 18 e e�it olan de�erleri getir
select * from Products where ProductName = 'pavlova' : string de�erleri listelemek istedi�imizde '' kullan�r�z

                        --B�y�kt�r (>)
SELECT * FROM Products WHERE UnitPrice > 18;

                        --K���kt�r (<)
SELECT * FROM Products WHERE UnitPrice < 18;

                        --B�y�k E�ittir(>=)
SELECT * FROM Products WHERE UnitPrice >= 18;

                        --K���k E�ittir (<=)
SELECT * FROM Products Where UnitPrice <= 18;

                        -- E�it De�ildir (!=)
SELECT * FROM Products Where UnitPrice <> 18; --(18 olmayanlar� da dahil et)
SELECT * FROM Products Where UnitPrice != 18;

                     
				 3-Mant�ksal Operat�rler

         --And (&) Ve Operat�r� ile �oklu filtre
Select * from Products Where SupplierID = 1 and CategoryID = 1 --Supplier(tedarik�i) �r�nlerden �d si 1 olan ve kategori �d si 1 olan �r�nleri g�sterir

         --Or (|) Veya Operat�r� ile �oklu filtre
Select * from Products Where SupplierID = 1 or CategoryID = 1 --veya getir yani �oklu sat�r getirir

         --Not (!) De�il Operat�r� ile �oklu filtre
Select * from Products Where  not SupplierID = 1 and CategoryID = 1 --1 olmayanlar� getir
                 

			      4- Di�er Operat�rler

               --SQL BETWEEN Operat�r� 
SELECT * FROM Products Where UnitPrice BETWEEN 10 AND 20; --aras�nda olan de�erleri getir
SELECT * FROM Products Where UnitPrice NOT BETWEEN 10 AND 20; --de�erler d���nda kalan verileri getir

              --Like Operat�r� �le Arama, Filtreleme ��lemi
--select * from Products where ProductName like 'a%'; --�r�nlerden �r�n ad� a ile ba�layanlar� getir
--select * from Customers where ContactName LIKE 'a%';-- m��terilerden ad� a ile ba�layanlar� getir
--SELECT * FROM Customers WHERE ContactName LIKE '%a' ;--m��terilerden ad� a ile bitenleri getir
--select * from Customers where ContactName LIKE '%or%' ;--m��terilerden ad� or i�erenleri getir
*/
/*
	            SQL IN-Not IN Operat�r�
�lgili s�tunda istedi�imiz de�erleri i�erenleri in ile i�ermeyenleri not in ile filtreleyebilirsiniz

SELECT * FROM Customers Where Country IN ('Germany', 'France', 'UK'); --('') parantez i�indeki verileri getirir
SELECT * FROM Customers Where Country Not IN ('Germany', 'France', 'UK'); --de�erleri i�ermeyen verileri getirir

              --�� i�e ili�kili veri okuma
SELECT * FROM Customers WHERE Country in (select Country from Suppliers)--m��terilerden country alan�nda Suppliers(tedarik�i) tablosunun �lke alan�nda ge�enleri getir

              --Tablodan Veri Okurken Hesaplama
       *�r�n stoklar� eritildi�inde kazan�lacak para

--select p.ProductName as [�r�n Ad�], p.UnitPrice as [�r�n Fiyat�], p.UnitsInStock as [Stok Miktar�], p.UnitsInStock * p.UnitPrice as [Toplam Kazan�]
from Products p --toplam kazan� kolonu ekleyip �arpma operat�r� kullan�p hesaplama yapar
*/
/*                  --SQL NULL DE�ERLER
select ShipName, ShipRegion from Orders where ShipRegion is null --sipari�lerden shipname ve shipregion alanlar�n� shipregion alan� null olanlara g�re �ek

select ShipName, ShipRegion from Orders where ShipRegion is not null --kolondaki de�er null de�ilmi
*/
/*
      --SQL SELECT DISTINCT Kullan�m� : 
sorgu sonucunda kay�t tekrar�n� engellemeyi sa�lar (tekrar edenleri listeden ��kar�r)

SELECT Country FROM Customers order by Country -output : 323 rows
SELECT DISTINCT Country FROM Customers --output : 21 rows
*/
/*
              --SQL Joins ile Tablolarda Birle�ik Sorgu Olu�turma
                         --SQL JOIN T�rleri
   1-(INNER)JOIN: her iki tabloda da e�le�en de�erlere sahip kay�tlar� d�nd�r�r
   2-LEFT (OUTER)JOIN: Soldaki tablodan t�m kay�tlar� ve sa� tablodan e�le�en kay�tlar� d�nd�r�r
   3-R�GHT (OUTER)JOIN: sa� tablodan t�m kay�tlar� ve soldaki tablodan e�le�en kay�tlar� d�nd�r�r
   4-FULL (OUTER)JOIN: Sol ve sa� tabloda bir e�le�me oldu�unda t�m kay�tlar� d�nd�r�r

        --SQL INNER JOIN (1 den fazla tablo olur birle�en tablo s�n�r� yok)
select * from Products
select * from Categories

        --farkl� tablolar� birle�tirme
select ProductName, UnitsInStock, CategoryName from Products
join    --categoryname i �ekip yan�na yazd�
Categories
on Products.CategoryID = Categories.CategoryID --categoryname olmad��� i�in join edip birle�tirdik

        --Join ile ikiden fazla tablo birle�tirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

        --SQL LEFT JOIN (solda birle�tir)
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alan�n� Orders tablosundan OrderID alan�n� getir
From Customers --Customers tablosundan 
LEFT JOIN Orders --left join ile solda birle�tirme i�lemi yapl�r ve Customers tablosunda olan ama orders tablosunda olmayan kay�tlar da getirilir, inner join den fark� budur inner join sadece e�le�en kay�tlar� getirir
ON Customers.CustomerID = Orders.CustomerID--Tablolar�m�z� ortak noktalar� olan CustomersID ye g�re e�le�tirdik
Order by Customers.ContactName --g�re s�rala

       --SQL R�GHT JOIN 
--(birle�tirme yap�lan her tabloyu getirir bir tarafta veri olmas� yeterli)
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

        --SQL FULL OUTHER JOIN
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName
*/
/*
       --SQL UNION (tek par�ada sorgu verir)
--UNION komutu, iki veya daha fazla SELECT deyimini sonu� k�mesini birle�tirmek i�in kullan�l�r.
--her select deyimi s�tunlar ayn� say�da olmak zorunda!!

SELECT City FROM Customers
UNION --her select deyimi ayn� sat�ra sahip olacak,tekrar eden kay�tlar engellenir
SELECT City FROM Suppliers
ORDER BY City;

       --Un�on All (hepsini getir)
SELECT City FROM Customers
UNION All --tekrar eden kay�tlar i�in all kullan�l�r
SELECT City FROM Suppliers
ORDER BY City;
*/
/*
      --SQL GROUP BY (Grupland�rma i�lemi yapar)
select Country FROM Customers
GROUP BY Country; --�lkeye g�re grupla, tekrar eden kay�tlar� engelle

     --HATA DENET�M� (BEGIN TRY - END TRY)
BEGIN TRY
     SELECT 4/0 --0 a b�l�nme hatas� f�rlat�r
END TRY
BEGIN CATCH  --hata yakalar (hata olursa ne yap�lacak?)
     SELECT
     ERROR_NUMBER() AS Hata_Numarasi,
	 ERROR_SEVERITY() AS Hata_Duzeyi,
	 ERROR_STATE() AS Hata_Durum_No,
	 ERROR_LINE() AS Hata_Satir_No,
	 ERROR_MESSAGE() AS Hata_Mesaj
END CATCH
*/
/*                 --YEN� DATABASE:B�L���M EKLEND�

create database Bilisim --bilisim database created
go
use bilisim

CREATE TABLE Bolumler(  --bolumler table
Bolum_No int NOT NULL,
Bolum_Adi nchar(50) NULL,
PRIMARY KEY (Bolum_No))

create table Calisanlar( --calisanlar table
TC_No nvarchar(11) not null,
Adi nvarchar(100) not null,
Bolum_No int null,
Cinsiyet nchar(1) null
primary key (TC_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Urunler(    --urunler table
Urun_No int not null,
Urun_Adi nvarchar (50) not null,
Urun_Sayisi int null,
Urun_Fiyati decimal(18,2) null,
Bolum_No int NOT NULL,
primary key (Urun_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Satislar(   --satislar table
Satis_No int not null,
Urun_No int null,
Calisan_TC_No nvarchar(11) null,
Miktar int null,
Fiyat decimal(18,2) null,
Tarih Date null,
primary key (Satis_No),
foreign key (Urun_No) references Urunler(Urun_No), --ikincil anahtar olu�turdu
foreign key (Calisan_TC_No) references Calisanlar(TC_No)
)
*/
/*
             --Commit ve RollBack Transaction
--G�ncelleme silme i�lemleri ba�ar�s�z olursa transaction komutu kullan�l�r
--G�ncelleme silme i�lemleri ba�ar�s�z olursa rollback transaction ile geri d�nd�r�r
--��lem ba�ar�l�ysa commit tran i�lemi tamaml�yor

begin 
begin try
begin transaction  --i�lem ba�lat�ld�
   update Calisanlar set Adi = 'Ali' where TC_No = '1234354357'
   update Bolumler Set Bolum_Adi = 'Ev Aleti' where Bolum_No = 5
   commit tran  --ba�ar�l� ise
   Print 'KAYIT G�NCELLEND�'
end try
begin catch
   rollback transaction --e�er yukar�daki kodlarda hata olu�ursa de�i�iklikleri geri al
   Print 'Kay�t g�ncellenemedi hata olu�tu!'
end catch
end
*/
/*
               --SQL Constrains(K�s�tlay�c�lar)
--hatalar� giri�leri engellemek i�in kullan�l�r
--create table , alter table ile k�s�tlay�c� olu�turulur

               --KISITLAYICI �E��TLER� (allow nuls i�areti kalkar)
--i�inde kay�t varken bu i�lem yap�lamaz
  --1-PRIMARY KEY(PK) - Birincil Anahtar k�s�tlay�c� (sar� anahtar, null giri�e izin vermez, unique)
--Bu i�lemi table - desing - istenilen column - primar key
--Desing - property - primary key ayarlan�r

  --2-FOREIGN KEY(FK) - YABANCI ANAHTAR KISITLAYICI (di�er tabloyu kontrol etmesi i�in tablolar aras� ba�lant� - kontrol sa�lar)
--Table - Keys - New Foreign Key - Name -Table and columns specific(ba�lant� e�le�mesi) - primary key-foreign key ba�lant�s�

  --3-UNIQUE Tekil alan k�s�tlay�c�s�
--truncate table kullanicilar

  --Triggers-Tetikleyiciler: 
--yap�lan bir eylem sonras� ba�ka bir eylemin yap�lmas� tetiklenebilir

*/
       