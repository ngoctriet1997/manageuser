using ManageUser.DbMain;
using ManageUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageUser.DAO
{
    public class DaoUser
    {
        private ManageUserEntities2 DbUser;

        public DaoUser()
        {
            DbUser = new ManageUserEntities2();
        }
        public IEnumerable<Role> GetListRolesByIdUser(string idUser)
        {
            List<Role> lstRole = new List<Role>();
            var User = DbUser.Users.Where(x => x.id == idUser).SingleOrDefault();
            if (User != null)
            {
                var listRights = User.rights;
                listRights.ToList().ForEach(x =>
                {
                    lstRole.Add(new Role() { Id = x.id, RoleName = x.right_name });
                });
                var lstGroupsRight = DbUser.Users.Where(x => x.id == idUser).SingleOrDefault().groups.Select(x => x.rights);
                lstGroupsRight.ToList().ForEach(x =>
                {
                    x.ToList().ForEach(r =>
                    {
                        lstRole.Add(new Role() { Id = r.id, RoleName = r.right_name });
                    });

                });
                return lstRole;
            }
            return null;
        }
        public bool ChangePass(string userName, string oldPassWord, string newPassWord)
        {
            DaoLogin daoLogin = new DaoLogin();
            var user = DbUser.Users.Where(x => x.username == userName).Single();
            if (daoLogin.CheckLogin(userName, oldPassWord))
            {
                DbUser.passwords.Where(x => x.user_id == user.id).ToList().ForEach(x => x.status = "k");
                DbUser.SaveChanges();
                var idpassword = DbUser.passwords.Count().ToString();
                DbUser.passwords.Add(new password() { id = idpassword + 1, user_id = user.id, password1 = newPassWord, status = "c" });
                return DbUser.SaveChanges() > 0;
            }
            return false;
        }
        public string GetIdByUserName(string userName)
        {
            var user = DbUser.Users.Where(x => x.username == userName).SingleOrDefault();
            if (user != null)
                return user.id;
            return null;
        }


    }
}
