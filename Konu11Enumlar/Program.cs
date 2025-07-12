namespace Konu11Enumlar
{
	internal class Program
	{
		//Enum (Numaratör) ler nesneleri numaralandırmak için kullanılır
		/*
		 * *Enum tipler üzerindeki kısıtlar
		 * 1-Enum blokunda metot tanımlanamaz
		 * 2-Arayüz(Interface) kullanamazlar
		 * 3-Enum blokunda property kullanılmaz
		 */
		enum Aylar : byte //byte koleksiyondaki numaraların veri tipinin byte türünden olacağını belirtiyor
		{
			Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
		}
		enum SiparisDurumu
		{//sonradan ekleme yapılabilir
			Hazırlanıyor, Hazırlandı, KargoBekliyor, Kargolandı
		}
		enum Meyveler : int
		{//sıra numaraları atanabilir
			Elma = 3, Armut = 7, Çilek = 1
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enumlar - Enumarate!");
			byte a = (byte)Meyveler.Armut; //atama yapıldı
			byte b = (byte)Meyveler.Elma;
			byte c = (byte)Meyveler.Çilek;
			Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma} = {b}, {Meyveler.Çilek} = {c}");
			Ornek1(SiparisDurum: 2); //tanımlanan enum index değeri çağırılıyor
		}
		static void Ornek1(int SiparisDurum)
		{
			if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
				Console.WriteLine("Siparişiniz Hazırlanıyor!");
			if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
				Console.WriteLine("Siparişiniz Hazırlandı!");
			if (SiparisDurum == (int)SiparisDurumu.KargoBekliyor)
				Console.WriteLine("Siparişiniz Hazır!");
			if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
				Console.WriteLine("Siparişiniz Kargoda!");
		}
	}
}