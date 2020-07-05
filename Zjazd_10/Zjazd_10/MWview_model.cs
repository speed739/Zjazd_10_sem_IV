using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    class MWview_model
    {
        public MWview_model()
        {
            regis = new Registration_model();
            regis_val = new Registration_model_validation();
        }
        public MWview_model(Registration_model registrationModel)
        {
            regis = new Registration_model();
            regis_val = new Registration_model_validation();
        }

        public Registration_model regis { get; set; }
        public Registration_model_validation regis_val { get; set; }


    }
}

