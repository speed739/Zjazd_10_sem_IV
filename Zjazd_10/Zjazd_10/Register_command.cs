using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zjazd_10
{
    class Register_command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Registration_model_validation valid;

        public bool CanExecute(object parameter)
        {
            if (parameter is object && parameter is Registration_model)
            {
                var model = parameter as Registration_model;
                if (valid.Validate(model).IsValid && model.password == model.r_password)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
