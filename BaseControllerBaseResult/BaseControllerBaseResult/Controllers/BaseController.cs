using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaseControllerBaseResult.Models;

namespace BaseControllerBaseResult.Controllers
{
    public class BaseController<T> : ApiController where T : class
    {
        public static BaseResult<T> ReturnResult(object model)
        {
            var result = new BaseResult<T>();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public static BaseResult<T> ReturnsError(object model)
        {
            var result = new BaseResult<T>();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }
    }
}
