using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Tkey { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public string Username { get; set; }
        public virtual User User { get; set; }

    }
}
