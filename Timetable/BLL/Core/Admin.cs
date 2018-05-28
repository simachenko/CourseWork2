using BLL.DTO;
using BLL.Interfaces;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Core
{
    class Admin : User, IAdmin
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

        public bool addNewUser()
        {
            throw new NotImplementedException();
        }

        public List<UsersDTO> getAllUsers()
        {
            throw new NotImplementedException();
        }

        public UsersDTO getUser(string surname)
        {
            throw new NotImplementedException();
        }

        public bool removeUser(string surname)
        {
            throw new NotImplementedException();
        }
    }
}
