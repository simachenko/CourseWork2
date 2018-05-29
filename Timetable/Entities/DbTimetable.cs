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
            /*DropCreateDatabaseIfModelChanges<DbTimetable> create = new DropCreateDatabaseIfModelChanges<DbTimetable>();
            create.InitializeDatabase(this);*/
            //Database.ExecuteSqlCommand("ALTER TABLE dbo.weeks ADD CONSTRAINT Players_Teams FOREIGN KEY (TeamId) REFERENCES dbo.Teams (Id) ON DELETE SET NULL");
        }

        
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Group>().
        //        HasMany(p => p.weeks).
        //        WithOptional(p => p.group).
        //        WillCascadeOnDelete(true);


        //    modelBuilder.Entity<Week>().
        //        HasMany(p => p.days).
        //        WithOptional(p => p.week).
        //        WillCascadeOnDelete(true);

        //    modelBuilder.Entity<Day>().
        //        HasMany(p => p.lesson).
        //        WithOptional(p => p.day).
        //        WillCascadeOnDelete(true);

        //    //Database.ExecuteSqlCommand("ALTER TABLE dbo.weeks ADD CONSTRAINT Players_Teams FOREIGN KEY (TeamId) REFERENCES dbo.Teams (Id) ON DELETE SET NULL");
        //}

        public DbSet<Group> Groups { set; get; }
        //public DbSet<Week> Weeks { set; get; }
        //public DbSet<Day> Days { set; get; }
        public DbSet<Lesson> Lessons { set; get; }
    }
}
