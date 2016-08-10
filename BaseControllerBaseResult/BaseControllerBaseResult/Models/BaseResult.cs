using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseControllerBaseResult.Models
{
    public class BaseResult<T> where T : class
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public string Status { get; set; }
        public string Exception { get; set; }
    }
}