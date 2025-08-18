using System.Data.Entity;//Entity framework kütüphanesini ekledik
using WindowsFormsAppAdoNet; //AdoNet projesini referans alıp kullandık dbset te 

namespace WindowsFormsAppEntityFramework
{
	public class UrunDbModel : DbContext //Entity frameworkün DbContext sınıfından miras alıyoruz 
	{//ctor - constractor kullanımı yerine ->
		public UrunDbModel() : base("name=UrunDbModel") //ef ün DbContext sınıfındaki base e connection string ismini gönderdik, sonra bu ismi tanımlayacağız
		{
			
		}
		public virtual DbSet<Category> Categories { get; set; } //Category sınıfı tanımlamak için 1.yol -> bu sayfada tanımlama, 2.yol -> başka projedeki category class ı referance almak
		//Referans almak : project - referance - add referance - istenilen projeyi ekleme yapılır
		public virtual DbSet<Product> Products { get; set; }
	}
}