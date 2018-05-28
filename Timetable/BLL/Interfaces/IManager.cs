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
        List<UsersDTO> getAllLessons();
        List<UsersDTO> getAuditoryLessons(double auditory);
        List<UsersDTO> getTeacherLessons(string surname);
        List<UsersDTO> getGroupLessons(int group);
    }
}
