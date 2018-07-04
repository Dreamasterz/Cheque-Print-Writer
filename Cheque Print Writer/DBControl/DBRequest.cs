using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBControl
{
    public class MySqlControl
    {
        public bool MySqlCommand(string procedure, MySqlParameterCollection col)
        {
            MySqlConnection con = Connection;

            MySqlCommand command = new MySqlCommand(target_ + procedure, con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (MySqlParameter par in col)
                command.Parameters.Add(par);

            con.Open();
            command.ExecuteNonQuery();
            bool retval = command.Parameters["_out"].Value.ToString() == "0" ? false : true;
            con.Close();
            command.Dispose();

            return retval;
        }

        public bool ConnectionSuccess
        {
            get
            {
                try
                {
                    Connection.Open();
                    Connection.Close();
                }
                catch//(Exception e)
                {
                    //throw new Exception("Error", e);
                    return false;
                }
                return true;
            }
        }

        public string target_
        {
            get
            {
                return Cheque_Print_Writer.Properties.Settings.Default.target;
            }
        }

        public System.Data.DataSet DataSelect(string procedure, MySqlParameterCollection col)
        {
            MySqlConnection con = Connection;
            MySqlDataAdapter adap = new MySqlDataAdapter(target_ + procedure + "_select", con);
            adap.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (MySqlParameter par in col)
                adap.SelectCommand.Parameters.Add(par);
            System.Data.DataSet ds = new System.Data.DataSet();
            adap.Fill(ds);
            adap.Dispose();
            return ds;
        }
        private MySqlConnection Connection
        {
            get
            {
                //server={0};user id={1};password={2};persistsecurityinfo=True;port={3};database={4};SslMode=none
                string ss =
                "Server=" + Server +
                ";User=" + User +
                ";Password=" + Password +
                ";Database=" + Database +
                ";Port=" + Port +
                ";persistsecurityinfo=" + PersistentSecurityEnabled +
                ";SslMode=" + SsLMode + ";";
                return new MySqlConnection(ss);
            }
        }


        private string Server
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.Server, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }
        private string User
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.User, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];

            }
        }
        private string Password
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.Password, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }
        private string Database
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.Database, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }
        private string SsLMode
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.sslmode, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }
        private string PersistentSecurityEnabled
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.persistentsecurity, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }
        private string Port
        {
            get
            {
                return new MySqlControl()[Cheque_Print_Writer.Properties.Settings.Default.Port, Cheque_Print_Writer.Properties.Settings.Default.enkey, false];
            }
        }


        public string this[string value, string enckey, bool encrypting]
        {

            get
            {
                //enckey = "dreamaster";
                if (enckey.Trim() == "") return value;
                string retval = "";
                if (encrypting)
                {

                    while (enckey.Length < value.Length)
                        enckey += enckey;



                    for (int i = 0; i < value.Length; i++)
                    {
                        int j = value[i].GetHashCode();//.GetHashCode();
                        int k = enckey[i].GetHashCode();//.GetHashCode();
                        int res = (j + k);// % s.Length;
                        retval += ((char)(res));
                    }

                }
                else
                {

                    while (enckey.Length < value.Length)
                        enckey += enckey;
                    for (int i = 0; i < value.Length; i++)
                    {
                        int j = value[i].GetHashCode();
                        int k = enckey[i].GetHashCode();
                        int res = (j - k);
                        //if (res < 0)
                        //    res = s.Length + res;
                        retval += ((char)(res));
                    }
                }


                return retval;
            }

            //get
            //{
            //    string retval = "";
            //    string s = "1234567890qwertyuiopasdfghjklzxcvbnm";
            //    if (encrypting)
            //    {

            //        while (enckey.Length < value.Length)
            //            enckey += enckey;



            //        for (int i = 0; i < value.Length; i++)
            //        {
            //            int j = s.IndexOf(value[i]);//.GetHashCode();
            //            int k = s.IndexOf(enckey[i]);//.GetHashCode();
            //            int res = (j + k) % s.Length;
            //            retval += s[res];
            //        }

            //    }
            //    else
            //    {

            //        while (enckey.Length < value.Length)
            //            enckey += enckey;
            //        for (int i = 0; i < value.Length; i++)
            //        {
            //            int j = s.IndexOf(value[i]);//.GetHashCode();
            //            int k = s.IndexOf(enckey[i]);//.GetHashCode();
            //            int res = (j - k);
            //            if (res < 0)
            //                res = s.Length + res;
            //            retval += s[res % s.Length];
            //        }
            //    }


            //    return retval;
            //}

        }
    }


}
