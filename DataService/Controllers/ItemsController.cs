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
    public class ItemsController : ApiController
    {
        MyContext db = new MyContext();

        [HttpGet]
        [Route("api/getitems")]
        public IQueryable<Item> GetItems()
        {
            return db.Items.Include("Owner");
        }

        [HttpGet]
        [Route("api/itemsbyowner")]
        public IQueryable<Item> GetItemsByOwner()
        {
            var items = db.Items.Where(o => o.Owner.LastName == "Stenberg");
            return items;
        }
    }
}
