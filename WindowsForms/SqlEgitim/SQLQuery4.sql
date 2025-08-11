                     --SQL SORGULAMA
--Tablodaki T�m Verileri �ekme
--select * from Products
--select * from Categories

--Tablodaki Baz� S�tunlar� �ekme
--select ProductName, UnitPrice from Products --se�ili kolonlar� getirir

--Tablodaki Alanlara Alias(Takma �sim) vererek �a��rma
--select ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products
 
--Tabloya Alias(Takma �sim) vererek �a��rma
--select p.ProductName as [�r�n Ad�], p.UnitPrice as [�r�n Fiyat�] from Products p
--select kat.CategoryName as KategoriAdi from Categories kat

/*
                   Select Top �fadesi
  Sorgu sonucunda t�m kay�tlar yerine belirli say�da kayd� �ekmemizi sa�lar

SELECT TOP (50) * FROM Products --50 veri al�r

select top (10) ProductName, UnitPrice, UnitsInStock from Products  --�r�nler tablosundan ��stten 10 �r�n� se� ve ProductName, UnitPrice, UnitsInStock alanlar� getir
*/
/*
                   Order By ile s�ralama 
SELECT * FROM Products order by UnitsInStock asc --�r�nleri UnitsInStock alan�na g�re k���kten b�y��e do�ru s�ralayarak getirir

SELECT * FROM Products order by UnitsInStock desc --�r�nleri UnitsInStock alan�na g�re b�y�kten k����e do�ru s�ralar
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
SELECT * FROM Products WHERE UnitPrice = 18;

--select * from Products where CategoryID = 3; --CategoryID si 3 e e�it olanlar� getir
--select * from Products where ProductName = 'pavlova' --sql de string '' ile g�sterilir

--B�y�kt�r (>)
SELECT * FROM Products WHERE UnitPrice > 18;

--K���kt�r (<)
SELECT * FROM Products WHERE UnitPrice < 18;
SELECT * FROM Products Where UnitsInStock < 1;

--B�y�k E�ittir(>=)
SELECT * FROM Products WHERE UnitPrice >= 18;
SELECT * FROM Products Where UnitsInStock >= 99;

--K���k E�ittir (<=)
SELECT * FROM Products Where UnitPrice <= 18;

-- E�it De�ildir (!=)
SELECT * FROM Products Where UnitPrice <> 18;
SELECT * FROM Products Where UnitPrice != 18;

                   3-Mant�ksal Operat�rler

         --And (&) Ve Operat�r� ile �oklu filtre
Select * from Products Where SupplierID = 1 and CategoryID = 1 --Supplier(tedarik�i) �r�nlerden �d si 1 olan ve kategori �d si 1 olan �r�nleri g�sterir

         --Or (|) Veya Operat�r� ile �oklu filtre
Select * from Products Where SupplierID = 1 or CategoryID = 1

         --Not (!) De�il Operat�r� ile �oklu filtre
Select * from Products Where  not SupplierID = 1 and CategoryID = 1


	               4- Di�er Operat�rler

--SQL BETWEEN Operat�r� 
SELECT * FROM Products Where UnitPrice BETWEEN 10 AND 20; --aras�nda olan de�erleri getir
SELECT * FROM Products Where UnitPrice NOT BETWEEN 10 AND 20; --de�erler d���nda kalan verileri getir

--Like Operat�r� �le Arama, Filtreleme ��lemi
--select * from Products where ProductName like 'a%'; --�r�nlerden �r�n ad� a ile ba�layanlar� getir
--select * from Customers where ContactName LIKE 'a%';-- m��terilerden ad� a ile ba�layanlar� getir
--SELECT * FROM Customers WHERE ContactName LIKE '%a'; --m��terilerden ad� a ile bitenleri getir
--select * from Customers where ContactName LIKE '%or%'; --m��terilerden ad� or i�erenleri getir
     
	       SQL IN-Not IN Operat�r�
�lgili s�tunda istedi�imiz de�erleri i�erenleri in ile i�ermeyenleri not in ile filtreleyebilirsiniz

SELECT * FROM Customers Where Country IN ('Germany', 'France', 'UK'); --customers tablosundaki m��terilerden country kolonu 'Germany', 'France', 'UK' de�erlerini getirir.

--SELECT * FROM Customers Where Country Not IN ('Germany', 'France', 'UK'); --de�erleri i�ermeyen verileri getirir
   
        --�� i�e ili�kili veri okuma
SELECT * FROM Customers WHERE Country in (select Country from Suppliers)--m��terilerden country alan�nda Suppliers(tedarik�i) tablosunun �lke alan�nda ge�enleri getir

        -- Tablodan Veri Okurken Hesaplama
    *�r�n stoklar� eritildi�inde kazan�lacak para

select p.ProductName as [�r�n Ad�], p.UnitPrice as [�r�n Fiyat�], p.UnitsInStock as [Stok Miktar�], p.UnitsInStock * p.UnitPrice as [Toplam Kazan�]
from Products p --toplam kazan� kolonu ekleyip �arpma operat�r� kullan�p hesaplama yapar

        --SQL NULL DE�ERLER
select ShipName, ShipRegion from Orders where ShipRegion is null --sipari�lerden shipname ve shipregion alanlar�n� shipregion alan� null olanlara g�re �ek

select ShipName, ShipRegion from Orders where ShipRegion is not null --kolondaki de�er null de�ilmi

         --SQL SELECT DISTINCT Kullan�m� : sorgu sonucunda kay�t tekrar�n� engellemeyi sa�lar
SELECT Country FROM Customers order by Country --hepsini getirir

SELECT DISTINCT Country FROM Customers --ayn� olan verilerden se�erek 1 tane getirir

         --SQL Joins ile Tablolarda Birle�ik Sorgu Olu�turma
                     --SQL JOIN T�rleri
   1-(INNER)JOIN: her iki tabloda da e�le�en de�erlere sahip kay�tlar� d�nd�r�r
   2-LEFT (OUTER)JOIN: Soldaki tablodan t�m kay�tlar� ve sa� tablodan e�le�en kay�tlar� d�nd�r�r
   3-R�GHT (OUTER)JOIN: sa� tablodan t�m kay�tlar� ve soldaki tablodan e�le�en kay�tlar� d�nd�r�r
   4-FULL (OUTER)JOIN: Sol ve sa� tabloda bir e�le�me oldu�unda t�m kay�tlar� d�nd�r�r
 
      --SQL INNER JOIN
select * from Products
select * from Categories

      --farkl� tablolar� birle�tirme
select ProductName, UnitsInStock, CategoryName from Products
join    --categoryname i �ekip yan�na yazd�
Categories
on Products.CategoryID = Categories.CategoryID --categoryname olmad��� i�in join edip birle�tirdik

SELECT Orders.OrderID, Customers.ContactName, OrderDate 
FROM Orders
INNER JOIN
Customers ON Orders.CustomerID=Customers.CustomerID;

     --Join ile ikiden fazla tablo birle�tirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

     --SQL LEFT JOIN
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alan�n� Orders tablosundan OrderID alan�n� getir
From Customers --Customers tablosundan 
LEFT JOIN Orders --left join ile solda birle�tirme i�lemi yapl�r ve Customers tablosunda olan ama orders tablosunda olmayan kay�tlar da getirilir, inner join den fark� budur inner join sadece e�le�en kay�tlar� getirir
ON Customers.CustomerID = Orders.CustomerID--Tablolar�m�z� ortak noktalar� olan CustomersID ye g�re e�le�tirdik
Order by Customers.ContactName --g�re s�rala

     --SQL R�GHT JOIN
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

     --SQL FULL OUTHER JOIN
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName

     --SQL UNION
--UNION komutu, iki veya daha fazla SELECT deyimini sonu� k�mesini birle�tirmek i�in kullan�l�r.
SELECT City FROM Customers
UNION --her select deyimi ayn� sat�ra sahip olacak,tekrar eden kay�tlar engellenir
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION All --tekrar eden kay�tlar i�in all kullan�l�r
SELECT City FROM Suppliers
ORDER BY City;

     --SQL GROUP BY (Grupland�rma i�lemi yapar)
select Country FROM Customers
GROUP BY Country; --country ye g�re grupla

     --HATA DENET�M� (BEGIN TRY - END TRY)
BEGIN TRY
     SELECT 4/0 --0 a b�l�nme hatas� f�rlat�r
END TRY
BEGIN CATCH  --hata yakalar
     SELECT
     ERROR_NUMBER() AS Hata_Numarasi,
	 ERROR_SEVERITY() AS Hata_Duzeyi,
	 ERROR_STATE() AS Hata_Durum_No,
	 ERROR_LINE() AS Hata_Satir_No,
	 ERROR_MESSAGE() AS Hata_Mesaj
END CATCH

     --YEN� DATABASE:B�L���M EKLEND�
create database Bilisim
go
use bilisim

CREATE TABLE Bolumler(
Bolum_No int NOT NULL,
Bolum_Adi nchar(50) NULL,
PRIMARY KEY (Bolum_No))
create table Calisanlar(

TC_No nvarchar(11) not null,
Adi nvarchar(100) not null,
Bolum_No int null,
Cinsiyet nchar(1) null
primary key (TC_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Urunler(
Urun_No int not null,
Urun_Adi nvarchar (50) not null,
Urun_Sayisi int null,
Urun_Fiyati decimal(18,2) null,
Bolum_No int NOT NULL,
primary key (Urun_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Satislar(
Satis_No int not null,
Urun_No int null,
Calisan_TC_No nvarchar(11) null,
Miktar int null,
Fiyat decimal(18,2) null,
Tarih Date null,
primary key (Satis_No),
foreign key (Urun_No) references Urunler(Urun_No),
foreign key (Calisan_TC_No) references Calisanlar(TC_No)
)

            --Commit ve RollBack Transaction
--g�ncelleme silme i�lemleri ba�ar�s�z olursa rollback ile geri d�nd�r�r
--ba�ar�l� olursa commitler

begin 
begin try
begin transaction
   update Calisanlar set Adi = 'Ali' where TC_No = '1234354357'
   update Bolumler Set Bolum_Adi = 'Ev Aleti' where Bolum_No = 5
   commit tran
   Print 'KAYIT G�NCELLEND�'
end try
begin catch
   rollback transaction --e�er yukar�daki kodlarda hata olu�ursa de�i�iklikleri geri al
   Print 'Kay�t g�ncellenemedi hata olu�tu!'
end catch
end
*/
            --SQL Constrains(K�s�tlay�c�lar)
