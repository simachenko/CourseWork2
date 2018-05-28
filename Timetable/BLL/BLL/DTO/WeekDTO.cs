using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class WeekDTO
    {
        public int WeekId { set; get; }
        public int weekPosition { set; get; }
        public ICollection<DayDTO> days { set; get; }
        public int? GroupId { set; get; }
        public GroupDTO group { set; get; }
    }
}
