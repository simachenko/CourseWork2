using AutoMapper;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    class WeekMapper
    {
        public WeekMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Week, WeekDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var day = new Week();
            var dest = mapper.Map<Week, WeekDTO>(day);
        }
    }
}
