using NetCamp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCamp.Models.Services
{
    public class OgrenciServisi
    {
        public OgrenciServisi()
        {
            if (GlobalData.Ogrenciler==null)
            {
                GlobalData.Ogrenciler = new List<Ogrenci>();
            }
        }
        public List<Ogrenci> GetList()
        {
           return GlobalData.Ogrenciler;
        }
    }
}
