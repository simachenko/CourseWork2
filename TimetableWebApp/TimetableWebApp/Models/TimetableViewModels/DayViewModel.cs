using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimetableWebApp.Models.TimetableViewModels
{
    public class DayViewModel
    {
        public int DayID { set; get; }
        public string name { set; get; }
        public int? WeekId { set; get; }
        public WeekViewModel week { set; get; }
        public ICollection<LessonViewModel> lesson { set; get; }
    }
}