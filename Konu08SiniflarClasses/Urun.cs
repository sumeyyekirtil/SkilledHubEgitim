namespace Konu08SiniflarClasses
{
	public class Urun
	{
		//class içimde değişken -field- kullanımı
		internal int Id;
		internal string Adi;
		internal decimal Fiyati;
		// class içinde property kullanımı
		public string UrunAciklamasi { get; set; } //prop tab kısayolu
		public string Markasi { get; set; }
		public bool Durum { get; set; }
	}
}