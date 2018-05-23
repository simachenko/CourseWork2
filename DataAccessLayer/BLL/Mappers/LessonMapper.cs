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
    class LessonMapper
    {
        public LessonMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Lesson, LessonDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var day = new Lesson();
            var dest = mapper.Map<Lesson, LessonDTO>(day);
        }
    }
}
