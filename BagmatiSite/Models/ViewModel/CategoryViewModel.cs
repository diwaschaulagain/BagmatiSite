using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bagmati.Models.ViewModel
{
    public class CategoryViewModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Photo { get; set; }

    }
}