using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zjazd_10
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public event EventHandler<Register_eventargs> RegisterAttempt;
        public UserControl_model control_model { get; set; }

        public UserControl1()
        {
            InitializeComponent();
            control_model = new UserControl_model();
            
        }
        private void RegisterAction(object sender, RoutedEventArgs e)
        {
            RegisterAttempt?.Invoke(this, new Register_eventargs(control_model.model.login, control_model.model.password, control_model.model.r_password));
            tb_Passw.Clear();
            tb_RPassw.Clear();
        }
    }
}
