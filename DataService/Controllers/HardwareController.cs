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
    public class HardwareController : ApiController
    {
        // GET: api/Hardware
        MyContext db = new MyContext();

        [HttpGet]
        [Route("api/gethardware")]
        public IQueryable<Hardware> GetHardware()
        {
            return db.Hardware;
        }
    }
}
