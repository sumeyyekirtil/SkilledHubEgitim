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

*/