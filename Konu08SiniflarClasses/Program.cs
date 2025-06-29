namespace Konu08SiniflarClasses
{
	internal class Ev //sınıf tanımlama
	{
		internal string sokakAdi;
		internal int kapiNo;
	}
	/*C# nesne yönelimli bir programlama dili olduğu için herşey sınıflar içinde tanımlanır.
    Sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
    Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (access modifiers) denir.
    * Erişim belirteçleri 4 ana sınıfa ayrılır
    * public    : Erişim kısıtı yoktur, her yerden erişilebilir
    * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
    * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
    * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
    * Bir öğe yalnızca 1 erişim belirteci alabilir
    * namespace erişim belirteci almaz çünkü o daima public tir
    * Sınıflar public ya da internal nitelemesi alabilirler ama protected ya da private nitelemesi alamazlar
    * enum erişim belirteci almaz çünkü daima public tir
    */
	public class deneme //deneme class ı public olduğundan erişilebilir dolayısıyla alt öğelere de erişilebilir
	{
		public string UrunAdi = "public öğeye herkes erişebilir";
		protected class test //Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
		{
			string UrunAdi;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Siniflar-Classes!");//C# nesne yönelimli programlama dilidir
			#region Ornek1 //region-endregion pop-up olarak kapatır, bölümleştirmeyi kolaylaştırır
			Ev ilkEv = new Ev(); //soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkev i oluşturduk
			ilkEv.sokakAdi = "Çiçek sk"; //. ile tanımlanan özelliklere erişilir
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

			Ev koyEvi = new() //sınıfı diğer şekilde somut tanımlama yolu
			{
				sokakAdi = "Pınar sk", //bu kullanımda ; yerine öğeler arasına , koymamız gerekli çünkü {} var 
				kapiNo = 34
			};
			Console.WriteLine("koyEvi sokak adı: " + koyEvi.sokakAdi);
			Console.WriteLine("koyEvi kapı no: " + koyEvi.kapiNo);
			Console.WriteLine();
			#endregion
			#region Ornek2
			Kullanici kullanici = new()
			{
				Adi = "Hanife",
				Soyadi = "Çoban",
				Email = "hanife@coban.com",
				Id = 1,
				KullaniciAdi = "hanifec",
				Sifre = "123"
			};
			Kullanici selim = new()
			{
				Adi = "Selim",
				Soyadi = "Ak",
				Email = "selim@ak.com",
				Id = 2,
				KullaniciAdi = "selima",
				Sifre = "456"
			};
			Console.WriteLine("Kullanıcı Bilgileri : ");
			Console.WriteLine("Adı : " + kullanici.Adi);
			Console.WriteLine("Soyadı : " + kullanici.Soyadi);
			Console.WriteLine("Email : " + kullanici.Email);
			Console.WriteLine();
			Console.WriteLine("Kullanıcı Bilgileri : ");
			Console.WriteLine("Adı : " + selim.Adi);
			Console.WriteLine("Soyadı : " + selim.Soyadi);
			Console.WriteLine("Email : " + selim.Email);
			Console.WriteLine("KullaniciAdi : " + selim.KullaniciAdi);
			Console.WriteLine();
			#endregion
			/*
			Console.WriteLine("Kullanıcı Adınız: ");
			var kullaniciAdi = Console.ReadLine();
			Console.WriteLine("Şifreniz : ");
			var sifre = Console.ReadLine();
			if (kullaniciAdi == selim.Adi && sifre == selim.Sifre) // Ve operatörü(&&): iki değeri de T&T olursa sonuç 1 döner
			{
				Console.WriteLine("Hoşgeldin : " + selim.Adi + " " + selim.Soyadi);
			}
			else
				Console.WriteLine("Giriş Başarısız!");
			*/
			Console.WriteLine();

			Araba araba = new() //araba yerine başka isim verilebilir, sınıf ile karışmamalı
			{
				Id = 1,
				KasaTipi = "Sedan",
				Marka = "Dacia",
				Model = "Logan",
				Renk = "Bordo",
				VitesTipi = "Manuel",
				YakitTipi = "Dizel"
			};
			Console.WriteLine("Araç Bilgisi");
			Console.WriteLine($"\n Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");
			Console.WriteLine();
			Araba araba2 = new()
			{
				Id = 2,
				KasaTipi = "Sedan",
				Marka = "Audi",
				Model = "AB Long",
				Renk = "Siyah",
				VitesTipi = "Otomatik",
				YakitTipi = "Dizel"
			};
			Console.WriteLine("Araç Bilgisi");
			Console.WriteLine($"\n Marka : {araba2.Marka} \n Model : {araba2.Model} \n Renk : {araba2.Renk}");
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
			Console.WriteLine("Kategori 2 : " + kategori2.KategoriAdi);
			Console.WriteLine("Kategori 3 : " + kategori3.KategoriAdi);
			Console.WriteLine();

			SiniftaMetotKullanimi metotKullanimi = new();
			var sonuc = metotKullanimi.LoginKontrol("admin", "1234");
			if (sonuc == true)
			{
				Console.WriteLine("Giriş Başarılı!");
			}
			else
				Console.WriteLine("Giriş Başarısız!"); //sifre eksik yazıldığından false sonuç
			
			Console.WriteLine();
			var toplamasonucu = metotKullanimi.ToplamaYap(10, 8);// kaç değer girildiyse yazılmalı (içine)
			Console.WriteLine("toplamasonucu: " + toplamasonucu);
			Console.WriteLine();
			Console.WriteLine("Statik Değişken: " + SiniftaMetotKullanimi.StatikDegisken);// nesne oluşturmayı ve new demeye gerek duymaz statik değişken takısı değişir direkt kullanılır
			Console.WriteLine("Dinamik Değişken: " + metotKullanimi.DinamikDegisken);// statik gibi sınıftan değil metottan ulaşılır dinamik değişkene

			Urun urun = new()
			{
				Id = 3,
				Adi = "Klavye",
				Durum = true,
				Fiyati = 999,
				Markasi = "Piranha",
				UrunAciklamasi = "Işıklı yanardönerli"
			};
			Urun mouse = new()
			{
				Adi = "Mouse",
				Fiyati = 199,
				Markasi = "A4 Tech",
				UrunAciklamasi = "Kablolu"
			};
			Console.WriteLine();
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

			Console.WriteLine("Ürün Data Metotları");
			UrunDataMetotlari urunDataMetotlari = new(); //statik olmadığı için nesne oluşturduk
			urunDataMetotlari.UrunEkle(mouse); //metot çalışması için bir ürün nesnesi yollamalısın uyarısı veriyor (mouse)
			urunDataMetotlari.UrunGuncelle(mouse);
			urunDataMetotlari.UrunSil(mouse);

			Console.WriteLine();
			Console.WriteLine("\t\tÜrünler");
			Console.WriteLine();
			foreach (var item in urunDataMetotlari.Urunler()) //birden fazla kayıt yazdırmak için foreach
			{ //item ismi Urun tipi
				Console.WriteLine($"\tÜrün Adı {item.Adi}");
				Console.WriteLine($"\tÜrün Fiyatı {item.Fiyati}");
				Console.WriteLine($"\tÜrün Açıklaması {item.UrunAciklamasi}");
				Console.WriteLine($"\tÜrün Durumu {item.Durum}");
				Console.WriteLine();
			}

			User user = new(); //User sınıfından nesne oluşturuldu
			Console.WriteLine("Email Giriniz: "); //kullanıcıdan veri istendi
			user.Email = Console.ReadLine(); //gönderilen değeri okuduk
			Console.WriteLine("Şifre Giriniz: ");
			user.Password = Console.ReadLine();
			var giris = user.KullaniciGiris(user.Email, user.Password); //metot çağırıldı (parametrelerle)
			if (giris == true)
			{
				Console.WriteLine("Hoşgeldiniz!");
			}
			else
				Console.WriteLine("Giriş Başarısız!");
		}
	}
	class Kullanici
	{
		internal int Id;
		internal string KullaniciAdi;
		internal string Sifre;
		internal string Email;
		internal string Adi;
		internal string Soyadi;
	}
	class Araba
	{
		internal int Id;
		internal string Marka;
		internal string Model;
		internal string KasaTipi;
		internal string YakitTipi;
		internal string VitesTipi;
		internal string Renk;
	}
}