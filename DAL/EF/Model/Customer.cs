using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Customer
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; }
    }
}
