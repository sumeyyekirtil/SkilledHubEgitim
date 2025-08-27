using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //mesajları türkçeleştirmek için kullanılır.

namespace MVCEgitimi.Models
{
	public class Uye
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Ad alanı boş geçilemez!"), StringLength(50)] //her attribute altındaki property için geçerlidir 
		//String uzunluğu en fazla 50 karakter olsun
		public string Ad { get; set; }
		[Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
		public string Soyad { get; set; }
		[EmailAddress(ErrorMessage = "Geçersiz Email Adresi!"), StringLength(50)]
		public string? Email { get; set; }
		[Phone(ErrorMessage = "Geçersiz Telefon Formatı!")]
		public string? Telefon { get; set; }
		[Display(Name = "TC Kimlik Numarası"), StringLength
			(11)] //ekranda TcKimlikNo yerine kullanıcıya göre görünüm sağlanır.
		[MinLength(11, ErrorMessage = "{0} 11 karakter olmalıdır!")]
		[MaxLength(11, ErrorMessage = "{0} 11 karakter olmalıdır!")]
		public string? TcKimlikNo { get; set; }
		[Display(Name = "Doğum Tarihi")]
		public DateTime? DogumTarihi { get; set; }
		[Display(Name = "Kullanıcı Adı")]
		public string? KullaniciAdi { get; set; }
		[Display(Name = "Şifre")]
		[StringLength(15, ErrorMessage = "{0} {2} Karakterden Az Olamaz!", MinimumLength = 5)]
		[Compare("Sifre")] //sifre property si ile karşılaştır
		public string? Sifre { get; set; }
		public string? SifreTekrar { get; set; }
	}
}
