using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class FarmerContext : DbContext
    {
        public DbSet<Advisor> Advisors { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Customer> Customers{ set; get; }
        public DbSet<Comment> Comments { set; get; }
        public DbSet<Token> Tokens { set; get; }
        public DbSet<Product> Products { set; get; }
    }
}
