            --SQL SERVER PROGRAMI TANITIMI

--Microsoft un ürünüdür.
--Veri takibi için genellikle sql kullanýlýr.
--SQL Server vs gibi bir veritabaný yönetim sistemi olup (SSMS)Management Studio ile çalýþýr.
--SSMS bir veritabaný yönetim sistemini yönetmek için kullanýlan bir GUI aracýdýr.
/*
Download iþlemi: Google - Sql Server Download 2022 - Download Developer Sql
Sql Server Kurulum (EXE): Basic - install
SSMS (Sql Server Management Studio) Download:
   1- Sql Server - Basic - install ssms - google ssms - 21 ssms install
   2-google ssms download - 21 ssms install
SSMS Kurulum (EXE): Yapay zeka 
*/

            --Baðlantý Ekraný
/*
Baðlantý adresine : Localhost / .  yazýlýp baðlanýlýr.

Authentication (Yetkinlik) : Kiþisel Bilgisayar ým demek için -> Windows Authentication
          Baþka server a baðlanmak için ip / sap no name girilerek baðlantý saðlanýr.
*/

            --Object Explorer ve Menü Tanýmý
/*
Daha önce iþlem yapýlmadýysa veritabaný boþ gelebilir.
Yeni veritabaný oluþturmak için -> Databases - New databases
Deðiþken isimleri oluþtururken Türkçe isimler kullanabiliriz fakat boþluk ve Türkçe karakterler kullanmamalýyýz.
Limited - Vt boyutu ne olmalý? Verilen alan önemli çünkü yer yetersizse vt çalýþmaz ve durur.
Path : Dosya yolu
*/

/*
sað týk - desing ->
Tablo dizayn alaný : 3 alan var
1-Kolon Adý - COLUMN NAME
2-Veri Tipi - DATA TYPE
  *Ýnt - integer
  *Varchar - kýsa metin
  *Nvarchar - string
  *bit - boolean
  *datetime - tarih
  *numeric - numaralar
  *float - kesirli sayýlar
  *datetimeoffset - dünya saat-tarih
  *decimal - decimal
  *money - ticaret için geliþtirilmiþ parasal iþlem
  *geography - coðrafya
  *char - karakter(tc vs.) (n li olanlar dil setlerini destekler)
  *text - yazý (email)
  *ntext - uzun yazý (adres)
  *bigint - sayýlarý hassasiyetle kaydeder
3-Allow Nuls: Active - Ýþaretli (boþ geçilebilir)
*/

/*
sað týk - edit top 200 rows ->
Yazýlan kolonlara tipine uygun veri girilebilir
sað týk - delete -> satýr silindi
nvarchar tam alaný dolmadýsa kendisi doldurur boþlukla
*/

/*
sað týk -> select top 1000 rows
kod bloklarý yazýlabilir
altta result kýsmýnda verileri görebiliriz
kolon adlarý yazýlýdýr
*/

/*
Insert Into : veri ekleme
Select * from : veri çekme
Update : veri güncelleme
delete from : veri silme
where : þart / koþul
Drop TABLE : tabloyu silme
TRUNCATE TABLE : tablodaki tüm verileri silme
*/

/*
BACKUP DATABASE OrnekDb TO DISK = 'C:\DBYedek.bak';  : Veritabaný yedekleme
yedek vt uzantýlarý .bak olur
*/

/* Yedek Alýnan yerden geri yükleme :
USE master;
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE;
*/
--Database hakkýnda query yazmak için;
--_Database -> sað týk -> new query

/*
select * from _Tabloadi : tablodaki tüm verileri çekme
select ProductName, UnitPrice from Products : tablodaki seçilen verileri çekme

select ProductName as [Ürün Adý], UnitPrice as [Ürün Fiyatý] from Products : Tablodaki Alanlara Alias(Takma Ýsim) vererek çaðýrma (köþeli paraantez kullanmak için [] kullanýlýr)

select p.ProductName as [Ürün Adý], UnitPrice as [Ürün Fiyatý] from Products p : Tabloya Alias(Takma Ýsim) vererek çaðýrma (boþluk ile verildi)
*/

