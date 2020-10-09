using Bagmati.Models.memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bagmati.Controllers
{
    public class CategoryController : Controller
    {
        CategoryDB cdb = new CategoryDB();
        // GET: Category
        public ActionResult ManageCategory()
        {
            return View(cdb.GetALLCategory());
        }
    }
}