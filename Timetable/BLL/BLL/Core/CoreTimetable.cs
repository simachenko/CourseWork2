using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.TimetableDataStorage;
using BLL.DTO;

namespace BLL.Core
{
    public class CoreTimetable
    {
        List<GroupDTO> groups;
        List<LessonDTO> lessons;

        UoWTimetable tt = new UoWTimetable();
        
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

        public void DeleteGroup(string name)
        {
            GroupDTO delete = groups.Where(p => p.name == name).First();
            groups.Remove(delete);
            tt.GroupRepository.Remove(Mappers.ModelMapper.GroupMapper_toEntity(delete));
            tt.Save();
        }

        public void CreateLesson(LessonDTO lesson)
        {
            lessons.Add(lesson);
            tt.LessonRepository.Create(Mappers.ModelMapper.LessonMapper_toEntity(lesson));
            tt.Save();
        }



    }
}
