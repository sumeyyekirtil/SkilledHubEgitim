namespace SOLIDPrensipleri
{
	internal class Program
	{
		static void Main(string[] args)
		{//Anayasaya benzetilebilir
			Console.WriteLine("SOLID Prensipleri - Clean Code!");
			Console.WriteLine("Robert Celil Martin tarafından öne sürülen geliştilecek yazılımın esnek yeniden kullanılabilri sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür");
			Console.WriteLine("");

			Console.WriteLine("S - Single Responsibility (Tek Sorumluluk Prensibi)");
			Console.WriteLine(" \t 1 sınıf veya metodun sadece 1 sorumluluğunun olması gerekir!"); //her vt için farklı crud işlemleri gerçekleştirilmeli

			Console.WriteLine("O - Open-Closed Principle (Açık-Kapalı Prensip)");
			Console.WriteLine(" \t Bir sınıf veya metot var olan özelliklerini korumalı değişikliğe izin vermemelidir"); //rastgele metot ve özellik silinmemeli/değiştirilmemeli

			Console.WriteLine("L - Liskov Substitution (Liskov Değişikliği)");
			Console.WriteLine(" \t Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları türedikleri üst sınıfların yerine kullanabilmeliyiz"); //kalıtım yapısını kullanarak projeler herhangi bir aksaklığa uğramadan çalışabilmeli
			Console.WriteLine("I - Interface Segregation (Arayüz Ayırma)");
			Console.WriteLine(" \t Sorumlulukların hepsini tek bir arayüzde toplamak yerine özelleştirilmiş birden fazla arayüz kullanmalıyız"); //1 Arayüz de bütün özellikler toplanmamalı, birden fazla class ı aynı yerden idare etme

			Console.WriteLine("D - Dependency Inversion (Bağımlılığı tersine çevirme)");
			Console.WriteLine(" \t Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. Özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır."); //farklı arayüzler yapılmalı class larla bağlılıkları fazla olmamalı alt seviye sınıflar üst sınıfı yönetmemeli
		}
	}
}