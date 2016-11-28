using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIS.WebAPI.ViewModels;

namespace MIS.WebAPI.IRepository
{
    public interface ISaleRepository
    {
        Sale GetSaleById(string purchaseId);
        List<Sale> GetAll();
        List<Product> GetProductsBySaleId(string purchaseId);
    }
}
