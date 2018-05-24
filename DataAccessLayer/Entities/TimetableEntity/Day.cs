using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TimetableEntity
{
    [Table("Lessons")]
    public class Day : Entity
    {
        [Key]
        public int DayID { set; get; }
        public string name { set; get; }
        public int groupeID { set; get; }
        public Group groupe { set; get; }
        public ICollection<Lesson> lesson { set; get; }
        
    }
}
