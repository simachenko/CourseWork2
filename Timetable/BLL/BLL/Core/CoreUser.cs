using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DataAccessLayer.UsersDataStorage;

namespace BLL.Core
{
    class CoreUser
    {
        List<UserDTO> users;

        UoWUsers us = new UoWUsers();

        public CoreUser()
        {
            if (us.userRepository.Get() == null)
                users = new List<UserDTO>();
            else users = Mappers.ModelMapper.UsersCollectionMapper_toBLL(us.userRepository.Get());
        }

        public bool CreateUser(UserDTO user)
        {
            foreach (UserDTO u in users)
            {
                if (u.nickname == user.nickname)
                    return false;
            }
            users.Add(user);
            us.userRepository.Create(Mappers.ModelMapper.UserMapper_toEntity(user));
            us.Save();
            return true;
        }

        public bool DeleteUser(int id)
        {
            UserDTO delete = users.Where(p => p.UserId == id).First();
            if (delete == null)
                return false;
            users.Remove(delete);
            us.userRepository.Remove(Mappers.ModelMapper.UserMapper_toEntity(delete));
            us.Save();
            return true;
        }

        public UserDTO Authorization(string login, string password)
        {
            foreach(UserDTO u in users)
            {
                if (u.nickname == login && u.password == password)
                    return u;
                else
                    return null;
            }
            return null;
        }

        public UserDTO GetUser(int id)
        {
            return users.Find(p => p.UserId == id);
        }

        public UserDTO GetUser(string surname)
        {
            return users.Find(p => p.surname == surname);
        }

        public List<UserDTO> GetAllUser()
        {
            return users;
        }



    }
}
