using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DayDTO
    {
        public int DayID { set; get; }
        public string name { set; get; }
        public int? WeekId { set; get; }
        public WeekDTO week { set; get; }
        public ICollection<LessonDTO> lesons { set; get; }
    }
}
