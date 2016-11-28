using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIS.WebAPI.ViewModels;

namespace MIS.WebAPI.IRepository
{
    public interface IPurchaseRepository
    {
        Purchase GetPurchaseById(string purchaseId);
        List<Purchase> GetAll();
        List<Product> GetProductsByPurchaseId(string purchaseId);

    }
}
