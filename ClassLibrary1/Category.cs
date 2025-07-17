﻿namespace ClassLibrary1 
	//yardımcı programlardır arayüzleri bulunmaz 
    //yazdığımız uygulamanın kütüphanesi tutulur
	//classLibrery den seçilip projeye dependences ile bağlanır
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime CreateDate { get; set; }
		public List<Product>? Products { get; set; } //Category ile Product arasında 1 e çok ilişki kurduk. 1 kategoride 1 den çok ürün bulunabilir.
	}
}