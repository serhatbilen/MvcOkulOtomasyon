using OkulProjesi.Models.Context;
using OkulProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkulProjesi.Controllers
{
    public class OgrenciController : Controller
    {
        CrudContext db = new CrudContext();

        // GET: Ogrenci
        public ActionResult Liste()
        {
            return View(db.Ogrenci.ToList());
        }
        [HttpGet]
        public ActionResult Kaydet()
        {
            return View("OgrenciForm");
        }
        [HttpPost]
        public ActionResult Kaydet(Ogrenci ogrenci)
        {
            if (ogrenci.Id == 0)
            {
                db.Ogrenci.Add(ogrenci);
            }
            else
            {
                var ogrenciGuncelle = db.Ogrenci.Find(ogrenci.Id);
                if (ogrenciGuncelle == null)
                {
                    return HttpNotFound();
                }
                ogrenciGuncelle.Ad = ogrenci.Ad;
                ogrenciGuncelle.Soyad = ogrenci.Soyad;
                ogrenciGuncelle.Yas = ogrenci.Yas;
                ogrenciGuncelle.Cinsiyet = ogrenci.Cinsiyet;
                ogrenciGuncelle.ogretmenId = ogrenci.ogretmenId;
            }
            db.SaveChanges();
            return RedirectToAction("Liste", "Ogrenci");
        }
        public ActionResult Guncelle (int id)
        {
            var model = db.Ogrenci.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("OgrenciForm", model);
        }
        public ActionResult Sil (int id)
        {
            var ogrenciSil = db.Ogrenci.Find(id);
            if (ogrenciSil == null)
            {
                return HttpNotFound();
            }
            db.Ogrenci.Remove(ogrenciSil);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}