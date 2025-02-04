var builder = WebApplication.CreateBuilder(args);
//MVC servislerini ekliyoruz.
//MVC mimarisinin etkinleştirilmesini sağlar.
//Hem Controller'lar hem de View'lerin kullanılabilmesini sağlar.
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Statik dosyalar (CSS, JavaScript, resimler) wwwroot klasöründe tutulur. Bunların kullanılabilmesi için statik dosya desteğini aktif hale getirdik.
//wwwroot içindeki CSS, JavaScript gibi dosyaların tarayıcı tarafından erişilebilir olmasını sağlar.
//Eğer bunu eklemeseydik, tarayıcıdaki CSS veya JavaScript dosyalarımız yüklenmezdi.
app.UseStaticFiles();
//Routing, kullanıcıdan gelen URL isteklerini ilgili Controller ve Action metoduna yönlendirmek için kullanılır.
//ASP.NET Core’un gelen isteklere nasıl yanıt vereceğini belirleyen yönlendirme mekanizmasını etkinleştirir.
//Eğer bunu eklemeseydik, gelen isteklerin hangi Controller’a gideceği bilinmezdi.
app.UseRouting();
//Uygulamanın hangi Controller ve Action metodu varsayılan olarak çalıştırılacak, bunu belirledik.
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
/*    Varsayılan olarak HomeController'ın Index() metodu çalıştırılacak.
    {controller=Home} → Eğer URL’de hangi controller çağrılacağı belirtilmezse HomeController çalışacak.
    {action=Index} → Eğer hangi action çağrılacağı belirtilmezse Index() çalışacak.
    {id?} → Opsiyonel bir parametredir. Eğer bir ID gelirse, action metoduna iletilebilir.

Örnek URL'ler:

    https://localhost:5001/ → HomeController içindeki Index() metodu çalışır.
    https://localhost:5001/Product/Details/5 → ProductController içindeki Details(5) metodu çalışır.

 * */


app.Run();

/*
 Controller: Kullanıcıdan gelen isteği alır ve uygun yanıtı oluşturur.

 Action: Controller içinde bulunan ve isteğe yanıt veren metodlardır.

 Model: Veritabanı veya iş mantığı ile ilgili veri yapılarını temsil eder.

 View: HTML ve Razor kullanarak sayfaların görünümünü oluşturur.

 Razor: HTML ile C# kodlarını birleştirerek dinamik sayfalar oluşturmamızı sağlar.

 RazorView: Razor motorunu kullanarak oluşturulan View dosyalarıdır.

 wwwroot: Statik dosyalar (CSS, JS, resimler vb.) burada tutulur.

 builder.Build(): Servislerin eklendiği ve uygulamanın oluşturulduğu metottur.

 app.Run(): Uygulamayı başlatan ve gelen istekleri dinleyen metottur.
*/