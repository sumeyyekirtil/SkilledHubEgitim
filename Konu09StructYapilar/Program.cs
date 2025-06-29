namespace Konu09StructYapilar
{//string harici bütün değişkenler değer tipli
 //string-class referans tipli
 //değer-referans tipli olmak üzere bellekte iki şekilde tutulur
 //değer tipli değişkenlerden bahsedip string hariç değişkenler tutulur -steak- alanında tutulur, struct da bu gruptandır
 //referans tipli veri nesneden ulaşılıp -heap- alanında tutulur
 //steak bloğunda tutulan veriler program ayaktayken kullanır ve işlem bitince bellekten otomatik silinir
 //referans tipliler bir süre bellekte kalır : tutulacak süre garbage-collection ile düzenlerler
	public struct Yapi //struct lar daha küçük hemen ayağa kalkan projelerde kullanıma uygundur
	{
		//public string ad = "ali"; //struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
		public int sayi;
		public string metin;
		public void Metot() //main de çağırılmalı
		{
			Console.WriteLine("yapı içindeki metot çalıştı");
		}
	}
	internal class Program
	{
		struct Kimlik //Kimlik adında struct oluşturuldu ve değişkenler eklendi
		{
			public string ad;
			public string soyad;
			public int yas;
			public string dogumyeri;
			public struct Adres //iç içe struct oluşturulabilir
			{
				public int Id { get; set; }
				public int KapiNo { get; set; }
				public string Cadde { get; set; }
				public string Sokak { get; set; }
				public string Ilce { get; set; }
				public string Sehir { get; set; }
				public string AcıkAdres { get; set; }
			}
			internal string Birlestir(string ad, string soyad)//struct da tanımlanıyor, main de çağırılıyor
			{
				return ad + " " + soyad.ToUpper();
			}
			public void ToplamiYaz(int sayi1, int sayi2)
			{
				Console.WriteLine("Sayı 1 ve Sayı 2 nin Toplamı: ");
				Console.WriteLine(sayi1 + sayi2);
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Struct-Yapılar!");
			Yapi ilkyapi = new Yapi(); //nesne oluşturuldu
			ilkyapi.metin = "yapı metni";
			ilkyapi.sayi = 18;
			ilkyapi.Metot();
			Console.WriteLine(ilkyapi.metin);

			//Struct ile yapı kurma
			Kimlik kimlik = new Kimlik();
			kimlik.ad = "Eşref";
			kimlik.soyad = "Ay";
			kimlik.dogumyeri = "İstanbul";
			kimlik.yas = 23;
			Console.WriteLine();

			//Struck ile kurulan yapıyı kullanma
			Console.WriteLine("Kimlik Bilgileri: ");
			Console.WriteLine("Ad : {0}, Soyad : {1}", kimlik.ad, kimlik.soyad);
			Console.WriteLine("Doğum Yeri: " + kimlik.dogumyeri);
			Console.WriteLine("Yaşı: " + kimlik.yas);
			Console.WriteLine();

			Console.WriteLine(kimlik.Birlestir("Ali İhsan", "Aras"));
			kimlik.ToplamiYaz(10, 8);

			Kimlik.Adres adres = new Kimlik.Adres();
			adres.AcıkAdres = "Papatya Sokak";
			adres.Ilce = "Sarıyer";
			adres.Sehir = "İstanbul";
			adres.KapiNo = 8;
			Console.WriteLine();
			Console.WriteLine("Kullanıcı Adres Bilgileri: ");
			Console.WriteLine(adres.AcıkAdres);
			Console.WriteLine(adres.Ilce);
			Console.WriteLine(adres.Sehir);

		}
	}
}