using AutoMapper;
using BLL.DTO;
using Entities.UsersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    class UserMapper
    {
        public UserMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var users = new User();
            var dest = mapper.Map<User, UserDTO>(users);
        }
    }
}
