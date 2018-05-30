using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEditor
    {
        void addNewGroup(GroupDTO group);
        bool removeGroup(string group);
        void addNewLesson(LessonDTO lesson);
        bool removeLesson(int id);
        List<LessonDTO> getAllLessons(string group);
        LessonDTO getLesson(int id);
        List<GroupDTO> getAllGroups();
        GroupDTO getGroup(string group);
    }
}
