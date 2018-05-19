using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
namespace DataAccessLayer
{
    public class DbTimetable : DbContext
    {
        public DbTimetable(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbTimetable()
        {
        }

        public DbSet<Group> groups { set; get; }
        public DbSet<Week> weeks { set; get; }
        public DbSet<Day> days { set; get; }
        public DbSet<Lesson> lessons { set; get; }
    }
}
