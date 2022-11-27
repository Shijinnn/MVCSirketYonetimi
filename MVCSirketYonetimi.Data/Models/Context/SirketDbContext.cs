using MVCSirketYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSirketYonetimi.Data.Models.Context
{
    public class SirketDbContext : DbContext
    {
        //Sql tablolarının sonuna entity framework tarafından otomatik bir şekilde eklenen '-s' çoğullaştırma takısını kaldırdık.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //Bu sınıfımız çağırıldığı anda sql ile bağlantı kurduk.
        public SirketDbContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=SirketYonetimDb;User Id=sa;Password=1234";
        }


        //Aşağıdaki entitylerimizi sql'imize tablolar şeklinde gönderdik.
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }

    }
}
