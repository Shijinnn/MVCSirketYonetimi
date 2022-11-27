using MVCSirketYonetimi.Business.Managers;
using MVCSirketYonetimi.Data.Models.Context;
using MVCSirketYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSirketYonetimi.Controllers
{
    public class CalisanController : Controller
    {
        CalisanManager manager = new CalisanManager();
        SirketDbContext db = new SirketDbContext();
        //Http Protokolleri
        //HtttpGet
        //HttpPost
        //ActionResult'lar geriye View döndürür.


        // GET: Calisan
        [HttpGet]
        public ActionResult Index()
        {
            var calisanlar = manager.HepsiniGetir();
            return View(calisanlar);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost]
        public ActionResult Ekle(Calisan calisan)
        {
            manager.Ekle(calisan);
            return RedirectToAction("Index", "Calisan");

        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var calisan = db.Calisanlar.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", calisan);

        }
        [HttpPost]
        public ActionResult Guncelle(Calisan calisan)
        {
            manager.Guncelle(calisan);
            return RedirectToAction("Index", "Calisan");

        }


        public ActionResult Sil(int id)
        {
            var calisan = db.Calisanlar.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            manager.Sil(id);
            return RedirectToAction("Index", "Calisan");

        }


    }
}