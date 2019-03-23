using ManageUser.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageUser
{
    public partial class ManageGroups : Form
    {
        private DaoGroup daoGroup;
        public ManageGroups()
        {
            InitializeComponent();
            this.TopLevel = false;
            daoGroup = new DaoGroup();
            ShowListRoles(this.gridRoles);
        }
        private void ShowListRoles(DataGridView dataGridView)
        {
            dataGridView.DataSource = daoGroup.GetAll();
        }
    }
}
