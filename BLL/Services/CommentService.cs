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
    public class CommentService
    {
        public static CommentDto AddComment(CommentDto comment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CommentDto, Comment>();
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Comment>(comment);
            var rt = DataAccessFactory.CommentAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<CommentDto>(rt);
            }
            return null;
        }
        public static List<CommentDto> Get()
        {
            var data = DataAccessFactory.CommentAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CommentDto>>(data);
        }
        public static CommentDto Get(int id)
        {
            var data = DataAccessFactory.CommentAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CommentDto>(data);
        }
        public static CommentDto Delete(int id)
        {
            var rt = DataAccessFactory.CommentAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Comment, CommentDto>();
                });
                var mapper = new Mapper(config);
                var dbcomment = mapper.Map<CommentDto>(rt);
                return dbcomment;
            }
            return null;
        }
        public static CommentDto Update(CommentDto comment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommentDto, Comment>();
                cfg.CreateMap<Comment, CommentDto>();
            });
            var mapper = new Mapper(config);
            var dbcomment = mapper.Map<Comment>(comment);
            var rt = DataAccessFactory.CommentAccess().Update(dbcomment);
            if (rt != null)
            {
                return mapper.Map<CommentDto>(rt);
            }
            return null;
        }
    }
}
