using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateClass
{
    public class CodeScript
    {
        public string this[string value, string enckey, bool encrypting]
        {
            get
            {
                return new DBControl.MySqlControl()[value, enckey, encrypting];
            }
        }
    }
}
