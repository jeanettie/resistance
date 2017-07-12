using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resistance.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace resistance.DAL
{
    public class postContext : DbContext
    {
     
        

            public postContext() : base("postContext")
            {
            }

            public DbSet<Post> Posts { get; set; }
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
