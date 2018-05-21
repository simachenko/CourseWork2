using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Lessons")]
    public class Lesson : Entity
    {
        [Key]
        public int LessonId { set; get; }
        public string discipline { set; get; }
        public string teacher { set; get; }
        public Day day { set; get; }


    }
}
