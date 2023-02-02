using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Doktor
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Tckn { get; set; }
        public string Password { get; set; }
        public int? BransId { get; set; }
        public Brans Brans { get; set; }
    }
}
