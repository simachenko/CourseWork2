using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.TimetableDataStorage;
using DataAccessLayer.UsersDataStorage;
using Entities;
using Entities.TimetableEntity;
using DataAccessLayer.NinjectKernel;
using System.Data;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                UoWTimetable uoW = new UoWTimetable();
            Entities.TimetableEntity.Group group = new Group();
            group.name = "pi-1";
            group.weeks = new List<Week>();

            Entities.TimetableEntity.Group group2 = new Group();
            group2.name = "2";
            group2.weeks = new List<Week>();

            Entities.TimetableEntity.Group group3 = new Group();
            group3.name = "3";
            group3.weeks = new List<Week>();

            Entities.TimetableEntity.Group group4 = new Group();
            group4.name = "4";
            group4.weeks = new List<Week>();

            Week week = new Week();
            week.days = new List<Day>();
            week.weekPosition = 2;
            week.group = group;
            week.GroupId = group.GroupId;


            Day day = new Day();
            day.lesson = new List<Lesson>();
            day.week = week;
            day.WeekId = week.WeekId;

            Lesson lesson = new Lesson();
            lesson.discipline = "////";
            lesson.auditory = 3.303;
            lesson.day = day;
            lesson.DayId = day.DayID;
            lesson.teacher = "+++++";

            group.weeks.Add(week);
            week.days.Add(day);
            day.lesson.Add(lesson);



            //uoW.LessonRepository.Create(lesson);
            //uoW.DayRepository.Create(day);
            //uoW.Save();
            //uoW.WeekRepository.Create(week);
            uoW.GroupRepository.Create(group);
            uoW.GroupRepository.Create(group2);
            uoW.GroupRepository.Create(group4);
            uoW.GroupRepository.Create(group);
            uoW.Save();
            //uoW.Save();
            //uoW.GroupRepository.Create(group);
            //Day lesson1 = uoW.DayRepository.Get().Last();
            //Group grp = uoW.GroupRepository.Get().First();
            //uoW.LessonRepository.Update(lesson1);
            // Group read = uoW.GroupRepository.Get(grp.GroupId);
            //uoW.GroupRepository.Remove(read);
            //uoW.DayRepository.Remove(day);
            //u
                //uoW.Save();


                //Group readed = uoW.GroupRepository.Get(group.GroupId);

                //Console.WriteLine(read.teacher);
                //Console.WriteLine(readed.weeks.First().days.First().lesson.First().auditory);


                /*NinjectContext.SeUp(new DataAccessLayer.TimetableDataStorage.NIjectConfig.NinjectConfigTT());
                DbTimetable dbTimetable = NinjectContext.Get<DbTimetable>();*/
                Console.ReadKey();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.ReadKey();
            //}
        }
    }
}
