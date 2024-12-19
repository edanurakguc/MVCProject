using Microsoft.AspNetCore.Mvc;
using Proje.Models;

public class KullaniciController : Controller
{
    private readonly productdb _context;

    public KullaniciController(productdb context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string kullaniciAdi, string sifre)
    {
        var kullanici = _context.Kullanicilar
            .FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

        if (kullanici != null)
        {
            return RedirectToAction("Index", "Kategori");
        }

        ViewBag.Message = "Geçersiz kullanıcı adı veya şifre.";
        return View();
    }
}
