using DataAccessLayer.TimetableDataStorage.Repos;
using Entities.UsersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UsersDataStorage
{
    class UoWUsers : IDisposable
    {
        private IRepository<User> dayRepository;       

        private bool disposedValue = false; // Для определения избыточных вызовов

        public IRepository<User> UserRepository
        {
            get
            {
                if (lessonRepository == null)
                {
                    lessonRepository = new LessonRepository(db);
                }
                return lessonRepository;
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
