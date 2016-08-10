using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaseControllerBaseResult.Models;

namespace BaseControllerBaseResult.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        public BaseResult<List<Customer>> GetAll()
        {
            try
            {
                List<Customer> list = new List<Customer>();
                list.Add(new Customer() { Id = 1, Name = "C1" });
                list.Add(new Customer() { Id = 2, Name = "C2" });
                list.Add(new Customer() { Id = 3, Name = "C3" });
                //var list = new string[] { "value1", "Value2" };
                var result = BaseController<List<Customer>>.ReturnResult(list);
                throw new OverflowException();
                return result;
            }
            catch (Exception ex)
            {
                return BaseController<List<Customer>>.ReturnsError(ex);
            }
        }

        // GET api/values/5
        [HttpGet]
        public BaseResult<Customer> GetCustomer(int id = 0)
        {
            return BaseController<Customer>.ReturnResult(new Customer() { Id = 1, Name = "Dsd" });
            //return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
