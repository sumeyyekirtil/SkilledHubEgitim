using System.Data.SqlTypes;
using System.Resources;

namespace Konu08SiniflarClasses
{
	public class SiniftaMetotKullanimi
	{
		string kurucuMetot;
		public SiniftaMetotKullanimi() //contructor kurucu metot: kısayolu ctor
		{
			Console.WriteLine();
			kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindki kodalrı çalıştırır. Kurucu metotlar değişkenler gibi veri almazkar ve void ifadesi de bulunmaz ,sınıfın adıyla aynı ad  kullanılarak oluşturulur"; //yukarıda tanımladığımız kurucumetot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık
			Console.WriteLine(kurucuMetot);
			Console.WriteLine();
		}

		public bool LoginKontrol(string kullanici, string sifre)
		{
			if (kullanici == "admin" && sifre == "123456")
			{
				return true;
			}
			return false;
		}

		public int ToplamaYap(int sayi1, int sayi2)
		{
			return sayi1 + sayi2;
		}

		public static string StatikDegisken = "Sınıflarda metot ve değişken de kullanabiliriz";
		public string DinamikDegisken = "Bu degişken statik değildir!";
		
	}
}