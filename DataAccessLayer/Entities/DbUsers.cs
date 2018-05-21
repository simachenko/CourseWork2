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
            CreateDatabaseIfNotExists<DbUsers> create = new CreateDatabaseIfNotExists<DbUsers>();
            create.InitializeDatabase(this);
        }
        
        public DbSet<User> users { set; get; }

    }
}
