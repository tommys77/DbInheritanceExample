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
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }

        public MyContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MyInitializer());
            Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Software>().ToTable("Software");
            
        }
    }

    


}
