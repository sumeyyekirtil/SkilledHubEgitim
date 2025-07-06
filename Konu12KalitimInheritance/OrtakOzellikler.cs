namespace Konu12KalitimInheritance
{
	public class OrtakOzellikler //base class
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description  { get; set; } //? nullable kaydetmesini sağlar (boş geçilebilir)
		public DateTime CreateDate { get; set; }
	}
}