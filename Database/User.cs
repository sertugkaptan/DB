using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class User
    {
        static String Usn;
        public static String usn
        {
            get
            {
                return Usn;
            } 
            set
            {
                Usn = value;
            }
        }
    }
}
