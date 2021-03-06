﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaseControllerBaseResult.Models;

namespace BaseControllerBaseResult.Controllers
{
    //[Authorize]
    public class ValuesController : BaseController<Customer>
    {
        //GET api/values
        public BaseResult Get()
        {
            var list = new string[] { "value1", "value2" };
            return Result(list);
        }

        [HttpGet]
        public BaseResult GetAll()
        {
            try
            {
                List<Customer> list = new List<Customer>();
                list.Add(new Customer() { Id = 1, Name = "C1" });
                list.Add(new Customer() { Id = 2, Name = "C2" });
                list.Add(new Customer() { Id = 3, Name = "C3" });
                //var list = new string[] { "value1", "Value2" };
                var result = Result(list);
                throw new OverflowException();
                return result;
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet]
        public BaseResult GetCustomer(string area)
        {
            try
            {
                List<Customer> list = new List<Customer>();
                list.Add(new Customer() { Id = 1, Name = "C1" });
                list.Add(new Customer() { Id = 2, Name = "C2" });
                list.Add(new Customer() { Id = 3, Name = "C3" });
                //var list = new string[] { "value1", "Value2" };
                var result = Result(list);
                return result;
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        // GET api/values/5
        [HttpGet]
        public BaseResult GetCustomer(int id)
        {
            return Result(new Customer() { Id = 1, Name = "Dsd" });
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
