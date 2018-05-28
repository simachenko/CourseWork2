using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DayDTO
    {
<<<<<<< HEAD

=======
        public int DayID { set; get; }
        public string name { set; get; }
        public int? WeekId { set; get; }
        public WeekDTO week { set; get; }
        public ICollection<LessonDTO> lesons { set; get; }
>>>>>>> a404ab01ff780ace9e68cb724b94cf163f07d3fa
    }
}
