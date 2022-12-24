using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }        
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
    }
}
