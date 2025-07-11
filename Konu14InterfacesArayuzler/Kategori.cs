namespace Konu14InterfacesArayuzler
{
	public class Kategori : ISinifGereksinimleri
	//class interface içindeki tüm propertylere sahip olduğu için 'implement interface' yapmaya gerek kalmıyor
	//interface deki tüm prop ları copy-paste yaparak hataları düzeltebiliriz 'throw hatalarını':(get; set; leri düzeltmemek için)
	{//metotlarda tanımlamak zorundayız
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		//kategoriye ait özellikler
		public bool UstMenudeGoster { get; set; }
		public bool YanMenudeGoster { get; set; }
	}
}