using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.WebAPI.ViewModels
{
    public class Sale
    {
        public string SaleId { get; set; }

        public string Quantity { get; set; }

        public string   UnitPrice { get; set; }

        public List<Product> productsList { get; set; }

        public DateTime SoldDate { get; set; }
    }
}