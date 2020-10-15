using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class User
    {
        I_Phone phone;

        public User(I_Phone phone)
        {
            this.phone = phone;
        }

        public void Charging_Strategy()
        {
            phone.Charging();
        }
    }
}
