using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cheque_Print_Writer;

namespace StateClass
{
   public class ConnectionStr
    {
        public string Server
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.Server; }
            set { Cheque_Print_Writer.Properties.Settings.Default.Server = value; }
        }
        public string User
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.User; }
            set { Cheque_Print_Writer.Properties.Settings.Default.User = value; }
        }
        public string Database
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.Database; }
            set { Cheque_Print_Writer.Properties.Settings.Default.Database = value; }
        }
        public string Password
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.Password; }
            set { Cheque_Print_Writer.Properties.Settings.Default.Password = value; }
        }

        public string Port
        {

            get { return Cheque_Print_Writer.Properties.Settings.Default.Port; }
            set { Cheque_Print_Writer.Properties.Settings.Default.Port = value; }
        }

        public string Persistent
        {

            get { return Cheque_Print_Writer.Properties.Settings.Default.persistentsecurity; }
            set { Cheque_Print_Writer.Properties.Settings.Default.persistentsecurity = value; }
        }
        public string SslMode
        {

            get { return Cheque_Print_Writer.Properties.Settings.Default.sslmode; }
            set { Cheque_Print_Writer.Properties.Settings.Default.sslmode = value; }
        }
        public void Reset()
        {
            Cheque_Print_Writer.Properties.Settings.Default.Reset();
        }


        public void Save()
        {
            Cheque_Print_Writer.Properties.Settings.Default.Save();
        }

        public static string User_Name
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.AppUser; }
            set { Cheque_Print_Writer.Properties.Settings.Default.AppUser = value; }
        }
        public static string UserPassword
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.AppUserToken; }
            set { Cheque_Print_Writer.Properties.Settings.Default.AppUserToken = value; }
        }
        public static string EncKey
        {
            get { return Cheque_Print_Writer.Properties.Settings.Default.enkey; }
            set { Cheque_Print_Writer.Properties.Settings.Default.enkey = value; }
        }
        public bool ConnectionSuccess
        {
            get
            {
                return new DBControl.MySqlControl().ConnectionSuccess;
            }
        }

        public string SMTPADDRESS
        {
            get 
            {
                return new CodeScript()[Cheque_Print_Writer.Properties.Settings.Default.smtpaddress, ConnectionStr.EncKey, false];
            }
        }
        public string EMAILFROM
        {
            get
            {
                return new CodeScript()[Cheque_Print_Writer.Properties.Settings.Default.emailfrom, ConnectionStr.EncKey, false];
            }
        }
        public string EMAILCODE
        {
            get
            {
                return new CodeScript()[Cheque_Print_Writer.Properties.Settings.Default.emailcode, ConnectionStr.EncKey, false];
            }
        }

    }
}
