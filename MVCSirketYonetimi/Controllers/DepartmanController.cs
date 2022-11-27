using MVCSirketYonetimi.Business.Interfaces;
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
    public class DepartmanController : Controller
    {
        GenericDepartman
        SirketDbContext db = new SirketDbContext();
        //Http Protokolleri
        //HtttpGet
        //HttpPost
        //ActionResult'lar geriye View döndürür.


        // GET: Calisan
        [HttpGet]
        public ActionResult Index()
        {
            var departmanlarListesi = manager.HepsiniGetir();
            return View(departmanlarListesi);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost]
        public ActionResult Ekle(Departman departman)
        {
            manager.Ekle(departman);
            return RedirectToAction("Index", "Departman");

        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var departman = db.Departmanlar.Find(id);
            if (departman == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", departman);

        }
        [HttpPost]
        public ActionResult Guncelle(Departman departman)
        {
            manager.Guncelle(departman);
            return RedirectToAction("Index", "Departman");

        }


        public ActionResult Sil(int id)
        {
            var departman = db.Departmanlar.Find(id);
            if (departman == null)
            {
                return HttpNotFound();
            }
            manager.Sil(id);
            return RedirectToAction("Index", "Departman");

        }


    }
}