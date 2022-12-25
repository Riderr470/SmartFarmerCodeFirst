using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TKey { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime? ExpireTime { get; set; }
        public string Username { get; set; }
    }
}
