namespace Konu14InterfacesArayuzler
{//class yerine insterface yazıyoruz
 //erişim belirteci yazıp-yazmamak kullanıcıya bağlı
 //Miras alındığında (:) Interface e yazılan değer classın içinde olmak zorunda; bu bir metot veya property olabilir
	interface OrnekArayuz
	{
		public int Id { get; set; }
	}
	interface IDemo
	{//interface e metot yazılmaz metot imzası yazılır
		void Goster();//geriye değer döndürmeyecek
					  //() boş olduğundan dışarıdan parametre almıyor
					  //ihtiyaca göre düzenlenebilir içi
					  //Console.WriteLine gibi metotlar kullanılmaz tanımlama bu kadar
	}
	interface icerebilecekleri : IDemo
	{
		public int sayi1 { get; set; }
		int sayi { get; set; }
		static int sayi2 { get; set; }
		void Topla();
		int ToplamaYap();

	}
	class ArayuzKullanimi : icerebilecekleri
	{
		public int sayi1 { get; set; }
		public int sayi { get; set; }
		public void Goster()
		{
			Console.WriteLine(sayi1);
		}

		public void Topla()
		{
			Console.WriteLine();
		}

		public int ToplamaYap()
		{
			return 18;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Interfaces-Arayüzler!");//her programlama dilinde yok
			ArayuzKullanimi arayuzKullanimi = new();
			arayuzKullanimi.sayi1 = 18;
			arayuzKullanimi.Goster();

			Urun urun = new Urun();
			Console.WriteLine("Ürün Adı Giriniz:");
			var urunadi = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(urunadi))
			{
				urun.Name = urunadi;
				urun.Add(urun.Name);
			}
			else
				Console.WriteLine("Ürün Adı Boş Geçilemez!");
			Console.WriteLine();

			Console.WriteLine("Kategori Adı Giriniz:");
			Kategori kategori = new Kategori();
			KategoriDBIslemleri kategoriDBIslemleri = new();
			var kategoriadi = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(kategoriadi))
			{
				kategori.Name = kategoriadi;
				kategoriDBIslemleri.Add(kategoriadi);
			}
			else
				Console.WriteLine("Ürün Adı Boş Geçilemez!");
		}
	}
}