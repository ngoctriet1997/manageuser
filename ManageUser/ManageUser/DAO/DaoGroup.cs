using ManageUser.DbMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageUser.DAO
{
    public class DaoGroup
    {
        private ManageUserEntities2 DbRole;

        public DaoGroup()
        {
            DbRole = new ManageUserEntities2();
        }
        public IEnumerable<ManageUser.Models.Group> GetAll()
        {
            return DbRole.groups.Select(x => new Models.Group() { Id = x.id, Name = x.group_name,Descript=x.Descipt }).ToList();
        }
    }
}
