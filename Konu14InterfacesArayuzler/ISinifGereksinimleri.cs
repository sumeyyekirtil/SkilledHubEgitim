namespace Konu14InterfacesArayuzler
{
	internal interface ISinifGereksinimleri //property tanımlama
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; } //?yazmadan geçilmesini sağlar
		public DateTime CreateDate { get; set; }
		public DateTime? UpdateDate  { get; set; }
	}
}