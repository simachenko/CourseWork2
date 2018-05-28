using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimetableWebApp.Models.TimetableViewModels
{
    public class WeekViewModel
    {
        public int WeekId { set; get; }
        public int weekPosition { set; get; }
        public ICollection<DayViewModel> days { set; get; }
        public int? GroupId { set; get; }
        public GroupViewModel group { set; get; }
    }
}