namespace Konu14InterfacesArayuzler
{
	internal interface IVeritabaniIslemleri
	{//bu arayüzü kullanacak class lar aşağıdaki metot imzalarını içermek zorundadır!!
	 //CRUD(Create-Read-Update-Delete) metot imzaları
		void Add(string name); //ekle
		void Update(int id); //güncelle
		void Delete(int id); //sil
		void GetAll(); //listele-okuma
					   //interfacelerde metotlar açıkça yazılmaz, sadece geri dönüş tipi, adı ve parametresi belirtilir.
	}
}