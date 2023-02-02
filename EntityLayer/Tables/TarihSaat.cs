using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class TarihSaat
    {
        [Key]
        public int Id { get; set; }
        public int TarihId { get; set; }
        public string TarihName { get; set; }
        public Tarih Tarih { get; set; }
        public int SaatId { get; set; }
        public string SaatName { get; set; }
        public Saat Saat { get; set; }
    }
}
