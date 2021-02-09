using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OkulProjesi.Models.Entities
{
    public class Ogrenci :BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }
        public int ogretmenId { get; set; }
        public virtual Ogretmen ogretmen { get; set; }
    }
}