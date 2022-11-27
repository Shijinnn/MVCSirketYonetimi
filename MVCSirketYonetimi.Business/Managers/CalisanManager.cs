using MVCSirketYonetimi.Business.Interfaces;
using MVCSirketYonetimi.Data.Models.Context;
using MVCSirketYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSirketYonetimi.Business.Managers
{
    public class CalisanManager : ICalisanManager
    {
        SirketDbContext db = new SirketDbContext();
        public void Ekle(Calisan calisan)
        {
            db.Calisanlar.Add(calisan);
            db.SaveChanges();
        }

        public void Guncelle(Calisan calisan)
        {
       
            db.Entry(calisan).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<Calisan> HepsiniGetir()
        {
            var calisanlar = db.Calisanlar.ToList();
            return calisanlar;
        }

        public void Sil(int id)
        {
            var silinecekCalisan = db.Calisanlar.Find(id);
            db.Calisanlar.Remove(silinecekCalisan);
            db.SaveChanges();
        }
    }
}
