using Microsoft.AspNetCore.Authentication.Cookies;
using MVCEgitimi.Models;

namespace MVCEgitimi
{//uygulamayý gösterir
	public class Program
	{//web uygulama ayarlarý genellikle bozulmaz
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<UyeContext>(); //projede kullanacaðýmýz dbcontext sýnýfýmýzý uygulamaya tanýtýyoruz.

			// Add services to the container.
			builder.Services.AddControllersWithViews(); //Uygulamada MVC controller view yapýsýný kullanacaðýz
			builder.Services.AddSession(); //bu ýygulamada session kullanýmýný aktif et

			//Schema hatasý çözümü
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
			{
				x.LoginPath = "/MVC15FilterUsing/Login"; //admin oturum açma sayfamýzý belirttik
			});
			var app = builder.Build(); //builder nesnesi üzerinden eklenen servislerle beraber app nesnesi oluþturuluyor

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment()) //uygulama development yani lokaldeki geliþtirme ortamýnda deðilse
			{
				app.UseExceptionHandler("/Home/Error"); //global hata yakalamayý kullan ve oluþan hatalarda kullanýcýya burada yazan ekrana yönlendir
														// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			//app import
			app.UseHttpsRedirection(); //http den https ye otomatik yönlendirme yap
			app.UseRouting(); //uygulamada routing mekanizmasýný aktif et

			app.UseAuthorization(); //uygulamada yetkilendirme kullanýmýný aktif et

			app.UseSession(); //uygulamada session kullanýlmasý için hem builder hem app olarak tanýmlama yapýlmalý

			app.MapStaticAssets(); //wwwroot klasöründeki statik dosyalarý haritala

			app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
			); //bu route kodlarý admin areasýna gelecek olan istekleri karþýlayýp, ilgili controller ve action lara yönlendirme yapacak.

			app.MapControllerRoute( //route yapýsýný aþaðýdaki ayarlarla kullan
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}") //adres çubuðunda beklediðimiz url yapýsý
				.WithStaticAssets();

			app.Run(); //uygulamayý yukarýdaki yapýlandýrmalarla çalýþtýr.
		}
	}
}