using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.TimetableEntity; 
using Entities.UsersEntity;
using BLL.DTO;

namespace BLL.Mappers
{
    static class ModelMapper
    {
        public static Group GroupMapper_toEntity(GroupDTO group)
        {
            return Mapper.Map<Group>(group);
        }

        public static Lesson LessonMapper_toEntity(LessonDTO lesson)
        {
            return Mapper.Map<Lesson>(lesson);
        }

        public static User UserMapper_toEntity(UserDTO user)
        {
            return Mapper.Map<User>(user);
        }

        public static ICollection<Group> GroupCollectionMapper_toEntity(ICollection<GroupDTO> groups)
        {
            return Mapper.Map<List<Group>>(groups);
        }

        public static ICollection<Lesson> LessonsCollectionMapper_toEntity(ICollection<LessonDTO> lessons)
        {
            return Mapper.Map<List<Lesson>>(lessons);
        }

        public static ICollection<User> UsersCollectionMapper_toEntity(ICollection<UserDTO> users)
        {
            return Mapper.Map<List<User>>(users);
        }

//----------------------------------------------------------------------------------------------------------------------------------------

        public static GroupDTO GroupMapper_toBLL(Group group)
        {
            return Mapper.Map<GroupDTO>(group);
        }

        public static LessonDTO LessonMapper_toBLL(Lesson lesson)
        {
            return Mapper.Map<LessonDTO>(lesson);
        }

        public static UserDTO UserMapper_toBLL(User user)
        {
            return Mapper.Map<UserDTO>(user);
        }

        public static List<GroupDTO> GroupCollectionMapper_toBLL(ICollection<Group> groups)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg=>cfg.CreateMap<Group,GroupDTO>());
            return Mapper.Map<List<GroupDTO>>(groups);
        }

        public static List<LessonDTO> LessonsCollectionMapper_toBLL(ICollection<Lesson> lessons)
        {
            return Mapper.Map<List<LessonDTO>>(lessons);
            
        }

        public static List<UserDTO> UsersCollectionMapper_toBLL(ICollection<User> users)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
            return Mapper.Map<List<UserDTO>>(users);
        }

    }
}
