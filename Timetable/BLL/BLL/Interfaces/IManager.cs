using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IManager
    {
        List<LessonDTO> getLessonsByGroup(string group);
        List<LessonDTO> getLessonsByAuditory(double auditory);
        List<LessonDTO> getLessonsByTeacher(string teacher);
        List<LessonDTO> getLessonsByDiscipline(string discipline);
    }
}
