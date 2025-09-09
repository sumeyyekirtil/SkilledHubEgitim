using Microsoft.AspNetCore.Authentication.Cookies;
using MVCEgitimi.Models;

namespace MVCEgitimi
{//uygulamay� g�sterir
	public class Program
	{//web uygulama ayarlar� genellikle bozulmaz
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<UyeContext>(); //projede kullanaca��m�z dbcontext s�n�f�m�z� uygulamaya tan�t�yoruz.

			// Add services to the container.
			builder.Services.AddControllersWithViews(); //Uygulamada MVC controller view yap�s�n� kullanaca��z
			builder.Services.AddSession(); //bu �ygulamada session kullan�m�n� aktif et

			//Schema hatas� ��z�m�
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
			{
				x.LoginPath = "/MVC15FilterUsing/Login"; //admin oturum a�ma sayfam�z� belirttik
			});
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

			app.UseSession(); //uygulamada session kullan�lmas� i�in hem builder hem app olarak tan�mlama yap�lmal�

			app.MapStaticAssets(); //wwwroot klas�r�ndeki statik dosyalar� haritala

			app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
			); //bu route kodlar� admin areas�na gelecek olan istekleri kar��lay�p, ilgili controller ve action lara y�nlendirme yapacak.

			app.MapControllerRoute( //route yap�s�n� a�a��daki ayarlarla kullan
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}") //adres �ubu�unda bekledi�imiz url yap�s�
				.WithStaticAssets();

			app.Run(); //uygulamay� yukar�daki yap�land�rmalarla �al��t�r.
		}
	}
}