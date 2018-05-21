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
    public class Group : Entity
    {
        [Key]
        public int GroupId { set; get; }
        [Required]
        [ForeignKey("Key")]
        public int name { set; get; }
       
    }
}
