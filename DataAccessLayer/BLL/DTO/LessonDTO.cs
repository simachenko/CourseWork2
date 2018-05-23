﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    class LessonDTO
    {
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public int? dayID { set; get; }
        public DayDTO day { set; get; }
    }
}
