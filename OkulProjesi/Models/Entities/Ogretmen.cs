using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OkulProjesi.Models.Entities
{
    public class Ogretmen :BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }
        public virtual List<Ogrenci> ogrenciSayisi { get; set; }
    }
}