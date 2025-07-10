  --SQL SORGULAMA
--Tablodaki T�m Verileri �ekme
--select * from Products
--select * from Categories
--Tablodaki Baz� S�tunlar� �ekme
--select ProductName, UnitPrice from Products --se�ili kolonlar� getirir

--Tablodaki Alanlara Alias(Takma �sim) vererek �a��rma
--select ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products
 
--Tabloya Alias(Takma �sim) vererek �a��rma
--select p.ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products p
--select kat.CategoryName as KategoriAdi from Categories kat
/*
  Select Top �fadesi
  Sorgu sonucunda t�m kay�tlar yerine belirli say�da kayd� �ekmemizi sa�lar

SELECT TOP (50) * FROM Products--50 veri al�r

select top (10) ProductName, UnitPrice, UnitsInStock from [Products Above Average Price]--�r�nler tablosundan ��stten 10 �r�n� se� veProductNmae, UnitsPrice, UniteInStock alanlar� getir

SELECT * FROM Products order by UnitsInStock asc --�r�nleri UnitsInStock alan�na g�re k���kten b�y��e do�ru sralayarak getirir

SELECT * FROM Products order by UnitsInStock desc --�r�nleri UnitsInStock alan�na g�re b�y�kten k����e do�ru s�rala

          SQL Operat�rleri
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
 SELECT * FROM Products Where UnitPrice BETWEEN 10 AND 20;
 SELECT * FROM Products Where UnitPrice NOT BETWEEN 10 AND 20;

--Like Operat�r� �le Arama, Filtreleme ��lemi
--select * from Products where ProductName like 'a%'; --�r�nlerden �r�n ad�n a ile ba�layanlar� getir
--select * from Customers where ContactName L�KE 'a%';-- m��terilerden ad� a ile ba�layanlar� getir
--SELECT * FROM Customers WHERE ContactName L�KE '%a' ;--m��terilerden ad� a ile bitenleri getir
--select * from Customers where ContactName L�KE '%or%' ;--m��terilerden ad� or i�erenleri getir
     
	  SQL IN-Not IN Operat�r�
	ilgili s�tunda istedi�imiz de�erleri i�erenleri in ile i�ermeyenleri not in ile filtreleyebilirsiniz

SELECT * FROM Customers Where Country IN('Germany', 'France', 'UK'); --customers tablosundaki m��terilerden country kolonu 'Germany', 'France', 'UK' de�erlerini i�ereni getir.

--SELECT * FROM Customers Where Country Not IN ('Germany', 'France', 'UK');
--�� i�e ili�kili veri okuma
SELECT * FROM Customers WHERE Country in (select Country from Suppliers)--m��terilerden country alan�nda Suppliers(tedarik�i) tablosunun �lke alan�nda ge�enleri getir

    Tablodan Veri Okurken Hesaplama
  *�r�n stoklar� eritildi�inde kazan�lacak para

select p.ProductName as [�r�n Ad�], p.UnitPrace as [�r�n Fiyat�], p.UnitsInStock [Stok Miktar�], * p.UnitsInStock  * p.UnitPrace as [Toplam Kazan�] from Products p 

    --SQL NULL DE�ERLER
select ShipName, ShipRegion from Orders where ShipRegion is null --sipari�lerden shipname ve shipregion alanlar�n� shipregion alan� null olanlara g�re �ek
select ShipName, ShipRegion from Orders where ShipRegion is not null

--SQL SELECT DISTINCT Kullan�m� : sorgu sonucunda kay�t tekrar�n� engellemeyi sa�lar
SELECT Country FROM Customers order by Country

SELECT Country FROM Customers

    --SQL Joins ile Tablolarda Birle�ik Sorgu Olu�turma
 --SQL JOIN T�rleri
   1-(INNER)JOIN: her iki tabloda da e�le�en de�erlere sahip kay�rlar� d�nd�r�r
   2-LEFT (OUTER)JOIN: Soldaki tablodan t�m kay�rlar� ve sa� tablodan e�le�en kay�tlar� d�nd�r�r
   3-R�GHT (OUTER)JOIN: sa� tablodan t�m kay�tlar� ve soldaki tablodan e�le�en kay�tlar� d�nd�r�r
   4-FULL (OUTER)JOIN: Sol ve sa� tabloda bir e�le�me oldu�unda t�m kay�tlar� d�nd�r�r
 
     --SQL INNER JOIN
select * from Products
select * from Categories

select ProductName, UnitsInStock, CategoryName from Products
join
Categories
on Products.CategoryID = Categories.CategoryID --categoryname olmad��� i�in join edip birle�tirdik

SELECT Orders.OrderID, Customers.ContactName, OrderDate 
FROM Orders
INNER JOIN
Customers ON Orders.CustomerID=Customers.CustomerID;

--Join ile ikiden fazla tablo birle�tirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM((Orders
INNER JOIN Customers ON Orders.Customers.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

--SQL LEFT JOIN
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alan�n� Orders tablosundan OrderID alan�n� getir
From Customers --Customers tablosundan 
LEFT JOIN Orders --left join ile solda birle�tirme i�lemi yapl�r ve customer ablosunda olan ama orders tablosunda olmayan kay�tlar da getirilir, ineer join den fark� budyr ineer join sadece e�le�en kay�tlar� getirir
ON Customers.CustomerID = Orders.CustomerID--TABLOLARIMIZI ortak noktalar� olan CustomersId YE G�RE E�ELT�RD�LK
Order by Customers.ContactName

--SQL R�GHT JOIN
SELECT Orders.OrdersID, Employees.LastName, Employees.FirstName
FROM Orders
R�GHT JoIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

--SQL FULL OUTHER JOIN
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName

--SQL UNIOUN
--UNION komutu, iki veya daha fazla SELECT deyimini sonu� k�mesini birle�tirmek i�in kullan�l�r.
SELECT City FROM Customers
UNION --her selectdeyimi ayn� sat�ra sahip olacak,tekrar eden kay�tlar engellenir
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION All --tekrar eden kay�tlar i�in all kullan�l�r
SELECT City FROM Suppliers
ORDER BY City;

--SQL GROUP BY (Grupland�rma i�lemi yapar)
select Country FROM Customers
GROUP BY Country;

--HATA DENET�M�
BEGIN TRY
    SELECT 4/0
END TRY
BEGIN CATCH
     SELECT
     ERROR_NUMBER() AS Hata_Numarasi,
	 ERROR_SEVERITY() AS Hata_Duzeyi,
	 ERROR_STATE() AS Hata_Durum_No,
	 ERROR_LINE() AS Hata_Satir_No
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

--Commit ve RollBack
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
--hatalar� giri�leri engellemek i�in
--K�s�tlay�c� �e�itleri
--PRIMARY KEY Birincil Anahtar k�s�tlay�c�

--FOREIGN KET - YABANCI ANAHTAR KISITLAYICI
