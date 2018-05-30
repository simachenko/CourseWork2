using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.DTO;
using TimetableWebApp.Models.TimetableViewModels;
namespace TimetableWebApp.ModelMapper
{
    public static class ModelMap
    {
        public static GroupViewModel GroupDomainToView(GroupDTO groupDTO)
        {
            GroupViewModel groupViewModel = new GroupViewModel();
            Mapper.Initialize(config => config.CreateMap<GroupDTO, GroupViewModel>());
            groupViewModel = Mapper.Map<GroupViewModel>(groupDTO);
            return groupViewModel;
        }
        public static LessonViewModel LessonDomainToView(LessonDTO lessonDTO)
        {
            Mapper.Initialize(config => config.CreateMap<LessonDTO, LessonViewModel>());
            return Mapper.Map<LessonViewModel>(lessonDTO);
        }
        public static LessonDTO LessonViewToDomain(LessonViewModel lessonViewModel)
        {
            Mapper.Initialize(config => config.CreateMap<LessonViewModel, LessonDTO>());
            return Mapper.Map<LessonDTO>(lessonViewModel);
        }
        public static GroupDTO GroupViewToDomain(GroupViewModel groupViewModel)
        {
            Mapper.Initialize(config => config.CreateMap<GroupViewModel, GroupDTO>());
            return Mapper.Map<GroupDTO>(groupViewModel);
        }
        public static IEnumerable<GroupViewModel> GroupDomainToView(IEnumerable<GroupDTO> groupDTO)
        {
            Mapper.Initialize(config => config.CreateMap<GroupDTO, GroupViewModel>());
            return Mapper.Map<List<GroupViewModel>>(groupDTO);
        }
        public static IEnumerable<LessonViewModel> LessonDomainToView(IEnumerable<LessonDTO> lessonDTO)
        {
            Mapper.Initialize(config => config.CreateMap<LessonDTO, LessonViewModel>());
            return Mapper.Map<List<LessonViewModel>>(lessonDTO);
        }
        //private static UserViewModel UserDomainToView()

    }
}