using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    public class Registration_model :INotifyPropertyChanged 
    {
        public Registration_model()
        {
        }
        public Registration_model(string login, string password, string r_password)
        {
            this.login = login;
            this.password = password;
            this.r_password = r_password;
        }
        public string login { get; set; }
        public string password { get; set; }
        public string r_password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
