using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiTest.DB;
using WepApiTest.Methots.General;
using WepApiTest.UnitOfWork;

namespace WepApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        //protected ApiContext Context = new ApiContext(DbContextOptions<ApiContext> options);

        protected ApiContext ctx;
        protected IUnitOfWork uow;
        
        public BaseController(ApiContext _ctx)
        {
            ctx = _ctx;
            uow = new UnitOfWorkClass(ctx);
        }


    }
}