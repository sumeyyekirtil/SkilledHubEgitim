using System.Data.Entity;//Entity framework kütüphanesini ekledik
using WindowsFormsAppAdoNet; //AdoNet projesini referans alıp kullandık dbset te 

namespace WindowsFormsAppEntityFramework
{
	public class UrunDbModel : DbContext //Entity frameworkün DbContextsınıfından miras alıyoruz 
	{
		public UrunDbModel() : base("name=UrunDbModel") //ef ün DbContext sınıfındaki base e connection string ismini gönderdik, sonra bu ismi tanımlayacağız
		{
			
		}
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Product> Products { get; set; }
	}
}