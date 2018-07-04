using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClass
{
    public class SC_Userlists : CommonState
    {
        public SC_Userlists()
            : base()
        {
            ProcedureName = "userlist";
        }
        public List<SC_Userlists> USERS
        {
            get
            {
                if (MysqlParameterSelect == null) return null;
                List<SC_Userlists> col = new List<SC_Userlists>();
                System.Data.DataSet ds = DataRead();
                foreach (System.Data.DataRow d in ds.Tables[0].Rows)
                {
                    SC_Userlists s = new SC_Userlists();
                    s.ID = long.Parse(d["id"].ToString());
                    s.UserName = d["user_name"].ToString();
                    s.Fullname = d["fullname"].ToString();
                    s.EmailAdd = d["email"].ToString();
                    s.Messages = 0;
                    //Should be programmatically executed using the ip
                    s.ONLINE = false;

                    col.Add(s);
                }
                return col;
            }
        }

        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string EmailAdd { get; set; }
        public bool ONLINE { get; set; }
        public int Messages { get; set; }
    }
}
