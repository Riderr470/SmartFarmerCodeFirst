using DAL.EF.Model;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, int, Customer> CustomerAccess()
        {
            return new CustomerRepo();
        }
        public static IRepo<Product, int, Product> ProductAccess()
        {
            return new ProductRepo();
        }
        public static IRepo<Comment, int, Comment> CommentAccess()
        {
            return new CommentRepo();
        }
    }
}
