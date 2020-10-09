using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagmati.Models.ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsNew { get; set; }
    }
}