  --SQL SORGULAMA
--Tablodaki Tüm Verileri Çekme
--select * from Products
--select * from Categories
--Tablodaki Bazý Sütunlarý Çekme
--select ProductName, UnitPrice from Products --seçili kolonlarý getirir

--Tablodaki Alanlara Alias(Takma Ýsim) vererek çaðýrma
--select ProductName as [Ürün Adý], UnitPrice as [Ürün Fiyatý] from Products
 
--Tabloya Alias(Takma Ýsim) vererek çaðýrma
--select p.ProductName as [Ürün Adý], UnitPrice as [Ürün Fiyatý] from Products p
--select kat.CategoryName as KategoriAdi from Categories kat
/*
  Select Top Ýfadesi
  Sorgu sonucunda tüm kayýtlar yerine belirli sayýda kaydý çekmemizi saðlar

SELECT TOP (50) * FROM Products--50 veri alýr

select top (10) ProductName, UnitPrice, UnitsInStock from [Products Above Average Price]--ürünler tablosundan üðstten 10 ürünü seç veProductNmae, UnitsPrice, UniteInStock alanlarý getir

SELECT * FROM Products order by UnitsInStock asc --ürünleri UnitsInStock alanýna göre küçükten büyüðe doðru sralayarak getirir

SELECT * FROM Products order by UnitsInStock desc --Ürünleri UnitsInStock alanýna göre büyükten küçüðe doðru sýrala

          SQL Operatörleri
	1-SQL Aritmetik Operatörler

--Toplama (+)
SELECT 10 + 8
--Çýkartma (-)
SELECT (30 - 12)
--Çarpma (*)
SELECT 9 * 2
--Bölme (/)
SELECT 36/2
--Modulo (%)
SELECT 18 % 2
     
	  2-SQL Karþýlaþtýrma Operatörleri
--Eþittir (=)
SELECT * FROM Products WHERE UnitPrice = 18;

--select * from Products where CategoryID = 3; --CategoryID si 3 e eþit olanlarý getir
--select * from Products where ProductName = 'pavlova' --sql de string '' ile gösterilir

--Büyüktür (>)

SELECT * FROM Products WHERE UnitPrice > 18;
--Küçüktür (<)
SELECT * FROM Products WHERE UnitPrice < 18;

SELECT * FROM Products Where UnitsInStock < 1;
--Büyük Eþittir(>=)

SELECT * FROM Products WHERE UnitPrice >= 18;

SELECT * FROM Products Where UnitsInStock >= 99;

--Küçük Eþittir (<=)
SELECT * FROM Products Where UnitPrice <= 18;

-- Eþit Deðildir (!=)
SELECT * FROM Products Where UnitPrice <> 18;
SELECT * FROM Products Where UnitPrice != 18;

         3-Mantýksal Operatörler

--And (&) Ve Operatörü ile çoklu filtre
Select * from Products Where SupplierID = 1 and CategoryID = 1 --Supplier(tedarikçi) ürünlerden ýd si 1 olan ve kategori ýd si 1 olan ürünleri gösterir
--Or (|) Veya Operatörü ile çoklu filtre
Select * from Products Where SupplierID = 1 or CategoryID = 1 

--Not (!) Deðil Operatörü ile çoklu filtre
Select * from Products Where  not SupplierID = 1 and CategoryID = 1 
    
	4- Diðer Operatörler

--SQL BETWEEN Operatörü 
 SELECT * FROM Products Where UnitPrice BETWEEN 10 AND 20;
 SELECT * FROM Products Where UnitPrice NOT BETWEEN 10 AND 20;

--Like Operatörü Ýle Arama, Filtreleme Ýþlemi
--select * from Products where ProductName like 'a%'; --ürünlerden ürün adýn a ile baþlayanlarý getir
--select * from Customers where ContactName LÝKE 'a%';-- müþterilerden adý a ile baþlayanlarý getir
--SELECT * FROM Customers WHERE ContactName LÝKE '%a' ;--müþterilerden adý a ile bitenleri getir
--select * from Customers where ContactName LÝKE '%or%' ;--müþterilerden adý or içerenleri getir
     
	  SQL IN-Not IN Operatörü
	ilgili sütunda istediðimiz deðerleri içerenleri in ile içermeyenleri not in ile filtreleyebilirsiniz

SELECT * FROM Customers Where Country IN('Germany', 'France', 'UK'); --customers tablosundaki müþterilerden country kolonu 'Germany', 'France', 'UK' deðerlerini içereni getir.

--SELECT * FROM Customers Where Country Not IN ('Germany', 'France', 'UK');
--Ýç içe iliþkili veri okuma
SELECT * FROM Customers WHERE Country in (select Country from Suppliers)--müþterilerden country alanýnda Suppliers(tedarikçi) tablosunun ülke alanýnda geçenleri getir

    Tablodan Veri Okurken Hesaplama
  *Ürün stoklarý eritildiðinde kazanýlacak para

select p.ProductName as [Ürün Adý], p.UnitPrace as [Ürün Fiyatý], p.UnitsInStock [Stok Miktarý], * p.UnitsInStock  * p.UnitPrace as [Toplam Kazanç] from Products p 

    --SQL NULL DEÐERLER
select ShipName, ShipRegion from Orders where ShipRegion is null --sipariþlerden shipname ve shipregion alanlarýný shipregion alaný null olanlara göre çek
select ShipName, ShipRegion from Orders where ShipRegion is not null

--SQL SELECT DISTINCT Kullanýmý : sorgu sonucunda kayýt tekrarýný engellemeyi saðlar
SELECT Country FROM Customers order by Country

SELECT Country FROM Customers

    --SQL Joins ile Tablolarda Birleþik Sorgu Oluþturma
 --SQL JOIN Türleri
   1-(INNER)JOIN: her iki tabloda da eþleþen deðerlere sahip kayýrlarý döndürür
   2-LEFT (OUTER)JOIN: Soldaki tablodan tüm kayýrlarý ve sað tablodan eþleþen kayýtlarý döndürür
   3-RÝGHT (OUTER)JOIN: sað tablodan tüm kayýtlarý ve soldaki tablodan eþleþen kayýtlarý döndürür
   4-FULL (OUTER)JOIN: Sol ve sað tabloda bir eþleþme olduðunda tüm kayýtlarý döndürür
 
     --SQL INNER JOIN
select * from Products
select * from Categories

select ProductName, UnitsInStock, CategoryName from Products
join
Categories
on Products.CategoryID = Categories.CategoryID --categoryname olmadýðý için join edip birleþtirdik

SELECT Orders.OrderID, Customers.ContactName, OrderDate 
FROM Orders
INNER JOIN
Customers ON Orders.CustomerID=Customers.CustomerID;

--Join ile ikiden fazla tablo birleþtirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM((Orders
INNER JOIN Customers ON Orders.Customers.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

--SQL LEFT JOIN
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alanýný Orders tablosundan OrderID alanýný getir
From Customers --Customers tablosundan 
LEFT JOIN Orders --left join ile solda birleþtirme iþlemi yaplýr ve customer ablosunda olan ama orders tablosunda olmayan kayýtlar da getirilir, ineer join den farký budyr ineer join sadece eþleþen kayýtlarý getirir
ON Customers.CustomerID = Orders.CustomerID--TABLOLARIMIZI ortak noktalarý olan CustomersId YE GÖRE EÞELTÝRDÝLK
Order by Customers.ContactName

--SQL RÝGHT JOIN
SELECT Orders.OrdersID, Employees.LastName, Employees.FirstName
FROM Orders
RÝGHT JoIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

--SQL FULL OUTHER JOIN
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName

--SQL UNIOUN
--UNION komutu, iki veya daha fazla SELECT deyimini sonuç kümesini birleþtirmek için kullanýlýr.
SELECT City FROM Customers
UNION --her selectdeyimi ayný satýra sahip olacak,tekrar eden kayýtlar engellenir
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION All --tekrar eden kayýtlar için all kullanýlýr
SELECT City FROM Suppliers
ORDER BY City;

--SQL GROUP BY (Gruplandýrma iþlemi yapar)
select Country FROM Customers
GROUP BY Country;

--HATA DENETÝMÝ
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

--YENÝ DATABASE:BÝLÝÞÝM EKLENDÝ
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
--güncelleme silme iþlemleri baþarýsýz olursa rollback ile geri döndürür
--baþarýlý olursa commitler
begin 
begin try
begin transaction
   update Calisanlar set Adi = 'Ali' where TC_No = '1234354357'
   update Bolumler Set Bolum_Adi = 'Ev Aleti' where Bolum_No = 5
   commit tran
   Print 'KAYIT GÜNCELLENDÝ'
end try
begin catch
   rollback transaction --eðer yukarýdaki kodlarda hata oluþursa deðiþiklikleri geri al
   Print 'Kayýt güncellenemedi hata oluþtu!'
end catch
end
*/
    --SQL Constrains(Kýsýtlayýcýlar)
--hatalarý giriþleri engellemek için
--Kýsýtlayýcý Çeþitleri
--PRIMARY KEY Birincil Anahtar kýsýtlayýcý

--FOREIGN KET - YABANCI ANAHTAR KISITLAYICI
