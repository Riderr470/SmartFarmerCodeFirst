using DAL.EF.Model;
using DAL.Interfaces;
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
        // Rafi
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
        //Ridan
        public static IRepo<User, int, User> UserAccess()
        {
            return new UserRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
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
        public static IRepo<Token, string, Token> TokenAccess()
        {
            return new TokenRepo();
        }
    }
}
