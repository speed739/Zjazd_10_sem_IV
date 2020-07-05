using System.Windows;

namespace Zjazd_10
{
    public class FakeDB
    {
        public void RegisterUser(Registration_model model)
        {
            MessageBox.Show($"User {model.login} registered !!!");
        }
    }
}