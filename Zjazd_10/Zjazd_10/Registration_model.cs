using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    public class Registration_model : INotifyPropertyChanged
    {
        public Registration_model()
        {
        }
        public Registration_model(string login, string password, string r_password, bool accept)
        {
            this.login = login;
            this.password = password;
            this.r_password = r_password;
            this.accept = accept;
        }
        private string _login;
        private string _passowrd;
        private string _rpassowrd;
        private bool _accept;

        public string login
        {
            get => _login;
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged();

                }
            }
        }
        public string password { get; set; }
        public string r_password { get; set; }
        public bool accept { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
