using AutoMapper;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.TimetableEntity;

namespace BLL.Mappers
{
    class DayMapper {
        public DayMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Day, DayDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var day = new Day();
            var dest = mapper.Map<Day, DayDTO>(day);
        }
    }
}
