using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DataAccessLayer.UsersDataStorage;

namespace BLL.Core
{
    public class CoreUser
    {
        List<UserDTO> users;

        UoWUsers us = new UoWUsers();

        public CoreUser()
        {
            if (us.userRepository.Get() == null)
                users = new List<UserDTO>();
            else users = Mappers.ModelMapper.UsersCollectionMapper_toBLL(us.userRepository.Get());
        }

        public void CreateUser(UserDTO user)
        {
            users.Add(user);
            us.userRepository.Create(Mappers.ModelMapper.UserMapper_toEntity(user));
            us.Save();
        }

        public void DeleteUser(int id)
        {
            UserDTO delete = users.Where(p => p.UserId == id).First();
            users.Remove(delete);
            us.userRepository.Remove(Mappers.ModelMapper.UserMapper_toEntity(delete));
            us.Save();
        }

        public bool Authorization(string login, string password)
        {
            bool flag = false;
            foreach(UserDTO u in users)
            {
                if (u.nickname == login && u.password == password)
                    return true;
                else return false;
            }
            return flag;
        }

    }
}
