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
        bool addNewUser(UserDTO user);
        bool removeUser(int id);
        List<UserDTO> getAllUsers();
        UserDTO getUser(string surname);

    }
}
