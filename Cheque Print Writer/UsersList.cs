using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheque_Print_Writer
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StateClass.SC_User user = new StateClass.SC_User();
            user.Username = username.Text;
            user.Fullname = fullname.Text;
            user.Email = email.Text;
            user.Password = password.Text;

            MessageBox.Show(user.Insert().Message);

        }
    }
}
