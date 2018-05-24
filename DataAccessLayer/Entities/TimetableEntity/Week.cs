using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.TimetableEntity
{
    [Table("Week")]
    public class Week : Entity
    {
        [Key]
        public int WeekId { set; get; }
        public int weekPosition { set; get; }
        //[ForeignKey("Day")]
        public ICollection<Day> days { set; get; }
        //[ForeignKey("Group")]
        public int? GroupId { set; get; }
        public Group group { set; get; }
    }
}
