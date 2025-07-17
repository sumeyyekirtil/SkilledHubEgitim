namespace ClassLibrary1 //başka bir projede kullanmak için Dependencies - Add project referance - project click ile erişim yapılır 
{
	public interface IEntity //ınterface olarak seçim yapıldı
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
	}
}