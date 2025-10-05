namespace MVCEgitimi.Models
{
	//farklı modelleri aynı view da göstermek için açıldı
	public class UyeSayfasiViewModel
	{ 
		//viewModel : view de kullanılacak model class ı
		public Kullanici Kullanici { get; set; } //var olan sayfa modelleri birleştirildi
		public Adres Adres { get; set; }
	}
}