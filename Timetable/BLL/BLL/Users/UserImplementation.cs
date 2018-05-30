using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Core;
using DataAccessLayer.NinjectKernel;
namespace BLL.Users
{
    public class UserImplementation : IAdmin, IEditor, IManager, IStudent, ITeacher
    {
        CoreTimetable ct;
        CoreUser cu;

        public UserImplementation()
        {
            Mappers.MapperConfigInitialize.Initialize();
            NinjectContext.SeUp(new NinjectConfig.NinjectConfigurations());
            ct = NinjectContext.Get<CoreTimetable>();
            cu = NinjectContext.Get<CoreUser>();
        }
        public bool addNewUser(DTO.UserDTO user)
        {

            return cu.CreateUser(user);
        }

        public bool removeUser(int id)
        {
            return cu.DeleteUser(id);
        }

        public List<DTO.UserDTO> getAllUsers()
        {
            return cu.GetAllUser();
        }

        public DTO.UserDTO getUser(string surname)
        {
            return cu.GetUser(surname);
        }

        public void addNewGroup(DTO.GroupDTO group)
        {
            ct.CreateGroup(group);
        }

        public bool removeGroup(string group)
        {
            return ct.DeleteGroup(group);
        }

        public void addNewLesson(DTO.LessonDTO lesson)
        {
            ct.CreateLesson(lesson);
        }

        public bool removeLesson(int id)
        {
            return ct.DeleteLesson(id);
        }

        public List<DTO.LessonDTO> getLessonsAll(string group)
        {
            return ct.GetLessonByGroup(group);
        }

        public DTO.LessonDTO getLesson(int id)
        {
            return ct.getLesson(id);
        }

        public List<DTO.GroupDTO> getAllGroups()
        {
            return ct.getGroups();
        }

        public DTO.GroupDTO getGroup(string group)
        {
            return ct.getGroup(group);
        }

        public List<DTO.LessonDTO> getLessonsByGroup(string group)
        {
            return ct.GetLessonByGroup(group);
        }

        public List<DTO.LessonDTO> getLessonsByAuditory(double auditory)
        {
            return ct.GetLessonByAuditory(auditory);
        }

        public List<DTO.LessonDTO> getLessonsByTeacher(string teacher)
        {
            return ct.GetLessonByTeacher(teacher);
        }

        public List<DTO.LessonDTO> getLessonsByDiscipline(string discipline)
        {
            return ct.GetLessonByDiscipline(discipline);
        }

        public List<DTO.LessonDTO> getAllLessons(string group)
        {
            return ct.GetLessonByGroup(group);
        }

        List<DTO.LessonDTO> ITeacher.getLessonsByTeacher(string teacher)
        {
            return ct.GetLessonByTeacher(teacher);
        }

        List<DTO.LessonDTO> ITeacher.getLessonsByGroup(string group)
        {
            return ct.GetLessonByGroup(group);
        }

    }
}
