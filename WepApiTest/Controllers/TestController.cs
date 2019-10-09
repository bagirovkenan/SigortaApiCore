using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiTest.DB;
using WepApiTest.Models;

namespace WepApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : BaseController
    {
       
        public TestController(ApiContext ctx):base(ctx)
        {

        }

        [HttpGet]
        public ActionResult<ICollection<Test>> Get()
        {
  
              var a = uow.GetBase<Test>().GetAll();
              return a.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Test> Get(int id)
        {

            var a = uow.GetBase<Test>().GetById(id);
            return a;
        }
    }
}