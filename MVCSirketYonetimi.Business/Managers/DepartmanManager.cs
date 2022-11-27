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
    public class DepartmanManager : IDepartmanManager
    {
        SirketDbContext db = new SirketDbContext();
        public void Sil(int id)
        {
            var silinecekDepartman = db.Departmanlar.Find(id);
            db.Departmanlar.Remove(silinecekDepartman);
            db.SaveChanges();
        }
        public void Ekle(Departman departman)
        {
            db.Departmanlar.Add(departman);
            db.SaveChanges();
        }

        public void Guncelle(Departman departman)
        {
            
            db.Entry(departman).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<Departman> HepsiniGetir()
        {
            var departmanlarListesi = db.Departmanlar.ToList();
            return departmanlarListesi;
        }

       
    }
}
