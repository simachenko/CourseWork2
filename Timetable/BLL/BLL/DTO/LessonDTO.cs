﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class LessonDTO
    {
                public int LessonId { set; get; }
                public string discipline { set; get; }
                public string teacher { set; get; }
                public double auditory { set; get; }
                public string group { set; get; }
                public int day { set; get; }
    }
}
