using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Practices.Unity;
using MIS.WebAPI.IRepository;
using MIS.WebAPI.ViewModels;
using Newtonsoft.Json;

namespace MIS.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PurchaseController : ApiController
    {
        [Dependency]
        public IPurchaseRepository _purchaseRepository { get; set; }
        // GET: api/Purchase
        [Route("api/purchase/getAllPurchases")]
        public Response GetAll()
        {
            try
            {
                var result = _purchaseRepository.GetAll();
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // GET: api/Purchase/5
        public Response GetPurchaseById(string id)
        {
            try
            {
                var result = JsonConvert.SerializeObject(_purchaseRepository.GetPurchaseById(id));
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        public Response GetAllProductByPurchaseId(string id)
        {
            try
            {
                var result = JsonConvert.SerializeObject(_purchaseRepository.GetProductsByPurchaseId(id));
                return Response.Ok(result);
            }
            catch (Exception ex)
            {
                return Response.BadRequest(ex.Message);
            }
        }

        // POST: api/Purchase
        public void Post([FromBody]Purchase value)
        {

        }

        // PUT: api/Purchase/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Purchase/5
        public void Delete(int id)
        {
        }
    }
}
