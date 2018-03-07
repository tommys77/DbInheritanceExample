using ModelsEF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MyContext : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }

        public MyContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MyInitializer());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }

    


}
