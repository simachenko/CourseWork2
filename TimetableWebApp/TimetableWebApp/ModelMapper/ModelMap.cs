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
            groupViewModel = Mapper.Map<GroupViewModel>(groupDTO);
            return groupViewModel;
        }
        public static LessonViewModel LessonDomainToView(LessonDTO lessonDTO)
        {
            
            return Mapper.Map<LessonViewModel>(lessonDTO);
        }
        public static LessonDTO LessonViewToDomain(LessonViewModel lessonViewModel)
        {
           
            return Mapper.Map<LessonDTO>(lessonViewModel);
        }
        public static GroupDTO GroupViewToDomain(GroupViewModel groupViewModel)
        {
            return Mapper.Map<GroupDTO>(groupViewModel);
        }
        public static IEnumerable<GroupViewModel> GroupDomainToView(IEnumerable<GroupDTO> groupDTO)
        {
            return Mapper.Map<List<GroupViewModel>>(groupDTO);
        }
        public static IEnumerable<LessonViewModel> LessonDomainToView(IEnumerable<LessonDTO> lessonDTO)
        {
            return Mapper.Map<List<LessonViewModel>>(lessonDTO);
        }
        public static void Reset()
        {
            Mapper.Reset();
        }
        //private static UserViewModel UserDomainToView()

    }
}