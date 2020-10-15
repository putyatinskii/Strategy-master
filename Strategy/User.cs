using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class User
    {
        string model;
        Sound_Phone phone;

        public User(string model, Sound_Phone phone)
        {
            this.model = model;
            this.phone = phone;
        }

        public void Sound_Strategy()
        {
            phone.Sound();
        }
    }
}
