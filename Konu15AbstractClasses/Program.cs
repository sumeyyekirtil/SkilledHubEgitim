namespace Konu15AbstractClasses
{//interface: property-metot imzası tutulur
 //class: property-metot kendileri tutulur
 //interface ve class ların mix hali hem interface hem classın yaptığını yapıyor. Abstract sınıflarda interface gibi metot bildirimi yapılıp class gibi metot tanımlanabilir.
 //Bir sınıfa en fazla 1 abstract sınıf inherit(kalıtım) edilebiliyor ancak aynı sınıfta 1 den fazla interface inherit edilebiliyor.
 //kalıtım yöntemiyle abstract classdan alınıp sınıf oluşturulur ise metot kullanılabilir, new ile yeni nesne oluşturulamaz
 //TAMAMİYLE kalıtım amaçlı oluşturulmuş sınıf türüdür.
 //metot imzası oluşturulur ve kalıtım yapılabilir.
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Abstract-Classes!");
			Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz. Database nesnesi oluşturulmuyor!(abstract olduğu için)
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
		//abstract altına izin veriyor, classlarda izin vermiyor
		public abstract void Delete();//crud
		public abstract void Update(); //metot imzaları
		public abstract void Get();
	}
	class SqlServer : Database //implement abstract yapıyor
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
	class Oracle : Database //implement abstract yapıyor
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