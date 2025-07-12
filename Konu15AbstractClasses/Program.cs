namespace Konu15AbstractClasses
{//interface ve class ların mix hali 
 //metot imzası oluşturulur ve kalıtım yapılabilir
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Abstract-Classes!");
			Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz. Database nesnesi oluşturulmuyor!
			database.Add();
			database.Delete();
			Console.WriteLine();
			Database database2 = new SqlServer();
			database2.Add();
			database2.Delete();
		}
	}
	abstract class Database
	{
		public void Add()
		{
			Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
		}
		//abstract altına izin veriyor
		public abstract void Delete();//crud
		public abstract void Update();
		public abstract void Get();
	}
	class SqlServer : Database //imlement abstract yapıyor
	{
		public override void Delete()
		{
			Console.WriteLine("Sql den silindi");
		}

		public override void Get()
		{
			Console.WriteLine("SqlServer Get çalıştı");
		}

		public override void Update()
		{
			Console.WriteLine("Sql güncellendi");
		}
	}
	class Oracle : Database //imlement abstract yapıyor
		                    //oracle java altyapısı ile çalışır
	{
		public override void Delete()
		{
			Console.WriteLine("Oracle den silindi");
		}
		public override void Get()
		{
			Console.WriteLine("Oracle Get çalıştı");
		}
		public override void Update()
		{
			Console.WriteLine("Oracle güncellendi");
		}
	}
}