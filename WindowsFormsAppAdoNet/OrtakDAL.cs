using System.Data; //veri işlemleri için
using System.Data.SqlClient; //ADO.NET kütüphaneleri

namespace WindowsFormsAppAdoNet
{
	public class OrtakDAL //DATA ACCESS LAYER
	{//sql bağlantı cümlesi
		internal SqlConnection _connection = new SqlConnection(@"server=ASUS-PRO; database=UrunYönetimiAdoNet; Integrated Security=True;"); //vt bulunduğu server bilgisini connection string olarak buraya tanımlıyorum.

		internal void ConnectionKontrol() //vt bağlantısını kontrol edecek olan metot
		{
			if (_connection.State == ConnectionState.Closed) //eğer vt bağlantısı kapalı durumda ise
			{
				_connection.Open(); //vt(veritabanı) bağlantısını aç
			}
		}
		public DataTable GetDataTable(string sqlSorgu)
		{
			DataTable dt = new DataTable(); //dt sınıfından bir nesne oluşturduk
			ConnectionKontrol(); //Bağlantı kontrolü
			SqlCommand cmd = new SqlCommand(sqlSorgu, _connection);

			SqlDataReader reader = cmd.ExecuteReader();

			dt.Load(reader); //vt daki okunulan veriyi boş dt a yüklüyoruz
			reader.Close();//sırayla vt okuyucuyu kapat
			_connection.Close(); //vt bağlantısını kapat
			cmd.Dispose(); //sql komut nesnesini yok et

			return dt;
		}
	}
}