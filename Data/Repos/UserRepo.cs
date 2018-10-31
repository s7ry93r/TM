using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.Data.Models;

namespace TM.Data.Repos
{
    public class UserRepo
    {
        public bool DoesUserNameExist(string name)
        {
            using (TMContext db = new TMContext())
            {
                return db.AppUsers.Any(o => o.Name.Equals(name));
            }
        }

        public string GetUserPassword(string name)
        {
            using (TMContext db = new TMContext())
            {
                var user = db.AppUsers.Where(o => o.Name.ToLower().Equals(name));
                if (user.Any())
                    return user.FirstOrDefault().Pwd;
                else
                    return string.Empty;
            }
        }

        public AppUser FindUserByName(string userName)
        {
            using (TMContext db = new TMContext())
            {
                var user = db.AppUsers.Where(o => o.Name.ToLower().Equals(userName));
                if (user.Any())
                    return user.FirstOrDefault();
                else
                    throw new Exception("can't find user");
            }
        }



    }
}
