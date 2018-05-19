using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Week : Entity
    {
        public int WeekId { set; get; }
        public int weekPosition { set; get; }
        public ICollection<Day> days { set; get; }
        public int GroupId { set; get; }
        public Group group { set; get; }
    }
}
