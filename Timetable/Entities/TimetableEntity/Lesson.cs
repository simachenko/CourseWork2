using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.TimetableEntity
{
    [Table("Lesson")]
    public class Lesson : Entity
    {
        [Key]
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public double auditory { set; get; }
        //[ForeignKey("Day")]
        public int? DayId { set; get; }
        public Day day { set; get; }
    }
}
