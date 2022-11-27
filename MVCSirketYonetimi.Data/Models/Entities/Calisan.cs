using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSirketYonetimi.Data.Models.Entities
{
    public class Calisan : BaseEntity
    {
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public int departmanId { get; set; }
        public Departman Departman { get; set; }
    }
}
