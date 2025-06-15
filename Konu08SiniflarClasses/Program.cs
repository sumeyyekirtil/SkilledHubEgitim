using Microsoft.VisualBasic;

namespace Konu08SiniflarClasses
{
	internal class Ev //sınıf tanımlama
	{
		internal string sokakAdi;
		internal int kapiNo;
	}
	/*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
    sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
    Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
    *Erişim belirteçleri 4 ana sınıfa ayrılır
    * public    : Erişim kısıtı yoktur, her yerden erişilebilir
    * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
    * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
    * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
    * Bir öğe yalnızca 1 erişim belirteci alabilir
    * namespace erişim belirteci almaz çünkü o daima public tir
    * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
    * enum erişim belirteci almaz çünkü daima public tir
    */
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Siniflar-Classes!");//c# nesne yönül programlama dilidir
			Ev ilkEv = new Ev(); //soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkev i oluşturduk
			ilkEv.sokakAdi = "Çiçek sk";
			ilkEv.kapiNo = 10;
			Console.WriteLine("ilkEv sokak adı: " + ilkEv.sokakAdi);
			Console.WriteLine("ilkEv kapı no: " + ilkEv.kapiNo);

			Console.WriteLine();
			Ev yazlikEv = new();
			yazlikEv.sokakAdi = "Deniz sk.";
			yazlikEv.kapiNo = 18;
			Console.WriteLine("yazlikEv sokak adı: " + yazlikEv.sokakAdi);
			Console.WriteLine("yazlikEv kapı no: " + yazlikEv.kapiNo);
			Console.WriteLine();

			Ev koyEvi = new()
			{
				sokakAdi = "Pınar sk", //bu kullanımda ; yerine öğeler arasına  , koymamız gerekli çünkü {} var 
			    kapiNo = 34
			};
			Console.WriteLine("koyEvi sokak adı: " + koyEvi.sokakAdi);
			Console.WriteLine("koyEvi kapı no: " + koyEvi.kapiNo);
			Console.WriteLine();

			Console.WriteLine();
			Kategori kategori = new()
			{
				Id = 1,
				KategoriAdi = "Elektronik"
			};
			Kategori kategori2 = new()
			{
				Id = 2,
				KategoriAdi = "Bilgisayar"
			};
			Kategori kategori3 = new()
			{
				Id = 3,
				KategoriAdi = "Telefon"
			};
			Console.WriteLine("Kategori : " + kategori.KategoriAdi);
			Console.WriteLine("Kategori2 : " + kategori2.KategoriAdi);
			Console.WriteLine("Kategori3 : " + kategori3.KategoriAdi);

			Console.WriteLine();
			SiniftaMetotKullanimi metotKullanimi = new();
			var sonuc = metotKullanimi.LoginKontrol("admin", "1234");
			if(sonuc == true)
			{
				Console.WriteLine("Giriş Başarılı!");
			}
			else
				Console.WriteLine("Giriş Başarısız!");

			var toplamasonucu = metotKullanimi.ToplamaYap(10, 8);// kaç değer girildiyse yazılmalı (içine)
			Console.WriteLine("toplamasonucu: " + toplamasonucu);


			Console.WriteLine("Statik Değişken: " + SiniftaMetotKullanimi.StatikDegisken);// nesne oluşturmayı ve new demeyi beklemez statik değişken takısı değişir direkt kullanılır
			Console.WriteLine("Dinamik Değişken: " + metotKullanimi.DinamikDegisken);// statik gibi sınıftan değil metottan ulaşılır dinamik değişkene

			Urun urun = new()
			{
				Id = 3,
				Adi = "Klavye",
				Durum = true,
				Fiyati = 999,
				Markasi = "Piranha",
				UrunAciklamasi = "Işıklı yanar dönerli"
			};
			Urun mouse = new()
			{
				Adi = "Mouse",
				Fiyati = 199,
				Markasi = "A4 Tech",
				UrunAciklamasi = "Kablolu"
			};
			Console.WriteLine("Ürün Bilgileri");
			Console.WriteLine($"Ürün Adı {urun.Adi}");
			Console.WriteLine($"Ürün Fiyatı {urun.Fiyati}");
			Console.WriteLine($"Ürün Açıklaması {urun.UrunAciklamasi}");
			Console.WriteLine();
			Console.WriteLine("Ürün Bilgileri");
			Console.WriteLine($"Ürün Adı {mouse.Adi}");
			Console.WriteLine($"Ürün Fiyatı {mouse.Fiyati}");
			Console.WriteLine($"Ürün Açıklaması {mouse.UrunAciklamasi}");
			Console.WriteLine();

			Console.WriteLine("Urun Data Metotları");
			UrunDataMetotlari urunDataMetotlari = new();
			urunDataMetotlari.UrunEkle(mouse);
			urunDataMetotlari.UrunGuncelle(mouse);
			urunDataMetotlari.UrunSil(mouse);

			Console.WriteLine("\t\tÜrünler");
			Console.WriteLine();
			foreach (var item in urunDataMetotlari.Urunler())
			{
				Console.WriteLine($"\tÜrün Adı {item.Adi}");
				Console.WriteLine($"\tÜrün Fiyatı {item.Fiyati}");
				Console.WriteLine($"\tÜrün Açıklaması {mouse.UrunAciklamasi}");
				Console.WriteLine($"\tÜrün Durumu {mouse.Durum}");
				Console.WriteLine();
			}
			User user = new();
			Console.WriteLine("Email Giriniz: ");
			user.Email = Console.ReadLine();
			Console.WriteLine("Şifre Giriniz: ");
			user.Password = Console.ReadLine();
			var giris = user.KullaniciGiris(user.Email ,user.Password);
			if (giris == true)
			{
				Console.WriteLine("Hoşgeldiniz!");
			}else
				Console.WriteLine("Giriş Başarısız!");
		}
	}
}