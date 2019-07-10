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
        public Ogrenci Get(long id)
        {
            return GlobalData.Ogrenciler.FirstOrDefault(q=>q.Id==id);
        }



        public Ogrenci Insert(Ogrenci model)
        {
            model.Id=DateTime.Now.Ticks;
            GlobalData.Ogrenciler.Add(model);
            return model;
        }
        public Ogrenci Update(Ogrenci model)
        {
            var data = GlobalData.Ogrenciler.FirstOrDefault(q => q.Id == model.Id);
            var index = GlobalData.Ogrenciler.IndexOf(data);
            GlobalData.Ogrenciler[index] = model;
            return model;
        }
    }
}
