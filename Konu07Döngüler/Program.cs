namespace Konu07Döngüler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Döngüler!");
			Console.WriteLine("1-For Döngüsü!");
			for (int i = 0; i < 5; i++) //şart bloğu
										//i (index) değişkenini oluştur ve 0 değerini ata; i 5 den küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
										//true gelirse şart devam eder yoksa şartı sonlandırır
			{
				Console.WriteLine("i değişkeninin değerin {0}", i); //sırayla çıktı verir hepsini
			}

			Console.WriteLine(); //boşluk
			Console.WriteLine("2-While Döngüsü"); //şarta bağlı iken dönmeye devam eder, sonsuz döngüye girebilir!, şartı dışarıda tanımlanır
			int j = 0;//dışarıdan bir değişken tanımlıyoruz toplamın değerini ekrana yazdırıyoruz
			j++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program işken tanımlıyoruz
			while (j < 5) //Wile döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
			{
				Console.WriteLine("While Sayı {0} ", j);//toplamın değerini ekrana yazdırıyoruz, WriteLine string içinde + ile yazımın bir diğer çeşidi {} ile yapılır uzun kod dan kurtarır
				j++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program 
			}

			Console.WriteLine();
			Console.WriteLine("3-Do While Döngüsü"); //şart tutmasa bile ilk blok çalışır sonra şarta bakar, döngü olmasa bile bir kere do blok çalıştırılır
			int toplam = 7;
			do
			{
				Console.WriteLine("toplamın değeri : " + toplam);
			} while (toplam < 5);

			Console.WriteLine();
			string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu" };

			Console.WriteLine("4-Foreach Döngüsü");
			Console.WriteLine("Kategoriler");
			foreach (var kategori in kategoriler) //kategori(dizi öğesi, koleksiyon) kategoriler dizisindeki her bir elemana karşılık geliyor
			{
				Console.WriteLine(kategori); //şart olmadığı için dizideki öğeler kadar dönmesini sağlar
			}

			Console.WriteLine();
			//İç içe döngü kullanımı
			string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };
			foreach (var kategori in kategoriler) //kategori(dizi öğesi) kategoriler dizisindeki her bir elemana karşılık geliyor
			{
				Console.WriteLine(kategori);
				foreach (var urun in urunler) //iç içe hepsini çalıştırır bir kere kategori geri kalanı ürünlerin hepsi (başlık halinde yapar)
				{
					Console.WriteLine(urun);
				}
			}

			Console.WriteLine();
			Console.WriteLine("İç İçe For Döngüsü");
			for (int i = 0; i < 5; i++) //şartım index 0 dan başlıyor, 5 den küçükse  1 arttırarak döngüyü tamamla
			{
				Console.WriteLine($"i değişkeninin değeri {i}"); //$ ile süslü parantez aktif olur
				for (int k = 0; k < 3; k++)
				{
					Console.WriteLine($"\t k değişkeninin değeri {k}");
				}
			}
		}
	}
}