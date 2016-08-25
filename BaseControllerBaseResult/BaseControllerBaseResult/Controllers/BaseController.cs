using System;
using System.Collections.Generic;
using System.Web.Http;
using BaseControllerBaseResult.Models;

namespace BaseControllerBaseResult.Controllers
{
    public class BaseController<T> : ApiController where T : class
    {        
        public BaseResult Result(IEnumerable<T> model)
        {
            var result = new BaseResult();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public BaseResult Result(T model)
        {
            var result = new BaseResult();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public BaseResult Result(object model)
        {
            var result = new BaseResult();
            result.Data = model;
            result.Status = "OK";
            result.Exception = "None";
            return result;
        }

        public BaseResult Error(Exception exception)
        {
            var result = new BaseResult();
            result.Message = exception.Message;
            result.Status = "Error";
            result.Exception = exception.GetBaseException().Message;
            return result;
        }
    }
}
