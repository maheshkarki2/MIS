using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.Repository;

namespace MIS.Ioc
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
