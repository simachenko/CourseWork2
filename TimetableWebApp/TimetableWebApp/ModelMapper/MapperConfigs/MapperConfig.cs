using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.DTO;
using TimetableWebApp.Models.TimetableViewModels;
namespace TimetableWebApp.ModelMapper.MapperConfigs
{
    public static class MapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config = BLL.MappConfig.GetMapperConfiguration(config);
                config.CreateMap<GroupDTO, GroupViewModel>();
                config.CreateMap<LessonDTO, LessonViewModel>();
                config.CreateMap<LessonViewModel, LessonDTO>();
                config.CreateMap<GroupViewModel, GroupDTO>();

            });
        }

        public static IMapperConfigurationExpression GetMapperConfiguration(IMapperConfigurationExpression config)
        {
            config.CreateMap<LessonDTO, LessonViewModel>();
            config.CreateMap<LessonViewModel, LessonDTO>();
            config.CreateMap<GroupViewModel, GroupDTO>();
            config.CreateMap<GroupDTO, GroupViewModel>();

            return config;
        }
    }
}