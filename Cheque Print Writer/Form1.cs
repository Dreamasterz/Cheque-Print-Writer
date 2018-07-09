using Microsoft.Reporting.WinForms;
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
    public partial class Form1 : Form
    {
        private bool _online = true;
        private bool secured = true;
        private bool Online
        {
            get { return _online; }
            set
            {
                if(value == true)
                {
                    if (secured)
                    {
                        onlinelabel.Text = "Online Mode";
                        onlinelabel.BackColor = Color.Chartreuse;
                    }
                    else
                    {
                        onlinelabel.BackColor = Color.Magenta;
                    }
                }
                else
                {
                    onlinelabel.Text = "Offline Mode";
                    onlinelabel.BackColor = Color.Red;
                }

                _online = value;
            }
        }
        public Form1()
        {
            InitializeComponent();

        }
        private bool isReady = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //Property Loaded
            Properties.Settings.Default.Reload();

            textBox3.Text = Properties.Settings.Default.D_Amount;
            //PAYEE
            payeeCapital.Checked = Properties.Settings.Default.PayeeCapitalize;
            payeeLower.Checked = Properties.Settings.Default.PayeeLower;
            payeeCustomize.Checked = Properties.Settings.Default.PayeeCustomize;
            //AMOUNT
            amountCapital.Checked = Properties.Settings.Default.AmountCapital;
            amountLower.Checked = Properties.Settings.Default.AmountLower;
            amountCamille.Checked = Properties.Settings.Default.AmountCamille;

            //Online and Offline Modes
            OfflineMode.Checked = Properties.Settings.Default.ModeOffline;
            OnlineMode.Checked = Properties.Settings.Default.ModeOnline;

            //Check if its online... if offline automatically set it to offline mode
            if (OnlineMode.Checked)
            {
                CheckLineConnection();
            }
            else
            {
                Online = false;
            }

            ////
            ///TODO: LOAD DATA if the Connection is Online
            if(Online)
            {
                StateClass.SC_PayeeData payee = new StateClass.SC_PayeeData();
                comboBox2.Items.Add(payee.DATA);
                comboBox2.DisplayMember = "name";
            }

            isReady = true;

            Report();
        }

        private void CheckLineConnection()
        {
            Online = new StateClass.ConnectionStr().ConnectionSuccess;

            if (Online)
            {

                if (OnlineMode.Checked)
                {
                    StateClass.SC_UserLogin login = new StateClass.SC_UserLogin();
                    login.UserName = Properties.Settings.Default.AppUser;
                    login.Password = Properties.Settings.Default.AppUserToken;

                    //If it is allowed to sign in automatically

                    login.IsToken = Properties.Settings.Default.KeepSignIn ? "1" : "2";

                    StateClass.LoginResult loginres = login.Login();
                    //Check first if it is secured. we need to login
                    if(loginres.Login)
                    {
                        Properties.Settings.Default.AppUserToken = loginres.Token;
                        return;
                    }

                    if (loginres.isSecured)
                    {
                        DialogResult res = new Login().ShowDialog();
                        if (res != DialogResult.OK)
                        {
                            this.Close();
                            return;
                        }
                    }
                }
            }
            else
            {
                OfflineMode.Checked = true;
                OnlineMode.Checked = false;
            }
        }

        private DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("date", typeof(string));
            table.Columns.Add("amount", typeof(string));
            table.Columns.Add("fullname", typeof(string));
            table.Columns.Add("wordamount", typeof(string));

            // Here we add five DataRows.
            string date =  checkBox1.Checked ?  "**"+dateTimePicker1.Value.ToString(textBox2.Text)+"**": "";
            if(checkBox4.Checked)
            {
                date = date.ToUpper();
            }

            decimal dec;
            string amount = "";
            if(decimal.TryParse(textBox3.Text, out dec))
            {
                 amount = "**"+String.Format("{0:n}", dec)+"**";
            }
            if(checkBox3.Checked == false)
            {
                amount = "";
            }
             
            string fullname = comboBox2.Text.Trim()=="" ? "" :"**"+ comboBox2.Text+"**";
            if(checkBox2.Checked == false)
            {
                fullname = "";
            }


            string wordamount = textBox5.Text.Trim() == "" ? "" : "**" + textBox5.Text +"**";

            table.Rows.Add(date, amount, fullname, wordamount);
            return table;
        }

        private void Report()
        {
            if (!isReady)
                return;
            //new ReportDataSource()
            this.reportViewer1.LocalReport.DataSources.Clear();
            var reportDataSource1 = new ReportDataSource("DataSet1", GetTable());
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cheque_Print_Writer.cheque.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!isReady)
                return;
            //Adding some comma separator
            //String.Format("{0:n}", 1234); //Output: 1,234.00
            //string.Format("{0:n0}", 9876); // no digits after the decimal point. Output: 9,876
            if(radioButton1.Checked == false)
            {
                Report();
                return;
            }

            try
            {
                string str = Math.Floor(decimal.Parse((sender as TextBox).Text)).ToString();

                var float_number = decimal.Parse((sender as TextBox).Text);
                var result = float_number - Math.Truncate(float_number);

                uint x;
                if (uint.TryParse(str, out x))
                {
                    string ss = "";
                    if (result > 0)
                    {
                        ss = (x > 0 ? " and " : "") + (Math.Floor(result * 100)) + "/100";
                    }
                    if (x > 0)
                    {
                        textBox5.Text = NumberinWords.NumberToWords(x) + ss + " Only";
                    }
                    else
                    {
                        textBox5.Text = ss + " Only";
                    }
                }
                else
                {
                    //textBox5.Text = "Invalid";
                }
            }catch
            {
                //textBox5.Text = "Invalid";
            }
            if(amountCapital.Checked)
            {
                textBox5.Text = textBox5.Text.ToUpper();
            }
            else if(amountLower.Checked)
            {
                textBox5.Text = textBox5.Text.ToLower();
            }
            Report();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Report();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Report();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox2.Text = "";
            //textBox3.Clear();
            //textBox5.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.D_Amount = textBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == radioButton1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void payeeCharactersClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.PayeeCapitalize = payeeCapital.Checked = false;
            Properties.Settings.Default.PayeeLower = payeeLower.Checked = false;
            Properties.Settings.Default.PayeeCustomize = payeeCustomize.Checked = false;

            (sender as ToolStripMenuItem).Checked = true;

            if(sender == payeeCapital)
            {

                Properties.Settings.Default.PayeeCapitalize = payeeCapital.Checked;
            }
            else if(sender == payeeLower)
            {
                Properties.Settings.Default.PayeeLower = payeeLower.Checked;
            }
            else if(sender == payeeCustomize)
            {
                Properties.Settings.Default.PayeeCustomize = payeeCustomize.Checked;
            }
       
        }

        private void amountCharacterClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.AmountCapital = amountCapital.Checked = false;
            Properties.Settings.Default.AmountLower = amountLower.Checked = false;
            Properties.Settings.Default.AmountCamille = amountCamille.Checked = false;

            (sender as ToolStripMenuItem).Checked = true;

            if(sender == amountCapital)
            {
                Properties.Settings.Default.AmountCapital = amountCapital.Checked;
            }
            else if(sender == amountLower)
            {
                Properties.Settings.Default.AmountLower = amountLower.Checked;
            }
            else if(sender == amountCamille)
            {
                Properties.Settings.Default.AmountCamille = amountCamille.Checked;
            }
        }

        private void modeLineClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModeOnline = OnlineMode.Checked = false;
            Properties.Settings.Default.ModeOffline = OfflineMode.Checked = false;

            (sender as ToolStripMenuItem).Checked = true;

            if (sender == OnlineMode)
            {
                Properties.Settings.Default.ModeOnline = OnlineMode.Checked;
                CheckLineConnection();
            }
            else if (sender == OfflineMode)
            {
                Properties.Settings.Default.ModeOffline = OfflineMode.Checked;
                Online = false;
            }
        }

        private void serverSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new DBSetup().ShowDialog();
            if(res == DialogResult.OK)
            {
                modeLineClick(OnlineMode, null);
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsersList().ShowDialog();
        }
    }
}
