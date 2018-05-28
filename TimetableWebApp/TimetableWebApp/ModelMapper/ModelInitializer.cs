using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.DTO;
using TimetableWebApp.Models.TimetableViewModels;
using TimetableWebApp.ModelMapper.MapperConfigs;
namespace TimetableWebApp.ModelMapper
{
    public static class ModelInitializer
    {
        private static GroupViewModel InitializeForGroup(GroupDTO groupDTO)
        {
            GroupViewModel groupViewModel = new GroupViewModel();

            Mapper.Initialize(config => config.CreateMap<GroupDTO, GroupViewModel>());
            groupViewModel = Mapper.Map<GroupViewModel>(groupDTO);

            Mapper.Initialize(config => config.CreateMap<ICollection<WeekDTO>, ICollection<WeekViewModel>>());
            groupViewModel.weeks = Mapper.Map<ICollection<WeekViewModel>>(groupDTO.wks)
        }

    }
}