using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.TimetableEntity
{
    [Table("Group")]
    public class Group : Entity
    {
        [Key]
        public int GroupId { set; get; }
        public string name { set; get; }
        //[ForeignKey("Week")]
        //public ICollection<Week> weeks { set; get;}
    }
}
