using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.WebAPI.ViewModels
{
    public class Purchase
    {
        public string PurhcaseId { get; set; }

        public DateTime DatePurchased { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public List<Product> prodcutList=new List<Product>();

    }
}