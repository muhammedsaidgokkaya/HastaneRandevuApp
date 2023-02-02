using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Brans
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doktor> Doktors { get; set; }
        public List<Randevu> Randevus { get; set; }
    }
}
