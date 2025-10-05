namespace MVCEgitimi.Models
{
	////added adres(address) class for model binding controller
	public class Adres
	{
		public int Id { get; set; }
		public string Sehir{ get; set; }
		public string Ilce{ get; set; }
		public string AcikAdres{ get; set; }
	}
}