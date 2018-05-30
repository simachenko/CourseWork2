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
            Mapper.Initialize(cfg => cfg.CreateMap<GroupDTO, Group>());
            return Mapper.Map<Group>(group);
        }

        public static Lesson LessonMapper_toEntity(LessonDTO lesson)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LessonDTO, Lesson>());
            return Mapper.Map<Lesson>(lesson);
        }

        public static User UserMapper_toEntity(UserDTO user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GroupDTO, User>());
            return Mapper.Map<User>(user);
        }

        public static ICollection<Group> GroupCollectionMapper_toEntity(ICollection<GroupDTO> groups)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GroupDTO, Group>());
            return Mapper.Map<List<Group>>(groups);
        }

        public static ICollection<Lesson> LessonsCollectionMapper_toEntity(ICollection<LessonDTO> lessons)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LessonDTO, Lesson>());
            return Mapper.Map<List<Lesson>>(lessons);
        }

        public static ICollection<User> UsersCollectionMapper_toEntity(ICollection<UserDTO> users)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserDTO, User>());
            return Mapper.Map<List<User>>(users);
        }

//----------------------------------------------------------------------------------------------------------------------------------------

        public static GroupDTO GroupMapper_toBLL(Group group)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Group, GroupDTO>());
            return Mapper.Map<GroupDTO>(group);
        }

        public static LessonDTO LessonMapper_toBLL(Lesson lesson)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Lesson, LessonDTO>());
            return Mapper.Map<LessonDTO>(lesson);
        }

        public static UserDTO UserMapper_toBLL(User user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
            return Mapper.Map<UserDTO>(user);
        }

        public static List<GroupDTO> GroupCollectionMapper_toBLL(ICollection<Group> groups)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Group, GroupDTO>());
            return Mapper.Map<List<GroupDTO>>(groups);
        }

        public static List<LessonDTO> LessonsCollectionMapper_toBLL(ICollection<Lesson> lessons)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Lesson, LessonDTO>());
            return Mapper.Map<List<LessonDTO>>(lessons);
        }

        public static List<UserDTO> UsersCollectionMapper_toBLL(ICollection<User> users)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
            return Mapper.Map<List<UserDTO>>(users);
        }

    }
}
