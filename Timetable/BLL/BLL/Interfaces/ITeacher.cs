﻿using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface ITeacher
    {
        List<LessonDTO> getLessonsByTeacher(string teacher);
        List<LessonDTO> getLessonsByGroup(string group);
    }
}
