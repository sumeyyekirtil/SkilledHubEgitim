using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için
using System.Data.SqlClient; //ADO.NET kütüphaneleri

namespace WindowsFormsAppAdoNet
{
	public class ProductDal : OrtakDAL
	{
		public List<Product> GetAll() //tümünü getir listesi oluşturduk
		{
			var products = new List<Product>(); //boş nesne oluşturuldu, listeyi vt çekerek dolduracağız

			ConnectionKontrol(); //güvenlik nedeniyle kapalı gelir kullandıktan sonra kapatmamız gerekiyor.
								 
			//sqlkomutu:
			SqlCommand cmd = new SqlCommand("select * from Urunler", _connection); //sql de çalışan veri komutunu string olarak buraya yazıyoruz

			//kütüphaneden gelen sql komutu yazdığımız bir sınıf
			SqlDataReader reader = cmd.ExecuteReader(); //cmd deki sorguyu çalıştırıp reader doldurulup kayıt okuma yapılabilir

			while (reader.Read()) //reader nesnesi içerisinde okunacak kayıt olduğu sürece
			{
				var product = new Product() //boş bi product oluşturup içindeki verileri reader dan oluşturuyoruz
				{
					Id = Convert.ToInt32(reader["Id"]),
					UrunAdi = reader["UrunAdi"].ToString(),
					StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
					UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]),
					Durum = Convert.ToBoolean(reader["Durum"])
				};
				products.Add(product); //db den okunan ürünü listeye ekle
			}//okunacak kayıt bittiğinde:
			reader.Close();//sırayla vt okuyucuyu kapat
			_connection.Close(); //vt bağlantısını kapat
			cmd.Dispose(); //sql komut nesnesini yok et
			return products; //geriye dönüş değeri
		}
	}
}