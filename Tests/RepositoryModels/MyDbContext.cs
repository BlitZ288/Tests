using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Tests.Models;

namespace Tests.RepositoryModels
{
   public class MyDbContext: DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
