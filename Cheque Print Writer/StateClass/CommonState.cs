using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StateClass
{
    public class CommonState
    {
        public CommonState()
        {
            MySqlCommand com = new MySqlCommand();
            MySqlParameterCommand = com.Parameters;
            MySqlParameterCommand.AddWithValue("_id", "");
            MySqlParameterCommand.AddWithValue("_user_name", ConnectionStr.User_Name);


            MySqlCommand sel = new MySqlCommand();
            MysqlParameterSelect = sel.Parameters;
            MysqlParameterSelect.AddWithValue("_user_name", ConnectionStr.User_Name);

            MySqlParameter _out = new MySqlParameter("_out", MySqlDbType.Int16);
            _out.Direction = System.Data.ParameterDirection.Output;
            MySqlParameterCommand.Add(_out);

            MySqlParameter text_output = new MySqlParameter("_output", MySqlDbType.String);
            text_output.Direction = System.Data.ParameterDirection.Output;
            MySqlParameterCommand.Add(text_output);
        }

        public string ProcedureName;
        //public string target_ = "dtr";
        public long ID
        {
            get { return (long)MySqlParameterCommand["_id"].Value; }
            set { MySqlParameterCommand["_id"].Value = value; }
        }
        public MySqlResult Insert()
        {
            MySqlResult res = new MySqlResult();
            res.Success = new DBControl.MySqlControl().MySqlCommand( ProcedureName + "_insert", MySqlParameterCommand);
            res.Message = MySqlParameterCommand["_output"].Value.ToString();
            return res;
        }
        public MySqlResult Update()
        {
            MySqlResult res = new MySqlResult();
            res.Success = new DBControl.MySqlControl().MySqlCommand( ProcedureName + "_update", MySqlParameterCommand);
            res.Message = MySqlParameterCommand["_output"].Value.ToString();
            return res;
        }
        public MySqlResult Delete()
        {
            MySqlResult res = new MySqlResult();
            res.Success = new DBControl.MySqlControl().MySqlCommand( ProcedureName + "_delete", MySqlParameterCommand);
            res.Message = MySqlParameterCommand["_output"].Value.ToString();
            return res;
        }
        public System.Data.DataSet DataRead()
        {
            return new DBControl.MySqlControl().DataSelect(ProcedureName, MysqlParameterSelect);
        }



        protected MySql.Data.MySqlClient.MySqlParameterCollection MySqlParameterCommand;
        protected MySqlParameterCollection MysqlParameterSelect;
    }
    public class MySqlResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
