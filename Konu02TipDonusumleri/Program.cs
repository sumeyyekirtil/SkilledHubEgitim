using System.Collections.Concurrent;
namespace Konu02TipDonusumleri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tip Dönüşümleri!");
			/*
			Implicit Casting -Otomatik dönüştürme
			char -> int -> long -> float -> double
			Explicit Casting - Manuel dönüştürme
			double -> float -> long -> int -> char
			*/

			//Implicit Casting daha küçük boyutlu bir türü daha büyük bir boyut türüne dönüştürme işlemini otomatik olarak yapar
			Console.WriteLine("Implicit Casting");
			int sayi = 9;
			double kesirliSayi = sayi; //int den double a otomatik dönüşüm
			Console.WriteLine(sayi);         //çıktı 9
			Console.WriteLine(kesirliSayi);  //çıktı 9

			//Explicit Casting türü değerin önüne parantez içine alarak manuel yapılmalıdır
			Console.WriteLine("Explicit Casting");
			double kesirliSayi2 = 9.78;
			int tamSayi = (int)kesirliSayi2; //Manuel dönüştürme double dan int e
			Console.WriteLine("kesirliSayi2:" + kesirliSayi2);
			Console.WriteLine("tamSayi:" + tamSayi);
			Console.WriteLine(); //boşluk ,<br> gibi

			Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
			int tamSayi2 = 10;
			double kesirliSayi3 = 5.25;
			bool islemSonuc = true;

			Console.WriteLine("Lütfen bir sayı giriniz:");
			var girilenDeger = Console.ReadLine();
			Console.WriteLine("Girilen değerin veri tipi: "+ girilenDeger.GetType());

			var parsayi = int.Parse(girilenDeger);// int.Parse metodu kendisine verilen string değerin tırnaklarını kaldırarak int tipine çevirir

			Console.WriteLine("int.Parse: " + (int.Parse(girilenDeger) + tamSayi2)); //dönüşümle işlem yapıldı
			Console.WriteLine("double.Parse + tamSayi2: " + (double.Parse(girilenDeger) + tamSayi2));
			Console.WriteLine("decimal.Parse + tamSayi2: " + (decimal.Parse(girilenDeger) + tamSayi2));
			Console.WriteLine();

			Console.WriteLine("Convert sınıfı metotlarıyla tip dönüştürme"); //Convert sınıfı doğru ve güvenilir veri dönüşümleri yapmanızı sağlar.
			                                                                 //Convert veri dönüştürme, akım dönüştürme işlemlerine yarar parse gibi
			Console.WriteLine(Convert.ToString(tamSayi2).GetType()); //Convert sınıfının String, Double, Int32 gibi metotları ile dönüşüm tamamlanır.
			Console.WriteLine(Convert.ToDouble(tamSayi2).GetType()); //GetType ile türü yazdırıldı
			Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
			Console.WriteLine(Convert.ToString(islemSonuc).GetType());

			object nesne = "1234567";
			Console.WriteLine("nesne nin veri tipi : " + nesne.GetType());
			nesne= Convert.ToDecimal(nesne); // nesne artık decimal türünde
			Console.WriteLine("nesne nin veri tipi : " + nesne.GetType()); //output:Decimal
			Console.WriteLine("nesne değeri :" + nesne); //değeri değişmez!
		}
	}
}