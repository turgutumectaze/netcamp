using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCamp.Models.Entities
{
    public class Ogrenci
    {
        public long Id { get; set; }
        [Required]//boş geçilemez 
        [MaxLength(10,ErrorMessage = "Kullanıcı Adı maksimum 10 karakter olabilir")]
        [MinLength(3,ErrorMessage ="Kullanıcı Adı minimum 3 karakter olabilir")]
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
    }
}
