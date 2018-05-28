using AutoMapper;
using BLL.DTO;
using Entities.TimetableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    class GroupMapper
    {
        public GroupMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Group, GroupDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var group = new Group();
            var dest = mapper.Map<Group, GroupDTO>(group);
        }
    }
}
