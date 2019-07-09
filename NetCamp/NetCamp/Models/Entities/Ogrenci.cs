using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCamp.Models.Entities
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
    }
}
