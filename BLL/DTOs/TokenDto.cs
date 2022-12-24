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
        public string TKey { get; set; }
        public System.DateTime CreatTime { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public string Username { get; set; }
    }
}
