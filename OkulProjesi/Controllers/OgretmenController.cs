using OkulProjesi.Models.Context;
using OkulProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkulProjesi.Controllers
{
    public class OgretmenController : Controller
    {
        CrudContext db = new CrudContext();
        // GET: Ogretmen
        public ActionResult Liste()
        {

            return View(db.Ogretmen.ToList());
        }
        [HttpGet]
        public ActionResult Kaydet()
        {
            return View("OgretmenForm");
        }
        [HttpPost]
        public ActionResult Kaydet(Ogretmen ogretmen)
        {
            if (ogretmen.Id == 0)
            {
                db.Ogretmen.Add(ogretmen);
            }
            else
            {
                var ogretmenGuncelle = db.Ogretmen.Find(ogretmen.Id);
                if (ogretmenGuncelle == null)
                {
                    return HttpNotFound();
                }
                ogretmenGuncelle.Ad = ogretmen.Ad;
                ogretmenGuncelle.Soyad = ogretmen.Soyad;
                ogretmenGuncelle.Yas = ogretmen.Yas;
                ogretmen.Cinsiyet = ogretmen.Cinsiyet;
            }
            db.SaveChanges();
            return RedirectToAction("Liste", "Ogretmen");
        }
        public ActionResult Guncelle(int id)
        {
            var model = db.Ogretmen.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("OgretmenForm", model);
        }
        public ActionResult Sil (int id)
        {
            var ogretmenSil = db.Ogretmen.Find(id);
            if (ogretmenSil == null)
            {
                return HttpNotFound();
            }
            db.Ogretmen.Remove(ogretmenSil);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}