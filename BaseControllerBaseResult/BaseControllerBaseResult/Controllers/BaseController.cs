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
        public BaseResult ReturnResult(List<T> model)
        {
            var result = new BaseResult();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public BaseResult ReturnResult(T model)
        {
            var result = new BaseResult();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public BaseResult ReturnResult(Exception exception)
        {
            var result = new BaseResult();
            result.Data = exception.Message;
            result.Status = exception.HResult.ToString();
            result.Exception = exception.InnerException.ToString();
            return result;
        }
    }
}
