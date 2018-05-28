using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TimetableEntity
{
    [Table("Day")]
    public class Day : Entity
    {
        [Key]
        public int DayID { set; get; }
        public string name { set; get; }
        //[ForeignKey("Groupe")]
        public int? WeekId { set; get; }
        public Week week { set; get; }
        //[ForeignKey("Lessons")]
        public ICollection<Lesson> lesson { set; get; }
        
    }
}
