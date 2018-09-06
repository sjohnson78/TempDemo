using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region additional namespace

using System.Data.Entity;
using Backend.Demo.Entities;

#endregion

namespace Backend.Demo.DAL
{
    // internal to this assembly, which means it is public within this project
    internal class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("name=AdHocDb")
        {
           
        }

        public DbSet<Student> Students { get; set; }
    }
}
