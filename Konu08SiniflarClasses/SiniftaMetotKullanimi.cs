using System.Data.SqlTypes;
using System.Resources;

namespace Konu08SiniflarClasses
{
	public class SiniftaMetotKullanimi
	{
		string kurucuMetot; //değişken oluşturuldu
		public SiniftaMetotKullanimi() //contructor kurucu metot: kısayolu ctor
		{
			Console.WriteLine();
			kurucuMetot = "Sınıflarda constructor(kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı ad kullanılarak oluşturulur"; //yukarıda tanımladığımız kurucumetot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık
			Console.WriteLine(kurucuMetot);
			Console.WriteLine();
		}
		//Ornek1
		public bool LoginKontrol(string kullanici, string sifre) //bool çağrıldığı yere T/F döndürür
		{
			if (kullanici == "admin" && sifre == "123456")
			{
				return true;
			}
			return false; //ne olursa olsun false dönebilir hata vermez
		}
		//Ornek2
		public int ToplamaYap(int sayi1, int sayi2)
		{
			return sayi1 + sayi2;
		}
		//Ornek3
		public static string StatikDegisken = "Sınıflarda metot ve değişken de kullanabiliriz"; //Statik yapı sınıf üzerinden bir değişkene ulaşmak için kullanılır, 'static' ifadesi ile yapılır
		public string DinamikDegisken = "Bu degişken statik değildir!"; //Yeni nesne oluşturulup ulaşılır
	}
}