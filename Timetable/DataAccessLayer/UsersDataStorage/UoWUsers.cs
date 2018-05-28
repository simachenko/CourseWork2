using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.UsersEntity;
using DataAccessLayer.UsersDataStorage.Repository;
namespace DataAccessLayer.UsersDataStorage
{
    public class UoWUsers :IDisposable
    {


        private DbUsers dbUsers;
        private IRepository<User> userRepositiry;
        public UoWUsers()
        {
            NinjectKernel.NinjectContext.SeUp(new NInjectConfigs.NInjectCofigUser());
            dbUsers = NinjectKernel.NinjectContext.Get<DbUsers>();
        }
        public IRepository<User> userRepository
        {
            private set { }
            get
            {
                if (userRepositiry == null)
                {
                    userRepositiry = NinjectKernel.NinjectContext.Get<IRepository<User>>();
                }
                return this.userRepositiry;
            }
        }
        
        public void Save()
        {
            dbUsers.SaveChanges();
        }
        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    dbUsers.Dispose();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UoWUsers() {
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
