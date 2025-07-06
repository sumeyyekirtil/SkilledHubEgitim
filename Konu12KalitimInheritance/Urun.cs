namespace Konu12KalitimInheritance
{
	public class Urun : OrtakOzellikler //kalıtım alındı
	{
		public string? TeknikOzellikler { get; set; }
		public decimal Fiyat { get; set; }
		public int Kdv { get; set; }
		public int Iskonto { get; set; }
	}
}