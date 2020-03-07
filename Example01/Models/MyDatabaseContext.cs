using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example01.Models
{
    public class MyDatabaseContext:DbContext
    {
        public MyDatabaseContext() : base("MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Punishment> Punishments { get; set; }
    }
}