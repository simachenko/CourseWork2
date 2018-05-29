using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IManager
    {
        List<UserDTO> getAllLessons();
        List<UserDTO> getAuditoryLessons(double auditory);
        List<UserDTO> getTeacherLessons(string surname);
        List<UserDTO> getGroupLessons(int group);
    }
}
