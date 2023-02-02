using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Tarih
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TarihSaat> TarihSaats { get; set; }
    }
}
