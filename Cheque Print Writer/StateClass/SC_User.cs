using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StateClass
{
    class SC_User : CommonState
    {
        public SC_User()
            : base()
        {
            ProcedureName = "appuser";
            MySqlParameterCommand.AddWithValue("_username", "");
            MySqlParameterCommand.AddWithValue("_fullname", "");
            MySqlParameterCommand.AddWithValue("_email", "");
            MySqlParameterCommand.AddWithValue("_password", "");
        }

        public string Username
        {
            get { return MySqlParameterCommand["_username"].Value.ToString(); }
            set { MySqlParameterCommand["_username"].Value = value; }
        }

        public string Fullname
        {
            get { return MySqlParameterCommand["_fullname"].Value.ToString(); }
            set { MySqlParameterCommand["_fullname"].Value = value; }
        }

        public string Email
        {
            get { return MySqlParameterCommand["_email"].Value.ToString(); }
            set { MySqlParameterCommand["_email"].Value = value; }
        }

        public string Password
        {
            get { return MySqlParameterCommand["_password"].Value.ToString(); }
            set { MySqlParameterCommand["_password"].Value = value; }
        }
    }
}
