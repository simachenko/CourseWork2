using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.WorkWith
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

        public bool removeUser()
        {
            throw new NotImplementedException();
        }
    }
}
