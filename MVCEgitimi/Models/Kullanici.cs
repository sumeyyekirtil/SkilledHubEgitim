namespace MVCEgitimi.Models
{
	//added kullanici(user) class for model binding controller
	public class Kullanici
	{//kullanici özellikleri için property oluşturma
		public int Id { get; set; }
		public string Ad { get; set; }
		public string? Soyad { get; set; }
		public string? Email { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }
		public DateTime KayitTarihi { get; set; } = DateTime.Now;
	}
}