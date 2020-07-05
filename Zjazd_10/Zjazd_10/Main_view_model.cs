using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    public class Main_view_model
    {

        public FakeDB database { get; set; }
        public Main_view_model()
        {
            mod = new Registration_model();
            mod_va = new Registration_model_validation();
        }
        public Registration_model mod;
        public Registration_model_validation mod_va;


    }
}
