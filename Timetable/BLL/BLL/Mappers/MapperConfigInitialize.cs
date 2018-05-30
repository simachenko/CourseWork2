using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using Entities.TimetableEntity;
using Entities.UsersEntity;
namespace BLL.Mappers
{
    public static class MapperConfigInitialize
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<GroupDTO, Group>();
                cfg.CreateMap<LessonDTO, Lesson>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<Group, GroupDTO>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Lesson, LessonDTO>();

            });
        }

        public static IMapperConfigurationExpression GetMapperConfiguration(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<GroupDTO, Group>();
            cfg.CreateMap<LessonDTO, Lesson>();
            cfg.CreateMap<UserDTO, User>();
            cfg.CreateMap<Group, GroupDTO>();
            cfg.CreateMap<User, UserDTO>();
            cfg.CreateMap<Lesson, LessonDTO>();

            return cfg;
        }
    }
}
