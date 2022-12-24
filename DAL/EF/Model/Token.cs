using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Token
    {
        public int Id { get; set; }
        public string Tkey { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public string Username { get; set; }

    }
}
