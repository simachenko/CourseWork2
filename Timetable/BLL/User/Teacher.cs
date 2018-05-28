using BLL.Interfaces;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.User
{
    class Teacher : User, ITeacher
    {
        public override string userKey
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<LessonDTO> getAllLessons(string surname)
        {
            throw new NotImplementedException();
        }

        public LessonDTO getLesson(string dicpline, string surname)
        {
            throw new NotImplementedException();
        }

        public List<LessonDTO> getLessons(string day, string surname)
        {
            throw new NotImplementedException();
        }
    }
}
