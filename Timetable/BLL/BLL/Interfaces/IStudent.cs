using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IStudent
    {
        List<LessonDTO> getAllLessons(int group);
        LessonDTO getLesson(string dicpline, int group);
        List<LessonDTO> getLessons(string day, int group);
        
    }
}
