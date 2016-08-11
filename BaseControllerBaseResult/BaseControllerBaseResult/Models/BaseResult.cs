using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseControllerBaseResult.Models
{
    public class BaseResult : ActionResult
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public string Status { get; set; }
        public string Exception { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            throw new NotImplementedException();
        }
    }
}