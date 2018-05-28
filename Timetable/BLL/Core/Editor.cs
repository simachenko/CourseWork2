using BLL.Interfaces;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Core
{
    class Editor : User, IEditor
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

        public bool addNewLesson()
        {
            throw new NotImplementedException();
        }

        public List<LessonDTO> getAllLessons()
        {
            throw new NotImplementedException();
        }

        public LessonDTO getLesson(string dicpline)
        {
            throw new NotImplementedException();
        }

        public bool removeLesson(string dicpline)
        {
            throw new NotImplementedException();
        }
    }
}
