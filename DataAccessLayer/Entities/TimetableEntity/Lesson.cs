using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lesson : Entity
    {
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public int? DayId { set; get; }
        public Day day { set; get; }
    }
}
