using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CommentText { get; set; }
        public DateTime date { get; set; }
    }
}
