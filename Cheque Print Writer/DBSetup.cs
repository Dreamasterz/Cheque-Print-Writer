using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateClass;


namespace Cheque_Print_Writer
{
    public partial class DBSetup : Form
    {
        //
        StateClass.ConnectionStr constring = new StateClass.ConnectionStr();

        public DBSetup()
        {
            InitializeComponent();
        }

        private void DBSetup_Load(object sender, EventArgs e)
        {
            dbserver.Text = constring.Server;
            dbusername.Text = constring.User;
            dbpassword.Text = constring.Password;
            dbport.Text = constring.Port;
            dbname.Text = constring.Database;
            chkpersistent.Checked = constring.Persistent == "True";
            chksslmode.Checked = constring.SslMode != "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            constring.Server = dbserver.Text;
            constring.User = dbusername.Text;
            constring.Password = dbpassword.Text;
            constring.Port = dbport.Text;
            constring.Database = dbname.Text;
            constring.Persistent = chkpersistent.Checked ? "True" : "False";
            constring.SslMode = chksslmode.Checked ? "yes" : "none";

            if(constring.ConnectionSuccess)
            {
                MessageBox.Show("Success");
                constring.Save();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
