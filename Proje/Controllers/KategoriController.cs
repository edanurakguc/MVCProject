using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

public class KategoriController : Controller
{
    private readonly productdb _context;

    public KategoriController(productdb context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var kategoriler = _context.Kategoriler.ToList();
        return View(kategoriler);
        
    }
}
