# ASP.NET Core MVC Empty Project

Bu proje, **ASP.NET Core Empty** şablonunu kullanarak **MVC (Model-View-Controller)** yapısına uygun şekilde yapılandırılmıştır. Proje, temel bir MVC uygulaması oluşturmayı ve statik dosya desteğini sağlamayı amaçlamaktadır.

## 📂 Proje Yapısı

```
MvcEmptyProject
│── Controllers
│   └── HomeController.cs
│── Models
│── Views
│   ├── Home
│   │   └── Index.cshtml
│── wwwroot (statik dosyalar: CSS, JS, img vb.)
│── Program.cs
│── README.md
```

## 🚀 Projeyi Çalıştırma

### 2️⃣ Bağımlılıkları Yükle ve Uygulamayı Başlat
```bash
dotnet restore
dotnet run
```

## ⚙️ Yapılandırmalar

### 1️⃣ **MVC Servislerini Ekledik**
```csharp
builder.Services.AddControllersWithViews();
```
- MVC servislerini uygulamaya ekler.
- Controller ve View'lerin kullanılmasını sağlar.

### 2️⃣ **Statik Dosyaların Kullanımını Sağladık**
```csharp
app.UseStaticFiles();
```
- wwwroot içindeki CSS, JS gibi statik dosyaların tarayıcı tarafından yüklenmesine izin verir.

### 3️⃣ **Routing Konfigürasyonu**
```csharp
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
```
- Tarayıcıdan gelen istekleri ilgili **Controller** ve **Action** metoduna yönlendirir.
- Varsayılan olarak `HomeController` içindeki `Index()` metodunu çalıştırır.

## 🎯 Varsayılan Route Yapısı
| **URL** | **Çalıştırılan Controller ve Action** |
|---------|--------------------------------------|
| `/` | `HomeController.Index()` |
| `/Home/Index` | `HomeController.Index()` |
| `/Product/Details/5` | `ProductController.Details(5)` |

## 📌 Controller (HomeController.cs)
```csharp
using Microsoft.AspNetCore.Mvc;

namespace PracticalEmptyAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Ana Sayfa";
            return View();
        }
    }
}
```
- **Controller**, kullanıcıdan gelen isteği yönetir ve doğru View'e yönlendirir.
- **Index() Action metodu**, `Views/Home/Index.cshtml` dosyasını döndürür.

## 📌 View (Index.cshtml)
```html
@{
    ViewData["Title"] = "Ana Sayfa";
}
<h1>@ViewData["Title"]</h1>
<p>Bu, MVC yapısına uygun olarak oluşturulmuş bir sayfadır.</p>
```
- **ViewData** kullanılarak sayfa başlığı dinamik hale getirilmiştir.

## 📜 Lisans
Bu proje MIT lisansı ile lisanslanmıştır.

---

💡 **Geliştirmeye katkıda bulunmak için fork edip pull request gönderebilirsiniz!** 🚀
