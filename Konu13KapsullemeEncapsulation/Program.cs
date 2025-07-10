namespace Konu13KapsullemeEncapsulation
{//OOP de kapsülleme : veri-metot başka yerden görülmeyecek şekilde üstünün kapatılmasıdır.
 //Soyut veri tipi abstract datatype(ADT) denir
 //Kullanım amacı basit yanlışlarla kodların bozulmasını önlemek
 //Korunmak istenen veriler private(özel) olarak nitelendirilir
 //Get/Set ile veri erişimi sağlanır
 //Property ile veri erişimin 2. yoludur.
	public class Bolum //(ilaç)
	{
		private string BolumAdi; //dışarıda erişime kapalı değişken : private
								 //Accessor (Getter)
		public string GetBolumAdi()
		{
			return BolumAdi;
		} //Geriye private BolumAdi değişkenini döndüren metot
		public void SetBolumAdi(string istenenEgitimi) //değer ataması yapılacak metot
		{
			if (istenenEgitimi == "Yazılım Mühendisliği")
			{
				Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", istenenEgitimi);
			}
			else BolumAdi = istenenEgitimi;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kapsülleme - Encapsulation!"); //ilaç dış kapsülüne benzer (olası yanlışları engeller yani başka yerden ulaşılmaması gereken içerik)
			Bolum bolum = new Bolum();
			Console.WriteLine("Kurumumuzdaki Bölümler:");
			Console.WriteLine("1-Elektronik");
			Console.WriteLine("2-Bilgisayar Mühendisliği");
			Console.WriteLine("3-Grafik Tasarım");
			Console.WriteLine("Lütfen Bölüm Adını Giriniz;");
			var bolumAdi = Console.ReadLine(); //ekrandan alınan değeri okuyup var ile oluşturduğumuz bolumadi değişkenine atadık
			bolum.SetBolumAdi(bolumAdi); //bolum içerisindeki SetBolumAdi metoduna bolum adını gönderdik, private değişkenine atama yapıldı
			Console.WriteLine("Kayıt Olunacak Bölüm Adı : " + bolum.GetBolumAdi()); //bolum içerisindeki GetBolumAdi() metodunu direkt ekrana yazdırdık çünkü GetBolumAdi()

			Fakulte fakulte = new Fakulte
			{
				Bolum = "Yazılım Mühendisliği"
			};
			Console.WriteLine("Fakülte = {0} {1} ", fakulte.Bolum, "2.değer");

			University universite = new("Maliye");
			Console.WriteLine("Üniversite Bölümü : " + universite.Bolum);
			//universite.Bolum = ""; 
			//hatalı veri gönderimi
			//bu şekilde bir veri gönderimi yapamayız! çünkü property read only (set bloğu kaldırıldı) 
		}
	}
	//Özgen (Property) kullanarak kapsülleme
	public class Fakulte
	{
		private string bolum; //Fakülte sınıfının içindeki bolum değişkenini private tanımlayarak kapsüllemiş olduk, böylece bu değişkene sadece aşağıdaki get, set metotlarıya erişilebilir

		//PROPERTY İ METOTA ÇEVİRME İŞLEMİ
		public string Bolum //bölümün değeri okunmak istenirse get bloğu çalışıyor
		{//public string Bolum {get; set;} açık hali:
			get { return bolum; } //{get; set;} //set : ayarlamak
								  //get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerideki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür

			set //bölüme dışarıdan veri atanırsa set bloğu çalışır
			{//set bloğunun 'value' özelliği
				if (value == "Yazılım Mühendisliği")
				{
					Console.WriteLine("Ünüversitemizde {0} bölümü bulunmamaktadır!", value);
				}
				else bolum = value;
			} //set bloğu dışarıya açık Bolum değişkenine atanan veriyi alıp içeride kapsüllediğimiz private bolum değişkenine atar
		}
	}
	//Yalnız okunur (Read only property)
	public class University
	{ //atama yapılmaz sadece bölüm gönderilir
		private string bolum;
		public University(string str)
		{
			bolum = str;
		}
		public string Bolum { get { return bolum; } } //set iptal edildiğinde read only olur
	}
}