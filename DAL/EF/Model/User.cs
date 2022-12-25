using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Type { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Farmer Farmer { get; set; }
        public virtual Advisor Advisor { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Service> Services { get; set; }
        public virtual List<Token> Tokens { get; set; }
        public User()
        {
            Orders = new List<Order>();
            Services = new List<Service>();
            Tokens = new List<Token>();
        }

    }
}
