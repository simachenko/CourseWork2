using BLL.Interfaces;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.User
{
    class Manager : User, IManager
    {
        public override string userKey
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<UsersDTO> getAllLessons()
        {
            throw new NotImplementedException();
        }

        public List<UsersDTO> getAuditoryLessons(double auditory)
        {
            throw new NotImplementedException();
        }

        public List<UsersDTO> getGroupLessons(int group)
        {
            throw new NotImplementedException();
        }

        public List<UsersDTO> getTeacherLessons(string surname)
        {
            throw new NotImplementedException();
        }
    }
}
