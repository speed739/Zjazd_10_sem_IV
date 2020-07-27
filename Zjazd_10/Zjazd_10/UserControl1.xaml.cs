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
          /*Gdy tak przypiszę wartości to validacja działa, w przeciwnym razie control_model jest nullem */
                  
      //    control_model.model.login = tb_Name.Text;
      //    control_model.model.password = tb_Passw.Text;
      //    control_model.model.r_password = tb_RPassw.Text;

            RegisterAttempt?.Invoke(this, new Register_eventargs(control_model.model.login, control_model.model.password, control_model.model.r_password));
            tb_Name.Clear();
            tb_Passw.Clear();
            tb_RPassw.Clear();
        }

        private void cb_Terms_Checked(object sender, RoutedEventArgs e)
        {
            /*W tej funkcji starałem się wywołać na siłę metode CanExecute by sprawdzić czy jest coś w zmiennej control_model.model, niestyty null */
            control_model.RegisterCommand.CanExecute(control_model.model);
        }
    }
}
