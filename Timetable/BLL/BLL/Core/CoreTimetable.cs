using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.TimetableDataStorage;
using BLL.DTO;

namespace BLL.Core
{
    class CoreTimetable
    {
        private List<GroupDTO> groups;
        private List<LessonDTO> lessons;

        private UoWTimetable tt = new UoWTimetable();
        
        public CoreTimetable()
        {
            if (tt.GroupRepository.Get() == null)
                groups = new List<GroupDTO>();
            else groups = Mappers.ModelMapper.GroupCollectionMapper_toBLL(tt.GroupRepository.Get());

            if (tt.LessonRepository.Get() == null)
                lessons = new List<LessonDTO>();
            else lessons = Mappers.ModelMapper.LessonsCollectionMapper_toBLL(tt.LessonRepository.Get());
        }

        public void CreateGroup(GroupDTO group)
        {
            groups.Add(group);
            tt.GroupRepository.Create(Mappers.ModelMapper.GroupMapper_toEntity(group));
            tt.Save();
        }

        public bool DeleteGroup(string name)
        {
            GroupDTO delete = groups.Where(p => p.name == name).First();
            if (delete == null)
                return false;
            groups.Remove(delete);
            tt.GroupRepository.Remove(Mappers.ModelMapper.GroupMapper_toEntity(delete));
            tt.Save();
            return true;
        }

        public void CreateLesson(LessonDTO lesson)
        {
            lessons.Add(lesson);
            tt.LessonRepository.Create(Mappers.ModelMapper.LessonMapper_toEntity(lesson));
            tt.Save();
        }

        public bool DeleteLesson(int id)
        {
            LessonDTO delete = lessons.Where(p => p.LessonId == id).First();
            if (delete == null)
                return false;
            lessons.Remove(delete);
            tt.LessonRepository.Remove(Mappers.ModelMapper.LessonMapper_toEntity(delete));
            tt.Save();
            return true;
        }

        public List<LessonDTO> GetLessonByGroup(string group)
        {
            return new List<LessonDTO>(lessons.Where(p => p.group == group));
        }

        public List<LessonDTO> GetLessonByTeacher(string teacher)
        {
            return new List<LessonDTO>(lessons.Where(p => p.teacher == teacher));
        }

        public List<LessonDTO> GetLessonByAuditory(double auditory)
        {
            return new List<LessonDTO>(lessons.Where(p => p.auditory == auditory));
        }

        public List<LessonDTO> GetLessonByDiscipline(string discipline)
        {
            return new List<LessonDTO>(lessons.Where(p => p.discipline == discipline));
        }

        public LessonDTO getLesson(int id)
        {
            return lessons.Find(p => p.LessonId == id);
        }

        public List<GroupDTO> getGroups()
        {
            return groups;
        }

        public GroupDTO getGroup(string group)
        {
            return groups.Find(p => p.name == group);
        }

    }
}
