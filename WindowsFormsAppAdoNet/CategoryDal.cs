using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için
using System.Data.SqlClient; //ADO.NET kütüphaneleri

namespace WindowsFormsAppAdoNet
{
	public class CategoryDal : OrtakDAL
	{
		public int Add(Category category)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Insert into Kategoriler (Name, Description, CreateDate, Durum) values (@Name, @Description, @CreateDate, @Durum)", _connection); //tüm column lar gelecekse eklemeyedebiliriz
			command.Parameters.AddWithValue("@Name", category.Name); //addWithValue metodu 2 değişken alır parametre aracılığıyla ekrana yolluyoruz (sqlInjection ile saldırıyı önlemiş oluyoruz)
			command.Parameters.AddWithValue("@Description", category.Description);
			command.Parameters.AddWithValue("@CreatDate", category.CreateDate);
			command.Parameters.AddWithValue("@Durum", category.Durum);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		public int Update(Category category)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Update Kategoriler (NameName=@, Description=@Description, CreateDate=@CreateDate, Durum=@Durum) where Id=@KatId", _connection); //tüm column lar gelecekse eklemeyedebiliriz
			command.Parameters.AddWithValue("@Name", category.Name); //addWithValue metodu 2 değişken alır parametre aracılığıyla ekrana yolluyoruz (sqlInjection ile saldırıyı önlemiş oluyoruz)
			command.Parameters.AddWithValue("@Description", category.Description);
			command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
			command.Parameters.AddWithValue("@Durum", category.Durum);
			command.Parameters.AddWithValue("@KatId", category.Id);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		public int Delete(int id)
		{//id ye göre güncelle(hepsini değil)
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Delete From Kategoriler where Id=@id", _connection);
			command.Parameters.AddWithValue("@Id", id);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		public Category Find(int id)
		{//id ye göre güncelle(hepsini değil)

			Category category = null;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand("Select * From Kategoriler where Id=@id", _connection);
			command.Parameters.AddWithValue("@Id", id);
			var reader = command.ExecuteReader();
			if (reader != null)
			{
				while (reader.Read())
				{ //sırayla yazılmalı
					category.Id = reader.GetInt32(0);
					category.Name = reader.GetString(1);
					category.Description = reader.GetString(2);
					category.Durum = reader.GetBoolean(3);
					category.CreateDate = reader.GetDateTime(4);
				}
			}
			command.Dispose();
			_connection.Close();
			return category;
		}
	}
}