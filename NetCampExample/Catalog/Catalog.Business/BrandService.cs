﻿using Catalog.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Business
{
   public class BrandService
    {
        public List<Brand> GetList()
        {
            using (var db=new EFCoreContext())
            {
                return db.Brands.ToList();
            }
        }
        public Brand Add(Brand model)
        {
            using (var db = new EFCoreContext())
            {
                db.Brands.Add(model);
                return model;
            }
        }
        public Brand Update(Brand model)
        {
            using (var db = new EFCoreContext())
            {
                db.Brands.Update(model);
                return model;
            }
        }
        public bool Delete(int id)
        {
            using (var db = new EFCoreContext())
            {
                var model = db.Brands.FirstOrDefault(q => q.Id == id);
                if (model==null)
                {
                    return false;
                }
                db.Brands.Remove(model);
                return true;
            }
        }
    }
}
