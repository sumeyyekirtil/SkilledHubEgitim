namespace MVCEgitimi
{//uygulamay� g�sterir
	public class Program
	{//web uygulama ayarlar� genellikle bozulmaz
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews(); //Uygulamada MVC controller view yap�s�n� kullanaca��z

			var app = builder.Build(); //builder nesnesi �zerinden eklenen servislerle beraber app nesnesi olu�turuluyor

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment()) //uygulama development yani lokaldeki geli�tirme ortam�nda de�ilse
			{
				app.UseExceptionHandler("/Home/Error"); //global hata yakalamay� kullan ve olu�an hatalarda kullan�c�ya burada yazan ekrana y�nlendir
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			//app import
			app.UseHttpsRedirection(); //http den https ye otomatik y�nlendirme yap
			app.UseRouting(); //uygulamada routing mekanizmas�n� aktif et

			app.UseAuthorization(); //uygulamada yetkilendirme kullan�m�n� aktif et

			app.MapStaticAssets(); //wwwroot klas�r�ndeki statik dosyalar� haritala
			app.MapControllerRoute( //route yap�s�n� a�a��daki ayarlarla kullan
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}") //adres �ubu�unda bekledi�imiz url yap�s�
				.WithStaticAssets();

			app.Run(); //uygulamay� yukar�daki yap�land�rmalarla �al��t�r.
		}
	}
}