using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, int, User>, IAuth
    {
        public User Add(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) { return obj; }
            return null;
        }

        public bool Authenticate(string Uname, string pass)
        {
            var data = db.Users.FirstOrDefault(u => u.Email.Equals(Uname) && u.Password.Equals(pass));
            if (data != null) return true;
            return false;
        }

        public User Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Users.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
