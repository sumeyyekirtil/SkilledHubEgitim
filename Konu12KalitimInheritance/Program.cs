using System.Net.WebSockets;
using System.Threading.Channels;

namespace Konu12KalitimInheritance
{
	class Arac
	{
		public string AracTuru;
		public void KornaCal()
		{
			Console.WriteLine("Kornaya Basıldı!");
		}
	}
	class Otomobil : Arac //:Arac ile bu sınıftaki içerikleri otomobil sınıfında kullanmak için miras aldık
	{
		public string Marka { get; set; }
		public string Model { get; set; }
	}
	class Yat : Arac
	{
		public int Uzunluk { get; set; }
		public int Kamara { get; set; }
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kalıtım, Miras Alma (Inheritance)!");
			Arac arac = new Arac(); //nesne türettik
			arac.AracTuru = "Araba"; //değişken atadık
			Console.WriteLine("arac.AracTuru = " + arac.AracTuru);

			Otomobil otomobil = new();
			otomobil.AracTuru = "Otomobil"; //Normalde Otomobil classında AracTuru yok
			otomobil.Marka = "Togg";
			otomobil.Model = "T10X";
			Console.WriteLine("otomobil.AracTuru : " + otomobil.AracTuru);
			otomobil.KornaCal(); //KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor
			Console.WriteLine();

			Kategori kategori = new()
			{
				Name = "Elektronik",
				UstMenudeGoster = true,
				CreateDate = DateTime.Now
			};
			if (kategori.UstMenudeGoster == true)
			{
				Console.WriteLine($"kategori bilgileri :\n Adı : {kategori.Name} - Ekleme Tarihi : {kategori.CreateDate}");
			}
			Console.WriteLine();
			Urun urun = new()
			{
				Name = "Klavye",
				Fiyat = 299,
				Kdv = 20,
				CreateDate = DateTime.Now
			};
			Console.WriteLine("Ürün Bilgileri");
			Console.WriteLine($"Adı: {urun.Name}");
			Console.WriteLine($"Fiyat: {urun.Fiyat}");
			Console.WriteLine($"Kdv: {urun.Kdv}");
			Console.WriteLine($"Eklenme Tarihi: {urun.CreateDate}");

			Cizici[] birCizici = new Cizici[5];
			birCizici[0] = new DogruCiz();
			birCizici[1] = new DaireCiz();
			birCizici[2] = new KareCiz();
			birCizici[3] = new SilindirCiz();
			birCizici[4] = new Cizici();

			foreach (var item in birCizici)
			{
				item.Ciz(); //çiz metodunu çalıştır
			}
		}
		//Polimorfizim - Çokbiçimlilik
		public class Cizici
		{
			public virtual void Ciz() //virtual keyword ü ile bu metodu override-ezilebilir hale getiriyoruz
			{
				Console.WriteLine("Cizici");
			}
		}
		public class DogruCiz : Cizici
		{
			public override void Ciz()
			{
				Console.WriteLine("Düz Çizgi");
			}
		}
		public class DaireCiz : Cizici
		{
			public override void Ciz()
			{
				Console.WriteLine("Daire");
			}
		}
		public class KareCiz : Cizici
		{
			public override void Ciz()
			{
				Console.WriteLine("Kare");
			}
		}
		public class SilindirCiz : Cizici
		{
			public override void Ciz()
			{
				Console.WriteLine("Silindir");
			}
		}
	}
}