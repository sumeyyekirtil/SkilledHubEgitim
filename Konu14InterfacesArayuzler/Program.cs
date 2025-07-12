namespace Konu14InterfacesArayuzler
{//class yerine interface yazıyoruz
 //erişim belirteci yazıp-yazmamak kullanıcıya bağlı
 //Miras alındığında (:) Interface e yazılan değer classın içinde kullanılmak zorunda; bu bir metot veya property olabilir
	interface OrnekArayuz
	{
		public int Id { get; set; }
	}
	interface IDemo //I/A kullanılır başında
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
	//classın içinde olması kesinlikle zorunlu denilen şeyleri önce interface de tanımlayıp, class da yapılacak işlemler yazılır
	//class a interface implament etmek : interface içindeki özellikleri, metotları class a yazmak demek
	{
		public int sayi1 { get; set; } //throw yerine geçebilir
		public int sayi { get; set; }
		public void Goster()
		{
			Console.WriteLine(sayi1);
		}
		public void Topla()
		{
			Console.WriteLine();
		}
		public int ToplamaYap() //void değerde cw kullanılabilir
		{
			return 18;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Interfaces-Arayüzler!");//her programlama dilinde yok
													   //örnek
			ArayuzKullanimi arayuzKullanimi = new();
			arayuzKullanimi.sayi1 = 21;
			arayuzKullanimi.Goster();
			//örnek
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
			//örnek
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
				Console.WriteLine("Kategori Adı Boş Geçilemez!");
		}
	}
}