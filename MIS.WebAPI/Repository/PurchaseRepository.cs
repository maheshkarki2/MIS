using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS.WebAPI.Helper;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.ViewModels;

namespace MIS.WebAPI.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public List<Purchase> GetAll()
        {
            List<Purchase> purhcaseList = JsonFileHelper.GetObjectListFromJson<Purchase>(@"~/App_Data/Purchase.json");           
            return purhcaseList;
        }

        public List<Product> GetProductsByPurchaseId(string purchaseId)
        {
            List<Product> productList=new List<Product>();
            var product = GetAll().FirstOrDefault(x => x.PurhcaseId == purchaseId);
            if (product != null)
            {
                productList=product.prodcutList;
            }
            return productList;
        }

        public Purchase GetPurchaseById(string purchaseId)
        {
            return GetAll().FirstOrDefault(x => x.PurhcaseId == purchaseId);
        }
    }
}