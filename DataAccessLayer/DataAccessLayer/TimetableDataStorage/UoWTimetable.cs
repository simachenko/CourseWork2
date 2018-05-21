﻿using System;
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


namespace DataAccessLayer.TimetableDataStorage
{
    public class UoWTimetable :IDisposable
    {
        private DbTimetable db;
        private IRepository<Lesson> lessonRepository;
        private IRepository<Day> dayRepository;
        private IRepository<Week> weekRepository;
        private IRepository<Group> groupRepository;
        //private StandardKernel standardKernel;
        private bool disposedValue = false; // Для определения избыточных вызовов

        public UoWTimetable()
        {
            //standardKernel = new StandardKernel(new NinjectConfig());
            NinjectContext.SeUp(new NinjectConfigTT());
            db = NinjectContext.Get<DbTimetable>();
        }

        public IRepository<Lesson> LessonRepository
        {
            get
            {
                if (lessonRepository == null)
                {

                    lessonRepository = NinjectContext.Get<IRepository<Lesson>>();
                }
                return lessonRepository;
            }      
        }

        public IRepository<Day> DayRepository
        {
            get
            {
                if (dayRepository == null)
                    dayRepository = NinjectContext.Get<IRepository<Day>>(); ;
                return dayRepository;
            }
        }
        public IRepository<Week> WeekRepository
        {
            get
            {
                if (weekRepository == null)
                    weekRepository = NinjectContext.Get<IRepository<Week>>(); ;
                return weekRepository;
            }
        }
        public IRepository<Group> GroupRepository
        {
            get
            {
                if (GroupRepository == null)
                    groupRepository = NinjectContext.Get<IRepository<Group>>(); ;
                return groupRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    db.Dispose();
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
