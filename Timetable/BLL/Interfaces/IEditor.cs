using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IEditor
    {
        bool addNewLesson();
        bool removeLesson(string dicpline);
        List<LessonDTO> getAllLessons();
        LessonDTO getLesson(string dicpline);
    }
}
