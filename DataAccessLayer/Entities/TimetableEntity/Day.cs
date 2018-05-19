using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Day : Entity
    {
        public int DayID { set; get; }
        public ICollection<Lesson> lesson { set; get; }
        public int? WeekId { set; get; }
        public Week week { set; get; }
    }
}
