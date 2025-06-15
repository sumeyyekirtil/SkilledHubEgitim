namespace Konu06Diziler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Diziler!"); // [] yapının yanına işaretiyle tanımlama yapılır
	        //Dizi Oluşturma
			//int[] sayi;
			int[] ogrenciler = new int[6];//ogrenciler isminde int veri tipi taşıyan ve 7 elemandan oluşan bir dizi oluşturduk. Dizi boyutu artmaz azalmaz.
										  //Dizilerde indis denilen yapı vardır ve içine eklenecek elemanlar 0 dan başlar
			ogrenciler[0] = 100;
			ogrenciler[1] = 200;
			ogrenciler[2] = 300;
			ogrenciler[3] = 400;
			ogrenciler[4] = 500;
			ogrenciler[5] = 600;
			Console.WriteLine("Seçilen öğrenci no: " + ogrenciler[5]);
			ogrenciler[5] = 550;
			Console.WriteLine("Seçilen öğrenci no: " + ogrenciler[5]);
			//ogrenciler[6] = 666; //Dizilere başlangıçta kaç elemandan oluşacağı tanımlanmışsa o sayının dışına çıktığımızda hata alırız!

			string[] isimler = new string[6];
			isimler[0] = "Alp";
			isimler[1] = "Ali";
			isimler[2] = "Sümeyye";
			isimler[3] = "Betül";
			isimler[4] = "Elif";
			isimler[5] = "Selim";
			Console.WriteLine("isimler[5]: " + isimler[5]);

			int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
			Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]); 
			ogrenciler2[3] = 550;
			Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]); //output:550
			Console.WriteLine();

			string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep telefonu", "Beyaz Eşya", "Kitap" }; //Diziye eklenecek kayıt sayısı belirsizse bu şekilde de dizi tanımlaması yapılabilir
			Console.WriteLine("kategoriler 1 : " + kategoriler[1]);
			kategoriler[1] = "Aksesuar";
			Console.WriteLine("kategoriler 1 : " + kategoriler[1]);
			Console.WriteLine();

			string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };
			Console.WriteLine(urunler[1]);
		}
	}
}