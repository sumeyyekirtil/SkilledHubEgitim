namespace MVCEgitimi.Models
{
	public class ErrorViewModel //model : projede kullan�lan classlar (user , marka , �r�n class� gibi)
	{
		public string? RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}