using DataAccess;
using ModelsEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataService.Controllers
{
    public class OwnerController : ApiController
    {
        MyContext db = new MyContext();

        [HttpGet]
        [Route("api/owner")]
        public IQueryable<Owner> GetOwner()
        {
            return db.Owner;
        }
    }
}
