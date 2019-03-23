using ManageUser.DbMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageUser.DAO
{
    public class DaoLogin
    {
        private ManageUserEntities2 DbLogin;
         
        public DaoLogin()
        {
            DbLogin = new ManageUserEntities2();
        }
        public bool CheckLogin(string username,string password)
        {
           
            try
            {
               var userLogin = DbLogin.Users.Where(x => x.username == username).Single();
               return userLogin.passwords.Count(x => x.password1 == password && x.status == "c") == 1;
               
            }
           catch(ArgumentNullException e)
            {

            }
            catch(InvalidOperationException e)
            {

            }
            finally
            {
             
            }
            return false;
        }
    }
}
