using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.UsersEntity;
namespace Entities
{
    public class DbUsers : DbContext
    {
        public DbUsers() { }
        public DbUsers(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
        public DbSet<Admin> Admins { set; get; }
        public DbSet<Teacher> Teachers { set; get; }
        public DbSet<Student> Students { set; get; }

    }
}
