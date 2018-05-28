using AutoMapper;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.UsersEntity;

namespace BLL.Mappers
{
    class UsersMapper
    {
        public UsersMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Users, UsersDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var users = new Users();
            var dest = mapper.Map<Users, UsersDTO>(users);
        }
    }
}
