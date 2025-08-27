using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics; //pending hatası için

namespace MVCEgitimi.Models
{
	public class UyeContext : DbContext //DbContext sınıfı Nuget dan yüklediğimiz entity framework core paketleri ile gelmektedir ve ef ile vt işlemlerini yapabilmemizi sağlar
	{
		public DbSet<Uye> Uyeler { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override on enter
		{
			optionsBuilder.UseSqlServer("server=ASUS-PRO; database=UyelerSH; Integrated Security=True; TrustServerCertificate=True");
			optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); //vt oluştururken aldığımız PendingModelChangesWarning hatasının çözümü
			//ignore - görmezden gel
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Uye>().HasData(
				new Uye
				{
					Id = 1,
					Email = "admin@gmail.com",
					Ad = "User",
					Soyad = "Admin",
					DogumTarihi = DateTime.Now,
					KullaniciAdi = "admin",
					Sifre = "123",
					SifreTekrar = "123",
					TcKimlikNo = "12345678911",
					Telefon = "26262626221"
				});
			base.OnModelCreating(modelBuilder);
		}
	}
}