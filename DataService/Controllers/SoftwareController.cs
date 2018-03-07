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
    public class SoftwareController : ApiController
    {
        private MyContext db = new MyContext();

        [HttpPost]
        [Route("api/software")]
        public IHttpActionResult PostSoftware(Software software)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Items.Add(software);

            return CreatedAtRoute("DefaultApi", new { id = software.ItemId}, software);

        }

        [HttpGet]
        [Route("api/getsoftware")]
        public IQueryable<Software> GetAllSoftware()
        {
            var software = db.Software.Include("Owner").Include("Category").Include("Review");
            return software;
        }

    }
}
