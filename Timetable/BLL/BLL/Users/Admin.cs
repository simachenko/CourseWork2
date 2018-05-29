using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Users
{
    public class Admin : BLL.DTO.UserDTO
    {
        public Admin(string name, string surname, string key, string nickname, string password)
            : base(name, surname, key, nickname, password)
        {

        }

    }
}
