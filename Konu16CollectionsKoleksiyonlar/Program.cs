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
			Ornek4();
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
	}
}
