using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using TM.Data;
using TM.Data.Repos;


namespace TM.WebApp.Lib
{
    public class UserManager
    {
        private bool _validUser0;
        private UserRepo ur;

        public static string GetRequestUserName()
        {
            try
            {
                var userName = HttpContext.Current.User.Identity.Name;
                return userName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public UserManager()
        {
            ur = new UserRepo();
        }

        public bool UserExists(string userName)
        {
            return ur.DoesUserNameExist(userName);
        }

        public string GetUserPwd(string userName)
        {
            return ur.GetUserPassword(userName);
        }



    }
}