using System.Collections.Specialized;
using System.Collections;//hazır kütüphanelerin gelmesi için ekleme yapılabilir
using System.Text;//using kısmını biz ekledik

namespace Konu16CollectionsKoleksiyonlar
{//ekleme-çıkarma yapılabilir, birden fazla değişken tutar içinde
	internal class Program
	{
		static void Main(string[] args)//args : birden fazla string değişkeni bir yerde tutmaya yarar
		{
			Console.WriteLine("Collections-Koleksiyonlar!");
			//Ornek1();//main metotunda çağırıldı
			//Ornek2();
			//Ornek3();
			//Ornek4();
			//Ornek5();
			//Ornek6();
			//Ornek7();
			//Ornek8();
			//StringBuilderKullanimi();
			ListKullanimi();
		}
		static void Ornek1()
		{
			ArrayList arraylist = new();//dizi listedi oluşturuldu
			arraylist.Add(1);//()içine değer verilmez ise kabul etmiyor
			arraylist.Add(2);//istenilen veri türü saklanabilir
			arraylist.Add(3);
			foreach (var item in arraylist)
			{
				Console.WriteLine(item); //listedeki elemanları ekrana yazdır
			}
			Console.WriteLine();
			Console.WriteLine("ArrayList ilk eleman : " + arraylist[0]); //listedeki index numarasına göre çağırılır
			Console.WriteLine("ArrayList ikinci eleman : " + arraylist[1]);
			Console.WriteLine("ArrayList üçüncü eleman : " + arraylist[2]);
		}
		static void Ornek2()
		{
			ArrayList arraylist = new();//dizi listedi oluşturuldu
			arraylist.Add("İstanbul");//()içine değer verilmez ise kabul etmiyor
			arraylist.Add("Ankara");//istenilen veri türü saklanabilir
			arraylist.Add("İzmir");
			arraylist.Add("Erzincan");
			arraylist.Add("Çankırı");
			foreach (var item in arraylist)
			{
				Console.WriteLine(item); //listedeki elemanları ekrana yazdır
			}
			Console.WriteLine();
			Console.WriteLine("ArrayList ilk eleman : " + arraylist[0]); //listedeki index numarasına göre çağırılır
			Console.WriteLine("ArrayList ikinci eleman : " + arraylist[1]);
			Console.WriteLine("ArrayList üçüncü eleman : " + arraylist[2]);
			Console.WriteLine();
			Console.WriteLine("ArrayList de sıralama yapabiliriz");
			arraylist.Sort();//alfanumeric sıralama metotu
			foreach (var item in arraylist)
			{
				Console.WriteLine(item);//listedeki elemanları ekrana yazdırır (tümünü)
			}
			Console.WriteLine();
			arraylist.Reverse();
			foreach (var item in arraylist)
			{
				Console.WriteLine(item);//reverse metotu ile sondan sıralar
			}
		}
		static void Ornek3()
		{//farklı türleri farklı sınıflandırırken arrayList ile tümünü sıralayabiliriz
			int tamSayi = 18;
			double kesirli = 18.8;
			ArrayList arrayList = new();
			arrayList.Add("Ankara");
			arrayList.Add(tamSayi);
			arrayList.Add(kesirli);
			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			for (int i = 0; i < arrayList.Count; i++)//for döngüsü
			{
				Console.WriteLine(arrayList[i]);
			}
		}
		static void Ornek4()
		{
			var strings = new StringCollection();
			//strings.Add(24); //sadece string değer atanabilir
			strings.Add("İstanbul");
			strings.Add("Ankara");
			strings.Add("İzmir");
			strings.Add("Erzincan");
			Console.WriteLine("StringCollection");
			foreach (var item in strings)
			{
				Console.WriteLine(item);
			}
		}
		static void Ornek5()
		{
			var dictionary = new StringDictionary(); //key-value şeklinde veri saklayabilir
			dictionary.Add("18", "Çankırı");
			dictionary.Add("24", "Erzincan");
			dictionary.Add("06", "Ankara");
			dictionary.Add("34", "İstanbul");
			dictionary.Add("16", "Bursa");
			Console.WriteLine();
			Console.WriteLine("String Dictionary");
			Console.WriteLine("dictionary 06: " + dictionary["06"]);
			Console.WriteLine();
			foreach (var item in dictionary)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			Console.WriteLine("String Dictionary Keys"); //anahtarları sıralar
			foreach (var item in dictionary.Keys)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("String Dictionary Values"); //değerleri sıralar
			foreach (var item in dictionary.Values)
			{
				Console.WriteLine(item);
			}
		}
		static void Ornek6()
		{
			Stack stack = new(); //Stack sınıfı programlamada LIFO - son giren ilk çıkar kuralıyla çalışır.
								 // stack.add(); stack de listeye add metoduyla ekleme yapışmaz
			stack.Push("Çankırı");
			stack.Push("Ankara");
			stack.Push("İzmir");
			stack.Push("Muğla");
			stack.Push("Denizli");
			stack.Push(34);
			stack.Push(56);
			Console.WriteLine("Stack");
			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop()); //stack de nesneler üst üste koyulmuş gibidir verilere de üstten çekerek ulaşılır
			}
		}
		static void Ornek7()
		{
			Queue queue = new(); // Queue sınıfı programlamada FIFO- ilk giren ilk çıkar mantığıyla çalışır
			queue.Enqueue("Lale");
			queue.Enqueue("Sümbül");
			queue.Enqueue("Kasımpatı");
			queue.Enqueue("Zambak");
			queue.Enqueue(18); //obje aldığı için her türlü veri kabul eder
			while (queue.Count > 0)
			{
				Console.WriteLine(queue.Dequeue());
			}
		}
		static void Ornek8()
		{
			Dictionary<string, string> dictionary = new(); //hangi veri tipinden oluşacapını bizim belirlediğimiz liste sistemi
			dictionary.Add("book", "kitap");
			dictionary.Add("18", "Çankırı");
			dictionary.Add("34", "İstanbul");
			dictionary.Add("06", "Ankara");
			Console.WriteLine(dictionary["book"]); //book anahtarın değerini getirir
			Console.WriteLine();
			Dictionary<int, string> dictionary2 = new(); //int değerler için
			dictionary2.Add(1, "kitap");
			dictionary2.Add(18, "Çankırı");
			dictionary2.Add(34, "İstanbul");
			dictionary2.Add(06, "Ankara");
			Console.WriteLine();
			Console.WriteLine("dictionary2 Values");
			foreach (var item in dictionary2)
			{
				Console.WriteLine(item.Value);
			}
			Console.WriteLine();
			Console.WriteLine("dictionary2 Keys");
			foreach (var item in dictionary2)
			{
				Console.WriteLine(item.Key);
			}
			Console.WriteLine();
			Console.WriteLine("dictionary2 Keys-Values");
			foreach (var item in dictionary2)
			{
				Console.WriteLine(item.Key + " " + item.Value);
			}
		}
		static void StringBuilderKullanimi()
		{ //String Builder : birleştirmeye yarar
			Console.WriteLine("String Builder Kullanımı");
			var sb = new StringBuilder();
			sb.Append(1); //Append ekleme metodu
			sb.Append(4);
			sb.Append(8);
			Console.WriteLine("sb: " + sb.ToString()); //string leri birleştirir
			Console.WriteLine();

			StringBuilder sb2 = new();
			sb2.Append("Ankara");
			sb2.Append("İstanbul");
			sb2.Append("Mersin");
			Console.WriteLine("sb2: " + sb2.ToString());
			Console.WriteLine();
			
			StringBuilder sb3 = new();
			sb3.Append(" Ankara ");
			sb3.Append(Environment.NewLine); //Yeni satır ekler arasına
			sb3.Append(" İstanbul ");
			sb3.Append(Environment.NewLine);
			sb3.Append(" Mersin ");
			sb3.Append(Environment.NewLine);
			Console.WriteLine("sb3: " + sb3.ToString());
			Console.WriteLine();

			StringBuilder sb4 = new();
			sb4.AppendLine("Erzincan"); //satıra ekle metodu: AppendLine
			sb4.AppendLine("İstanbul");
			sb4.Append(Environment.NewLine);
			sb4.AppendLine("Mersin");
			Console.WriteLine("sb4: " + sb4.ToString());
			Console.WriteLine();
			
		}
		static void ListKullanimi() //User sınıfı kullanıldı
		{
			List<string> sehirler = new(); //string veri tipi alabilen bir liste
			sehirler.Add("Ankara");
			sehirler.Add("İstanbul");
			sehirler.Add("Konya");
			sehirler.Add("Mersin");
			Console.WriteLine("Şehirler : ");
			foreach (var item in sehirler)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			List<User> users = new(); //User içindeki property lere değer atandı
			users.Add(new User
			{
				Id = 1,
				Name = "Sümeyye",
				Password = "123"
			});
			users.Add(new User
			{
				Id = 1,
				Name = "Selim",
				Password = "456"
			});
			Console.WriteLine("Kullanıcılar: ");
			foreach (var item in users)
			{
				Console.WriteLine(item.Name);
			}
			List<User> kullanicilar = new() //liste oluşturmanın bir diğer yöntemi 'dizi gibi'
			{
				new User
				{
					Id = 3,
					Name = "Ali",
					Password = "789"
				},
				new User
				{
					Id =4,
					Name = "Sevde",
					Password = "1071"
				}
			};
			Console.WriteLine();
			Console.WriteLine("Kullanıcılar2: ");
			foreach (var kullanici in kullanicilar)
			{
				Console.WriteLine(kullanici.Name);
			}
			var yenikullanici = new User()
			{
				Id = 5,
				Name = "Alp",
				Password = "678"
			};
			Console.WriteLine("Kullanıcılar listesinde yenikullanici var mı? " + kullanicilar.Contains(yenikullanici)); //Contains metodu yeni değer var ise yazdırır
			kullanicilar.Add(yenikullanici); //Add ile eklenen yeni üye artık Contains ile true dönebilir ekleme gerçekleşti
			Console.WriteLine("Kullanıcılar listesinde yenikullanici var mı? " + kullanicilar.Contains(yenikullanici));
			foreach (var item in kullanicilar)
			{
				Console.WriteLine(item.Name);
			}
			Console.WriteLine();
			Console.WriteLine("Listedeki kayıt sayısı : " + kullanicilar.Count); //Count ile toplam veri sayısını alır (değerin boş olup olmadığına bakar)
																				 //foreach ile açık veriler yazırılabilir
			Console.WriteLine();
			kullanicilar.Insert(0, yenikullanici); //Insert metodu ile ekleme yapıldı (index değeri ile birlikte ekleme yapar)
			foreach (var item in kullanicilar)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}