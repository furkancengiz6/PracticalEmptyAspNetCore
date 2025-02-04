using Microsoft.AspNetCore.Mvc;

namespace PracticalEmptyAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        //Index() action metodu tarayıcıdan / adresine yapılan isteklere yanıt verir.
        public IActionResult Index()
        {
            //ViewData["Title"] = "Ana Sayfa"; → Sayfaya başlık göndermek için kullanıldı.
            ViewData["Title"] = "Ana Sayfa";
            //return View(); → Views/Home/Index.cshtml dosyasını çağırır.
            return View();
        }
    }
}
//HomeController, kullanıcının ana sayfayı açmasını sağlar.

