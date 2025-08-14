namespace MVCEgitimi.Models
{
	public class ErrorViewModel //model : projede kullanýlan classlar (user , marka , ürün classý gibi)
	{
		public string? RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}