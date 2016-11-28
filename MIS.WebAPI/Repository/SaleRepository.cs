using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.ViewModels;

namespace MIS.WebAPI.Repository
{
    public class SaleRepository : ISaleRepository
    {
        public List<Sale> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsBySaleId(string purchaseId)
        {
            throw new NotImplementedException();
        }

        public Sale GetSaleById(string purchaseId)
        {
            throw new NotImplementedException();
        }
    }
}