using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    class DayDTO
    {
        public int DayID { set; get; }
        public string name { set; get; }
        public int groupeID { set; get; }
        public GroupDTO groupe { set; get; }
        public ICollection<LessonDTO> lesson { set; get; }
    }
}
