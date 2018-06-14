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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            textBox3.Text = Properties.Settings.Default.D_Amount;
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
            //new ReportDataSource()
            this.reportViewer1.LocalReport.DataSources.Clear();
            var reportDataSource1 = new ReportDataSource("DataSet1", GetTable());
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cheque_Print_Writer.cheque.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
    }
}
