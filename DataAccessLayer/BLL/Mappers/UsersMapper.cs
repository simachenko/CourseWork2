using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
