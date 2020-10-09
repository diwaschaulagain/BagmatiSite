using Bagmati.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagmati.Models.memory
{
    public class CategoryDB
    {
        BagmatiDBEntities bdb = new BagmatiDBEntities();
        public List<CategoryViewModel> GetALLCategory()
        {
            List<CategoryViewModel> clst = new List<CategoryViewModel>();
            List<tblCategory> tblst = bdb.tblCategories.ToList();
            foreach (tblCategory item in tblst)
            {
                CategoryViewModel cv = new CategoryViewModel();
                cv.CategoryId = item.CategoryId;
                cv.CategoryName = item.CategoryName;
                cv.Photo = item.Photo;
                clst.Add(cv);
            }
            return clst;
        }
    }
}