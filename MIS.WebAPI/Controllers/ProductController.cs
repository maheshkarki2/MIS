using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MIS.WebAPI.IRepository;
using Microsoft.Practices.Unity;
using MIS.WebAPI.ViewModels;
using Newtonsoft.Json;

namespace MIS.WebAPI.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ProductController : ApiController
    {
        // GET: api/Product
        [Dependency]
        public IProductRepository _productRepo { get; set; }
        [Authorize]
        [Route("api/getAllProduct")]
        public Response GetAll()
        {
            try
            {
                var result = _productRepo.GetALl();
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // GET: api/Product/5
        [Route("api/product/getProductById/{id}")]
        public Response GetProductById(string id)
        {
            try
            {
                var result = _productRepo.GetProduct(id.ToString());
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // POST: api/Product
        [Route("api/product/saveProduct")]
        public Response SaveProduct([FromBody]Product product)
        {
            try
            {
                var result = _productRepo.Save(product);
                return Response.Ok("");
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // PUT: api/Product/5
        [Route("api/product/getProductCount")]
        public Response GetProductCount()
        {
            try
            {
                var result = _productRepo.GetProductCount();
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
