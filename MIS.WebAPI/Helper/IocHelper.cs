using Microsoft.Practices.Unity;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.WebAPI.Helper
{
    public static class IocHelper
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IPurchaseRepository, PurchaseRepository>();
            container.RegisterType<ISaleRepository, SaleRepository>();
        }
    }
}