namespace Konu14InterfacesArayuzler
{
	internal interface IVeritabaniIslemleri
	{
		//bu arayüzü kullanacak class lar aşağıdaki metot imzalarını içermek zorundadır!!
		//CRUD(Create-) metot imzaları
		void Add(string name); //ekle
		void Update(int id); //güncelle
		void Delete(int id); //sil
		void GetAll(); //listele
		//interfacelerde metotlar açıkça yazılmaz, sadece geri dönüş tipi, adı ve parametresi belirtilir.
	}
}