--hatalar� giri�leri engellemek i�in kullan�l�r
--create table , alter table ile k�s�tlay�c� olu�turulur
            
			--KISITLAYICI �E��TLER�
--1-PRIMARY KEY - Birincil Anahtar k�s�tlay�c� (sar� anahtar, null giri�e izin vermez, unique)

--2-FOREIGN KEY - YABANCI ANAHTAR KISITLAYICI (di�er tabloyu kontrol etmesi i�in tablolar aras� ba�lant� - kontrol sa�lar)

--3-UNIQUE Tekil alan k�s�tlay�c�s�
--truncate table kullanicilar

--Triggers-Tetikleyiciler: 
--yap�lan bir eylem sonras� ba�ka bir eylemin yap�lmas� tetiklenebilir
/*
   MsSql de 2 �e�it tetikleyici vard�r
     1-Ard� s�ra tetikleyiciler; i�lem den sonra i�lem tetikleyici
     2-Yerine Tetikleyiciler; bir i�lem yerine tetikleyici

    --STORED PROSEDURE(Sakl� Yordam) ve Fonksiyon Kullan�m�
--�rn: Crud i�lemleri komutlar�, try catch kullan�labilir
--Yeni Stored Procedure(Sakl� Yordam Olu�turma)
CREATE PROCEDURE sp_CalisanBolum --sp_CalisanBolum isminde bir SP olu�turduj
AS
BEGIN
select Bolumler.Bolum_Adi, Calisanlar.Adi From Bolumler INNER JOIN Calisanlar ON Bolumler.Bolum_No = Calisanlar.Bolum_No--sp_CalisanBolum �n yapaca�� i�lem i�in ilgili select komutunu yazd�k
END
GO

exec sp_CalisanBolum --STORED PROCEDURE �al��t�rma

CREATE PROCEDURE sp_UrunListele(@UrunSayisiParametresi int)--SP ye d��ar�an gelecek �r�n say�s� paremetresine g�er �r�nleri liseleyece�iz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

exec sp_UrunListele 18--de�er vermemizi isterse say�sal de�er verme bi�imi

--SP G�ncelleme
ALTER PROCEDURE sp_UrunListele(@UrunSayisiParametresi int = 0)--SP ye d��ar�an gelecek �r�n say�s� paremetresine g�er �r�nleri liseleyece�iz
AS --=0 eklendi fakar alter kullan�lmsa� gerekiyor
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

exec sp_UrunListele --art�k hata getirmiyor

CREATE PROCEDURE sp_BolumEkle
(
@BolumAdi nvarchar(50)
)
AS
BEGIN
INSERT INTO Bolumler(Bolum_Adi) VALUES (@BolumAdi)
END

--KULLANIMI
EXEC sp_BolumEkle 'Aksesuar' --bolum no alan� i�in de�er bekliyo (identity yes yapmam�z laz�m)

      --Fonksiyonlar
--Kullan�c� tan�ml� fonksiyonlar, kullan�c�lar taraf�ndan tan�mlanan tek bir de�er veya tablo d�nd�rmek i�in kullan�lan ili�kisel veritaban� nesneleridir

    CREATE FUNCTION : Fonksiyon olu�turmak i�in kullan�l�r
	ALTER FUNCTION : Fonksiyonda de�i�iklik yapmak i�in kullan�l�r
	DROP FUNCTION : Mevcut olan fonksiyonu silmek i�in kullan�l�r


CREATE FUNCTION UrunAdet(@urunAdi nvarchar(50))
RETURNS int
AS
BEGIN
DECLARE @urunAdedi int --veri tipi int olan bir de�i�ken olu�turduk
SET @urunAdedi=(SELECT Urun_Sayisi FROM Urunler WHERE Urun_Adi=@urunAdi)
RETURN @urunAdedi--selecet sorgusuyla bulunan urunadedi de�i�ken de�erini d�nd�r�r
END

--Fonksiyon kullan�m�:
select dbo.UrunAdet('Bilgisayar') as UrunAdedi

--Tablo De�erli Fonksiyonlar 
create function fn_CalisanlariListele()
returns table
as
return select * from Calisanlar

--Fonksiyon Kullan�m�:
select * from fn_CalisanlariListele()

   --SQL Server Fonksiyonlar�
--SQL String Fonksiyonlar�
SELECT LEFT('Left Kullan�m�', 6)--ilk 6 karakteri yazd�r�r
SELECT Right('Left Kullan�m�', 6)
SELECT LEN('Len Kullan�m�')

Select ProductName, LEN(ProductName) as [�r�n ad� karakter say�s�] from Products

SELECT LOWER('K���k HARFE �Evir') as K���kHarf
Select ProductName, LOWER(ProductName) as [�r�n ad�n� k���k harfe �evir], LEN(ProductName) as [�r�n ad� karakter say�s�] from Products

SELECT UPPER('B�y�k HARFE �EV�R') --Metni b�y�k harfe �eviren fonksiyon

SELECT ProductName, UPPER(ProductName) as [�r�n ad�n� b�y�k harfe �evir] from Products

--AVG() Fonksiyonu : bir ifadenin ortalama de�erini d�nd�r�r
SELECT AVG(UnitPrice) AS Ortalama�r�nFiyat� FROM Products;
SELECT Min(UnitPrice) AS EnD���k�r�nFiyat� FROM Products;

SELECT Max(UnitPrice) AS EnY�ksek�r�nFiyat� FROM Products;
*/