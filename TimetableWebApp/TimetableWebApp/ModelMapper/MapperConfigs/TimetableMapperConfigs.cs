using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Configuration;
using AutoMapper;
using BLL.DTO;
using TimetableWebApp.Models.TimetableViewModels;

namespace TimetableWebApp.ModelMapper.MapperConfigs
{
    public class TimetableMapperConfigs : MapperConfigurationExpression
    {
        public TimetableMapperConfigs()
        {

            CreateMap<GroupDTO, GroupViewModel>();
            CreateMap<>
        }
        
    }
}