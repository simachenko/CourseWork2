using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UsersEntity
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { set; get;}
        [Required]
        [ForeignKey("Key")]
        public string Key { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public string password { set; get; }

    }
}
