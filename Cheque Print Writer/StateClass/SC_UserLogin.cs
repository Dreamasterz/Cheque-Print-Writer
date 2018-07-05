using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClass
{
    public class SC_UserLogin : CommonState
    {
        public SC_UserLogin()
            : base()
        {
            ProcedureName = "userlogin";
            MysqlParameterSelect.AddWithValue("_username", "");
            MysqlParameterSelect.AddWithValue("_password", "");
            MysqlParameterSelect.AddWithValue("_istoken", "0");
        }

        public LoginResult Login()
        {
            if (MysqlParameterSelect == null) return null;
            LoginResult col = new LoginResult();
            System.Data.DataSet ds = DataRead();
            foreach (System.Data.DataRow d in ds.Tables[0].Rows)
            {
                col.isSecured = d["secure"].ToString() == "yes";
                col.Login = d["login"].ToString() == "1";
                col.Token = d["token"].ToString();
                col.Message = d["message"].ToString();
            }
            return col;
        }

        public string UserName
        {
            get { return MysqlParameterSelect["_username"].Value.ToString(); }
            set { MysqlParameterSelect["_username"].Value = value; }
        }

        public string Password
        {
            get { return MysqlParameterSelect["_password"].Value.ToString(); }
            set { MysqlParameterSelect["_password"].Value = value; }
        }
        public string IsToken
        {
            get { return MysqlParameterSelect["_istoken"].Value.ToString(); }
            set { MysqlParameterSelect["_istoken"].Value = value; }
        }

    }
    public class LoginResult
    {
        public bool isSecured { get; set; }
        public bool Login { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
