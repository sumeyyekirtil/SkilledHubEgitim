namespace WindowsFormsAppAdoNet
{
	public class Product
	{ //ürün propları
		public int Id { get; set; }
		public string UrunAdi { get; set; } //name
		public decimal UrunFiyati { get; set; } //price
		public int StokMiktari { get; set; } //stock
		public bool Durum { get; set; } //active
	}
}