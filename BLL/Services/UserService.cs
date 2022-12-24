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
    public class UserService
    {
        public static UserDto AddCustomer(UserDto user)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDto, User>();
                c.CreateMap<User, UserDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<User>(user);
            var rt = DataAccessFactory.UserAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<UserDto>(rt);
            }
            return null;
        }
        public static List<UserDto> Get()
        {
            var data = DataAccessFactory.UserAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<UserDto>>(data);
        }
        public static UserDto Get(int id)
        {
            var data = DataAccessFactory.UserAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<UserDto>(data);
        }
        public static UserDto Delete(int id)
        {
            var rt = DataAccessFactory.UserAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<User, UserDto>();
                });
                var mapper = new Mapper(config);
                var dbuser = mapper.Map<UserDto>(rt);
                return dbuser;
            }
            return null;
        }
        public static UserDto Update(UserDto user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<User, UserDto>();
            });
            var mapper = new Mapper(config);
            var dbuser = mapper.Map<User>(user);
            var rt = DataAccessFactory.UserAccess().Update(dbuser);
            if (rt != null)
            {
                return mapper.Map<UserDto>(rt);
            }
            return null;
        }
    }
}
