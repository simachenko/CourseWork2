using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessLayer.TimetableDataStorage.Repos;
using Entities;
using DataAccessLayer.NinjectKernel;
using DataAccessLayer.TimetableDataStorage.NIjectConfig;
using Ninject.Modules;
using Ninject;
using Entities.TimetableEntity;

namespace DataAccessLayer.TimetableDataStorage
{
    public class UoWTimetable :IDisposable
    {
        
        private IRepository<Lesson> lessonRepository ;
        private IRepository<Day> dayRepository ; 
        private IRepository<Week> weekRepository;
        private IRepository<Group> groupRepository ;
        //private StandardKernel standardKernel;
        private bool disposedValue = false; // Для определения избыточных вызовов

        public UoWTimetable()
        {
            //standardKernel = new StandardKernel(new NinjectConfig());
            NinjectContext.SeUp(new NinjectConfigTT());
            lessonRepository = NinjectContext.Get<IRepository<Lesson>>();
            dayRepository = NinjectContext.Get<IRepository<Day>>();
            weekRepository = NinjectContext.Get<IRepository<Week>>();
            groupRepository = NinjectContext.Get<IRepository<Group>>();
        }

        public IRepository<Lesson> LessonRepository
        {
            get
            {
                return lessonRepository;
            }      
        }

        public IRepository<Day> DayRepository
        {
            get
            {
                return dayRepository;
            }
        }
        public IRepository<Week> WeekRepository
        {
            get
            {
                return weekRepository;
            }
        }
        public IRepository<Group> GroupRepository
        {
            get
            {
                return groupRepository;
            }
        }

        public void Save()
        {
            groupRepository.SaveChanges();
            weekRepository.SaveChanges();
            dayRepository.SaveChanges();
            lessonRepository.SaveChanges();
        }


        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    lessonRepository.Dispose();
                    dayRepository.Dispose();
                    weekRepository.Dispose();
                    groupRepository.Dispose();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UoWTimetable() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
