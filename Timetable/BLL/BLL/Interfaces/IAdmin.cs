using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Interfaces
{
    interface IAdmin
    {
        bool addNewUser();
        bool removeUser(string surname);
        List<UserDTO> getAllUsers();
        UserDTO getUser(string surname);

    }
}
