using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static List<ProductDto> Get()
        {
            var data = DataAccessFactory.ProductAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<ProductDto>>(data);
            return rt;
        }
        public static ProductDto Get(int id)
        {
            var data = DataAccessFactory.ProductAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<ProductDto>(data);
            return rt;
        }
        public static ProductDto AddProduct(ProductDto product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDto, Product>();
                c.CreateMap<Product, ProductDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Product>(product);
            var rt = DataAccessFactory.ProductAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ProductDto>(rt);
            }
            return null;
        }
    }
}
