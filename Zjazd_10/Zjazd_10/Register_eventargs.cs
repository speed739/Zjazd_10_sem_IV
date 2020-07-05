using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    public class Register_eventargs
    {
        public Register_eventargs(string login, string password, string myProperty)
        {
            this.login = login;
            this.password = password;
            MyProperty = myProperty;
        }
        public string login { get; set; }
        public string password { get; set; }
        public string MyProperty { get; set; }

    }
}
