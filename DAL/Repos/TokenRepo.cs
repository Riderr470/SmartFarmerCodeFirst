using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo:Repo, IRepo<Token, string, Token>
    {
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) { return obj; }
            return null;
        }

        public Token Delete(string id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Tokens.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.Find(id);
        }

        public Token Update(Token obj)
        {
            var dbco = Get(obj.Tkey);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
