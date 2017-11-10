using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment6.DataAccess
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultConnection")
        {}

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}