using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface ITeacher
    {
        List<LessonDTO> getAllLessons(string surname);
        LessonDTO getLesson(string dicpline, string surname);
        List<LessonDTO> getLessons(string day, string surname);
    }
}
