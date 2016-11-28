using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MIS.WebAPI.Controllers;
using MIS.WebAPI.Tests.StructureMap;
using Microsoft.Practices.Unity;

namespace MIS.WebAPI.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void ProductComtrollerGetAll()
        {
            TestBootstrapper.SetUp();
            ProductController controller=new ProductController();
            Response result = controller.GetAll();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Body);
            Assert.AreEqual(true, result.Success);
        }
    }
}
