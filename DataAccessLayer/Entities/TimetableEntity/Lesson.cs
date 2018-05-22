using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TimetableEntity
{
    public class Lesson : Entity
    {
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public double auditory { set; get; }
        public int? DayId { set; get; }
        public Day day { set; get; }
    }
}
