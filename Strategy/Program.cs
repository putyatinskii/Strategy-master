using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(new Honor());
            user.Charging_Strategy();

            User user2 = new User(new Xiaomi());
            user2.Charging_Strategy();

            User user3 = new User(new Iphone());
            user3.Charging_Strategy();
        }
    }
}
