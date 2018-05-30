using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserDTO
    {
        public int UserId { set; get; }
        public string name { set; get; }
        public string key { set; get; }
        public string surname { set; get; }
        public string nickname { set; get; }
        public string password { set; get; }

        public UserDTO(string name, string surname, string key, string nickname, string password)
        {
            this.name = name;
            this.surname = surname;
            this.key = key;
            this.nickname = nickname;
            this.password = password;
        }
    }
}
