using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, int, Customer>
    {
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);
            if (db.SaveChanges() > 0) { return obj; }
            return null;
        }

        public Customer Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Customers.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var dbco = Get(obj.UserId);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
