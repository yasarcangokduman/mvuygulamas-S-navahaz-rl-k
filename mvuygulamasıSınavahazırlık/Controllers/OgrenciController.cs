using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvuygulamasıSınavahazırlık.Models;

namespace mvuygulamasıSınavahazırlık.Controllers
{
    public class OgrenciController : Controller
    {
        HazirlikDbContext veritabani = new HazirlikDbContext();
        public IActionResult Index()
        {
            var sorgu = from Ogrenci in veritabani.Ogrenciler
                        join Sinif in veritabani.Siniflar on Ogrenci.SinifId equals Sinif.SinifId
                        select new OgrenciSinifModel
                        {
                            OgrenciId = Ogrenci.OgrenciId,
                            ogrenciAdi = Ogrenci.ogrenciAdi,
                            ogrenciSoyadi = Ogrenci.ogrenciSoyadi,
                            SinifAdi = Sinif.SinifAdi,
                            SinifKodu = Sinif.SinifKodu

                        };
            return View(sorgu.ToList());
            
        }
        public IActionResult Sil(int id)
        {
            Ogrenci ogrenci = veritabani.Ogrenciler.Find(id);
            veritabani.Ogrenciler.Remove(ogrenci);
            veritabani.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Ekle(Ogrenci ogrenci)
        {
            var sorgu = veritabani.Siniflar.ToList();
            ViewBag.Siniflar = new SelectList(sorgu, "SinifId", "SinifAdi");
            veritabani.Ogrenciler.Add(ogrenci);
            veritabani.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Ekle()
        {
            var sorgu = veritabani.Siniflar.ToList();
            ViewBag.Siniflar = new SelectList(sorgu, "SinifId", "SinifAdi");
            return View();
        }
        public IActionResult Guncelle(int id)
        {
            var sorgu = veritabani.Siniflar.ToList();
            ViewBag.Siniflar = new SelectList(sorgu, "SinifId", "SinifAdi");
            Ogrenci ogrenci = veritabani.Ogrenciler.Find(id);
           
            return View();
        }
        [HttpPost]
        public IActionResult Guncelle(Ogrenci ogrenci)
        {
            var sorgu = veritabani.Siniflar.ToList();
            ViewBag.Siniflar = new SelectList(sorgu, "SinifId", "SinifAdi");
            veritabani.Ogrenciler.Add(ogrenci);
            veritabani.Entry<Ogrenci>(ogrenci).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            veritabani.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
