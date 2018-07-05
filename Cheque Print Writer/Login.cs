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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StateClass.SC_UserLogin sclogin = new StateClass.SC_UserLogin();
            sclogin.UserName = textBox1.Text;
            sclogin.Password = textBox2.Text;
            StateClass.LoginResult result = sclogin.Login();

            if(result.Login)
            {
                Properties.Settings.Default.AppUser = textBox1.Text;
                Properties.Settings.Default.AppUserToken = result.Token;
                Properties.Settings.Default.KeepSignIn = checkBox1.Checked;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label3.Visible = true;
            }

        }
    }
}
