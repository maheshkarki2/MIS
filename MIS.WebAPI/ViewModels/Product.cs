using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.WebAPI.ViewModels
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string   ImagePath  { get; set; }
    }
}