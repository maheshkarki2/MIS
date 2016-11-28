using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.WebAPI.Controllers
{
    public class Response
    {
        public object Body { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public bool ErrMsg { get; set; }

        public static Response Ok(object body, bool hasLogicError = false)
        {

            Response response = new Response
            {
                Body = body,
                Success = true,
                ErrMsg = hasLogicError
            };

            return response;
        }

        public static Response BadRequest(string error)
        {
            Response response = new Response
            {
                Success = false,
                Message = error
            };
            return response;
        }
    }
}