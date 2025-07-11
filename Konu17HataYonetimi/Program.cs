﻿using ClassLibrary1;

namespace Konu17HataYonetimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hata Yonetimi!");
			Console.WriteLine();
			Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz : ");
			var sayi = Console.ReadLine();
			//KdvHesapla(int.Parse(sayi)); //yanına para cinsi yazılması, boşluk karakteri olması durumunda hata fırlatıyor
			try
			{
				KdvHesapla(int.Parse(sayi));
			}
			catch (Exception hata) //Exception a hata ismini verdik bu bize oluşan hatayı verir
			{
				Console.WriteLine("Hata Oluştu! Lütfen sadece sayısal değer giriniz!"); //kullanıcıya yönelik hata fırlatır
																						// throw; bu yine hata fırlatır
																						//oluşan hatayı loglayabiliriz
				Console.WriteLine(hata.Message);
			}
			finally
			{
				Console.WriteLine("try-catch bloğından sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabilirz. Kullanımı zorunlu değil!");
				Console.WriteLine("Bir Sayı Giriniz: ");
				var sayi2 = Console.ReadLine();
				KdvHesapla(double.Parse(sayi2));
			}
			Category category = new Category(); //ClassLibrary den bağlantı alındı
			category.Name = "Elektronik";
			Console.WriteLine(category.Name);
			Console.WriteLine();

			Product product = new Product();
			product.Name = "Oyun Bilgisayarı";
			Console.WriteLine("Ürün Adı: ");
			Console.WriteLine(product.Name);
		}
		static void KdvHesapla(double fiyat)
		{
			Console.WriteLine("Fiyat :" + fiyat);
			Console.WriteLine("Kdv :" + fiyat * 0.20);
			Console.WriteLine("Kdv Dahil Toplam Tutar :" + (fiyat + (fiyat * 0.20)));
		}
	}
}