using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AQGNSHA;Initial Catalog=hastanerandevu;Integrated Security=True");
        }
        public DbSet<Brans> Branss { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Sekreter> Sekreters { get; set; }
        public DbSet<Tarih> Tarihs { get; set; }
        public DbSet<Saat> Saats { get; set; }
        public DbSet<TarihSaat> TarihSaats { get; set; }
    }
}
