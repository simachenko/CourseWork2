﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimetableWebApp.Models.TimetableViewModels
{
    public class LessonViewModel
    {
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public double auditory { set; get; }
        public string group { set; get; }
        public int day { set; get; }

    }
}