/*    Select Top Ýfadesi :Sorgu sonucunda tüm kayýtlar yerine belirli sayýda kaydý çekmemizi saðlar

SELECT TOP (50) * FROM _Tabloadi  --> 50 veri getirir
*/
/*
SELECT * FROM Products order by  _Tabloadi asc  --tabloadina göre küçükten büyüðe sýralar 
SELECT * FROM Products order by UnitsInStock desc -tabloadina göre küçükten büyüðe sýralar (desc tersten sýrala)
*/
/*
                      SQL OPERATÖRLERÝ
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
SELECT * FROM Products WHERE UnitPrice = 18;  --deðer = 18 e eþit olan deðerleri getir
select * from Products where ProductName = 'pavlova' : string deðerleri listelemek istediðimizde '' kullanýrýz

                        --Büyüktür (>)
SELECT * FROM Products WHERE UnitPrice > 18;

                        --Küçüktür (<)
SELECT * FROM Products WHERE UnitPrice < 18;

                        --Büyük Eþittir(>=)
SELECT * FROM Products WHERE UnitPrice >= 18;

                        --Küçük Eþittir (<=)
SELECT * FROM Products Where UnitPrice <= 18;

                        -- Eþit Deðildir (!=)
SELECT * FROM Products Where UnitPrice <> 18; --(18 olmayanlarý da dahil et)
SELECT * FROM Products Where UnitPrice != 18;

                     
				 3-Mantýksal Operatörler

         --And (&) Ve Operatörü ile çoklu filtre
Select * from Products Where SupplierID = 1 and CategoryID = 1 --Supplier(tedarikçi) ürünlerden ýd si 1 olan ve kategori ýd si 1 olan ürünleri gösterir

         --Or (|) Veya Operatörü ile çoklu filtre
Select * from Products Where SupplierID = 1 or CategoryID = 1 --veya getir yani çoklu satýr getirir

         --Not (!) Deðil Operatörü ile çoklu filtre
Select * from Products Where  not SupplierID = 1 and CategoryID = 1 --1 olmayanlarý getir
                 

			      4- Diðer Operatörler

               --SQL BETWEEN Operatörü 
SELECT * FROM Products Where UnitPrice BETWEEN 10 AND 20; --arasýnda olan deðerleri getir
SELECT * FROM Products Where UnitPrice NOT BETWEEN 10 AND 20; --deðerler dýþýnda kalan verileri getir

              --Like Operatörü Ýle Arama, Filtreleme Ýþlemi
--select * from Products where ProductName like 'a%'; --ürünlerden ürün adý a ile baþlayanlarý getir
--select * from Customers where ContactName LIKE 'a%';-- müþterilerden adý a ile baþlayanlarý getir
--SELECT * FROM Customers WHERE ContactName LIKE '%a' ;--müþterilerden adý a ile bitenleri getir
--select * from Customers where ContactName LIKE '%or%' ;--müþterilerden adý or içerenleri getir
*/
/*
	            SQL IN-Not IN Operatörü
Ýlgili sütunda istediðimiz deðerleri içerenleri in ile içermeyenleri not in ile filtreleyebilirsiniz

SELECT * FROM Customers Where Country IN ('Germany', 'France', 'UK'); --('') parantez içindeki verileri getirir
SELECT * FROM Customers Where Country Not IN ('Germany', 'France', 'UK'); --deðerleri içermeyen verileri getirir

              --Ýç içe iliþkili veri okuma
SELECT * FROM Customers WHERE Country in (select Country from Suppliers)--müþterilerden country alanýnda Suppliers(tedarikçi) tablosunun ülke alanýnda geçenleri getir

              --Tablodan Veri Okurken Hesaplama
       *Ürün stoklarý eritildiðinde kazanýlacak para

--select p.ProductName as [Ürün Adý], p.UnitPrice as [Ürün Fiyatý], p.UnitsInStock as [Stok Miktarý], p.UnitsInStock * p.UnitPrice as [Toplam Kazanç]
from Products p --toplam kazanç kolonu ekleyip çarpma operatörü kullanýp hesaplama yapar
*/
/*                  --SQL NULL DEÐERLER
select ShipName, ShipRegion from Orders where ShipRegion is null --sipariþlerden shipname ve shipregion alanlarýný shipregion alaný null olanlara göre çek

select ShipName, ShipRegion from Orders where ShipRegion is not null --kolondaki deðer null deðilmi
*/
/*
      --SQL SELECT DISTINCT Kullanýmý : 
sorgu sonucunda kayýt tekrarýný engellemeyi saðlar (tekrar edenleri listeden çýkarýr)

SELECT Country FROM Customers order by Country -output : 323 rows
SELECT DISTINCT Country FROM Customers --output : 21 rows
*/
/*
              --SQL Joins ile Tablolarda Birleþik Sorgu Oluþturma
                         --SQL JOIN Türleri
   1-(INNER)JOIN: her iki tabloda da eþleþen deðerlere sahip kayýtlarý döndürür
   2-LEFT (OUTER)JOIN: Soldaki tablodan tüm kayýtlarý ve sað tablodan eþleþen kayýtlarý döndürür
   3-RÝGHT (OUTER)JOIN: sað tablodan tüm kayýtlarý ve soldaki tablodan eþleþen kayýtlarý döndürür
   4-FULL (OUTER)JOIN: Sol ve sað tabloda bir eþleþme olduðunda tüm kayýtlarý döndürür

        --SQL INNER JOIN (1 den fazla tablo olur birleþen tablo sýnýrý yok)
select * from Products
select * from Categories

select ProductName, UnitsInStock, CategoryName from Products
join
Categories
on Products.CategoryID = Categories.CategoryID --categoryname olmadýðý için join edip birleþtirdik

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
*/
/*
       --SQL UNIOUN
--UNION komutu, iki veya daha fazla SELECT deyimini sonuç kümesini birleþtirmek için kullanýlýr.
SELECT City FROM Customers
UNION --her selectdeyimi ayný satýra sahip olacak,tekrar eden kayýtlar engellenir
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
*/