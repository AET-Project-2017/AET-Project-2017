using AETProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DBConfig : DbContext
    {
        public DBConfig() : base("AETFinalDBV1D") { }
        public DbSet<User> User { get; set; }
        public DbSet<Address> Adress { get; set; }
    }
}
