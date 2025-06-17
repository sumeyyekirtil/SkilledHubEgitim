using System;
using System.Data.SqlTypes;

namespace Konu10StringSinifi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("String Sınıfı!");
			string degisken;
			char karakter = 'F'; //char tek karakter değer alır
			string metinlericin = "metinler için mi kullanıyorduk?";
			Console.WriteLine(metinlericin);
			//Ornek1();
			//StringMetotlari();
			SplitMetodu();
		}
		static void Ornek1()
		{
			string birMetin = "Ankara başkenttir";
			String birsayi = " 123456789";
			System.String birTarih = "02.05.2021";
			string kod = "//5456dfgd\n"; //buradaki \n enter görevindedir ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
			Console.WriteLine(birMetin.GetType());
			Console.WriteLine(birsayi.GetType());
			Console.WriteLine(birTarih.GetType());
			Console.WriteLine(kod);

			string s = "Barış Manço";
			Console.WriteLine("For Döngüsü Çıktısı");
			for (int i = 0; i < s.Length; i++)
			{
				Console.WriteLine("s[" + i + "] =" + s[i]);
			}
			Console.WriteLine("Foreach Döngüsü Çıktısı");
			foreach (var item in s)
			{
				Console.WriteLine(item);
			}
		}
		static void StringMetotlari()
		{
			string metin = "Stringin Birçok Metodu Vardır";
			Console.WriteLine("metin in karakter sayısı(metin.Length) :" + metin.Length); //Length metin değişkeninde kaç karakter olduğunu verir
			var klon = metin.Clone(); //Clone metodu metin değişkeninin klonlayıp klon değişkenine atar.
			Console.WriteLine("metinin klonu : " + klon);
			metin = "My Name is Ali";
			Console.WriteLine(metin + " EndsWith i: " + metin.EndsWith("i")); //EndsWith metodu boolean döner
			Console.WriteLine(metin + " EndsWith r: " + metin.EndsWith("r")); //EndsWith metodu ne ile bittiğine bakar
			Console.WriteLine();
			Console.WriteLine(metin + " StartsWith s: " + metin.StartsWith("s")); //StartsWith metodu başlangıcını kontrol eder ve boolean değer döndürür
			Console.WriteLine(metin + " StartsWith m: " + metin.StartsWith("m")); //büyük küçük harfe duyarlı bir metot
			Console.WriteLine(metin + " StartsWith M: " + metin.StartsWith("M"));
			Console.WriteLine();
			Console.WriteLine(metin + " IndexOf name : " + metin.IndexOf("name")); //IndexOf metodu büyük küçük harke duyarlı 
			Console.WriteLine(metin + " IndexOf Name : " + metin.IndexOf("Name")); //IndexOf metodu metin içinde yoksa -1 döndürür metin içinde varsa index numarasını verir
			Console.WriteLine(metin + " LastIndexOf i : " + metin.LastIndexOf("i"));
			Console.WriteLine();
			Console.WriteLine(metin + " Insert 0 : " + metin.Insert(0,"Merhabaa: ")); //metnin değeri değişmez sadece başına merhaba ekleniyor
			Console.WriteLine(metin);
			Console.WriteLine();
			Console.WriteLine(metin + " Substring 2 : " + metin.Substring(2)); //IndexOf metodu büyük küçük harke duyarlı 
			Console.WriteLine(metin + " Substring 2, 5 : " + metin.Substring (2, 5)); //Metini belirtilen indexten parçalar
			Console.WriteLine();
			Console.WriteLine(metin + " ToLower 2, 5 : " + metin.ToLower());
			Console.WriteLine(metin + " ToUpper 2, 5 : " + metin.ToUpper());
			Console.WriteLine(metin + " ToLower()Replace 2, 5 : " + metin.ToLower().Replace(" ", "-"));
			Console.WriteLine(metin + " Remove 2 : " + metin.Remove(2));
			Console.WriteLine(metin + " Remove 2, 5: " + metin.Remove(2, 5));
		}
		static void SplitMetodu()
		{
			string sehirler = "İstanbul, Ankara, İzmir, Bursa, Adana, Antalya";
			string[] sehirlerArray = sehirler.Split(','); //Split metodunu , ile ayırmak için kullandık
			Console.WriteLine("4. Şehir : " + sehirlerArray[3]);
			foreach (var item in sehirlerArray)
			{
				Console.WriteLine("Şehir : " + item);
			}
			Console.WriteLine();
			Console.WriteLine("tarih parçalama");
			var tarih = DateTime.Now.ToShortDateString();
			Console.WriteLine("tarih: " + tarih);
			var tarihparcalari = tarih.Split(".");
			var gun = tarihparcalari[0];
			var ay = tarihparcalari[1];
			var yil = tarihparcalari[2]; 
			Console.WriteLine("gün: " + gun + "\n ay: "+ ay + "\n yil: " + yil);

		}
	}
}