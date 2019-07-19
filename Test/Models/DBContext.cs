using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
    }
}