using MVCSirketYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSirketYonetimi.Business.Interfaces
{
    public interface IDepartmanManager
    {
        List<Departman> HepsiniGetir();
        void Ekle(Departman departman);
        void Guncelle(Departman departman);
        void Sil(int id);
    }
}
