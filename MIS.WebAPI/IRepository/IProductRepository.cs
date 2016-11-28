using MIS.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.WebAPI.IRepository
{
    public interface IProductRepository
    {
        Product GetProduct(string productCode);
        List<Product> GetALl();
        List<ProductCount> GetProductCount();

        bool Save(Product product);
    }
}
