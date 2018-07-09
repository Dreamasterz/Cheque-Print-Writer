using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClass
{
    public class SC_PayeeData : CommonState
    {
        public SC_PayeeData()
            : base()
        {
            ProcedureName = "payeedata";
            MySqlParameterCommand.AddWithValue("_name", "");
            MySqlParameterCommand.AddWithValue("_amount", "");
            MySqlParameterCommand.AddWithValue("_datetime", "");
            MySqlParameterCommand.AddWithValue("_dateformat", "");
            MySqlParameterCommand.AddWithValue("_bank", "");
            MySqlParameterCommand.AddWithValue("_word", "");
        }



        public List<SC_PayeeData> DATA
        {
            get
            {
                if (MysqlParameterSelect == null) return null;
                List<SC_PayeeData> col = new List<SC_PayeeData>();
                System.Data.DataSet ds = DataRead();
                foreach (System.Data.DataRow d in ds.Tables[0].Rows)
                {
                    SC_PayeeData s = new SC_PayeeData();
                    s.ID = long.Parse(d["id"].ToString());
                    s.name = d["name"].ToString();
                    s.amount = d["amount"].ToString();
                    s.dateTime = d["datetime"].ToString();
                    s.dateFormat = d["dateformat"].ToString();
                    s.bank = d["bank"].ToString();
                    s.word = d["word"].ToString();
                    col.Add(s);
                }
                return col;
            }
        }

        public string name
        {
            get { return MySqlParameterCommand["_name"].Value.ToString(); }
            set { MySqlParameterCommand["_name"].Value = value; }
        }

        public string amount
        {
            get { return MySqlParameterCommand["_amount"].Value.ToString(); }
            set { MySqlParameterCommand["_amount"].Value = value; }
        }
        public string dateTime
        {
            get { return MySqlParameterCommand["_datetime"].Value.ToString(); }
            set { MySqlParameterCommand["_datetime"].Value = value; }
        }
        public string dateFormat
        {
            get { return MySqlParameterCommand["_dateformat"].Value.ToString(); }
            set { MySqlParameterCommand["_dateformat"].Value = value; }
        }
        public string bank
        {
            get { return MySqlParameterCommand["_bank"].Value.ToString(); }
            set { MySqlParameterCommand["_bank"].Value = value; }
        }
        public string word
        {
            get { return MySqlParameterCommand["_word"].Value.ToString(); }
            set { MySqlParameterCommand["_word"].Value = value; }
        }
    }
}
