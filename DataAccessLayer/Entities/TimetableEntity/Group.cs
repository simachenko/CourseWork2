using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Group : Entity
    {
        public int GroupId { set; get; }
        public string name { set; get; }
        public ICollection<Week> weeks { set; get;}
    }
}
