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
        
        public DbUsers(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            
        }
        
        public DbSet<User> users { set; get; }

    }
}
