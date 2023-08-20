using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CsharpCBContext: DbContext
    {
        public CsharpCBContext() :base("CsharpConnection")
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Unit> units { get; set; }

    }
}