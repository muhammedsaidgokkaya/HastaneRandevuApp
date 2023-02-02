using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        public bool Secim { get; set; }
        public string Tahlil { get; set; }
        public string Gun { get; set; }
        public string Saat { get; set; }
        public int HastaId { get; set; }
        public string HastaName { get; set; }
        public Hasta Hasta { get; set; }
        public int DoktorId { get; set; }
        public string DoktorName { get; set; }
        public Doktor Doktor { get; set; }
        public int BransId { get; set; }
        public string BransName { get; set; }
        public Brans Brans { get; set; }
    }
}
