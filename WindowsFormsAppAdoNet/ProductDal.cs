using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için
using System.Data.SqlClient; //ADO.NET kütüphaneleri

namespace WindowsFormsAppAdoNet
{
	public class ProductDal : OrtakDAL //kalıtım alındı
	{
		public List<Product> GetAll() //tümünü getir listesi oluşturduk
		{
			var products = new List<Product>(); //boş nesne oluşturuldu, listeyi vt çekerek dolduracağız

			ConnectionKontrol(); //güvenlik nedeniyle kapalı gelir kullandıktan sonra kapatmamız gerekiyor.

			//sqlkomutu:
			SqlCommand cmd = new SqlCommand("select * from Urunler", _connection); //sql de çalışan veri komutunu string olarak buraya yazıyoruz

			//kütüphaneden gelen sql komutu yazdığımız bir sınıf
			SqlDataReader reader = cmd.ExecuteReader(); //cmd deki sorguyu çalıştırıp reader doldurulup kayıt okuma yapılabilir

			while (reader.Read()) //reader nesnesi içerisinde okunacak kayıt olduğu sürece kayıt oku (t/f)
			{
				var product = new Product() //boş bi product oluşturup içindeki verileri reader dan çekiyoruz
				{
					Id = Convert.ToInt32(reader["Id"]),
					UrunAdi = reader["UrunAdi"].ToString(), //sttring
					StokMiktari = Convert.ToInt32(reader["StokMiktari"]), //int
					UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]), //int
					Durum = Convert.ToBoolean(reader["Durum"]) //bit
				};
				products.Add(product); //db den okunan ürünü listeye ekle
			}
			//okunacak kayıt bittiğinde:
			reader.Close();//sırayla vt okuyucuyu kapat
			_connection.Close(); //vt bağlantısını kapat
			cmd.Dispose(); //sql komut nesnesini yok et

			return products; //geriye dönüş değeri
		}
		//ikinci bağlantı-veri çekme yöntemi
		//ekle butonu için
		public int Add(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Insert into Urunler values (@UrunAdi, @UrunFiyati, @StokMiktari, @Durum)", _connection); //tüm column lar gelecekse eklemeyedebiliriz
			command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi); //addWithValue metodu 2 değişken alır parametre aracılığıyla ekrana yolluyoruz (sqlInjection ile saldırıyı önlemiş oluyoruz)
			command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
			command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
			command.Parameters.AddWithValue("@Durum", product.Durum);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();

			return sonuc;
		}

		//Güncelle kısmı için bağlantı
		public int Update(Product product)
		{//id ye göre güncelle(hepsini değil)
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Update Urunler set UrunAdi=@UAdi, UrunFiyati=@UrunFiyati, StokMiktari=@StokMiktari, Durum=@Durum where Id=@id", _connection); //tüm column lar gelecekse eklemeyedebiliriz
			command.Parameters.AddWithValue("@UAdi", product.UrunAdi); //addWithValue metodu 2 değişken alır parametre aracılığıyla ekrana yolluyoruz (sqlInjection ile saldırıyı önlemiş oluyoruz)
			command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
			command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
			command.Parameters.AddWithValue("@Durum", product.Durum);
			command.Parameters.AddWithValue("@id", product.Id);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		//sil için event oluşturduk
		public int Delete(int id)
		{//id ye göre güncelle(hepsini değil)
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Delete From Urunler where Id=@id", _connection);
			command.Parameters.AddWithValue("@id", id);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
	}
}