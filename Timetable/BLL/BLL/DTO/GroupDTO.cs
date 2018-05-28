using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class GroupDTO
    {
        public int GroupId { set; get; }
        public string name { set; get; }
        public ICollection<WeekDTO> weeks { set; get; }
    }
}
