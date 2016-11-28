using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using MIS.WebAPI.Helper;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.ViewModels;
using Newtonsoft.Json;

namespace MIS.WebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetALl()
        {
            List<Product> productList=new List<Product>();
            productList=JsonFileHelper.GetObjectListFromJson<Product>(@"~/App_Data/Product.json");
            return productList;
        }

        public Product GetProduct(string productCode)
        {
            return GetALl().FirstOrDefault(x => x.ProductCode == productCode);
        }

        public bool Save(Product product)
        {
            try
            {
                var filePath = HostingEnvironment.MapPath(@"~/App_Data/Product.json");
                string serializedProduct = JsonConvert.SerializeObject(product);
                string text = File.ReadAllText(filePath);
                string text2 = text.Remove(text.Length - 1, 1);
                System.IO.File.WriteAllText(filePath, text2+','+ serializedProduct+"]");
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<ProductCount> GetProductCount()
        {
            List<ProductCount> productCountList=new List<ProductCount>();
            ProductCount pc1 = new ProductCount()
            {
                Type = "Electronics",
                Value = 10
            };
            ProductCount pc2 = new ProductCount()
            {
                Type = "Sports",
                Value=20
            };
            ProductCount pc3 = new ProductCount()
            {
                Type = "Fashion",
                Value = 20
            };
            productCountList.Add(pc1);
            productCountList.Add(pc2);
            productCountList.Add(pc3);
            return productCountList;
        }

        public bool SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}