namespace Konu14InterfacesArayuzler
{
	interface OrnekArayuz //class yerine insterface yazıyoruz
		                  //erişim belirteci yazıp-yazmamak kullanıcıya bağlı
	{
		public int Id { get; set; }
	}
	interface IDemo
	{
		void Goster(); //interface e metot yazılmaz metot imzası yazılır
		               //Console.WriteLine gibi metotlar kullanılmaz tanımlama bu kadar
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Interfaces-Arayüzler!");//her programlama dilinde yok
		}
	}
}
