using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
using Entities.TimetableEntity;

namespace Entities
{
    public class DbTimetable : DbContext
    {
        public DbTimetable(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            CreateDatabaseIfNotExists<DbTimetable> create = new CreateDatabaseIfNotExists<DbTimetable>();
            create.InitializeDatabase(this);
        }

        

        public DbSet<Group> groups { set; get; }
        public DbSet<Week> weeks { set; get; }
        public DbSet<Day> days { set; get; }
        public DbSet<Lesson> lessons { set; get; }
    }
}
