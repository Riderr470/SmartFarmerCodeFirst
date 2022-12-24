using AutoMapper;
using BLL.DTOs;
using DAL.EF.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDto Authenticate(string uname, string pass)
        {
            var rs = DataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
            if (rs)
            {
                var tk = new Token();
                tk.Username = uname;
                tk.CreateTime = DateTime.Now;
                tk.ExpireTime = null;
                tk.Tkey = Guid.NewGuid().ToString();
                var rt = DataAccessFactory.TokenAccess().Add(tk);
                if (rt != null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Token, TokenDto>();
                    });
                    var mapper = new Mapper(config);
                    var data = mapper.Map<TokenDto>(rt);
                    return data;
                }
            }
            return null;
        }
        public static bool IsTokenValid(string token)
        {
            var tk = DataAccessFactory.TokenAccess().Get(token);
            if (tk != null && tk.ExpireTime == null)
            {
                return true;
            }
            return false;

        }
    }
}
