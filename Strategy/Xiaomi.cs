using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Xiaomi : I_Phone
    {
        public void Charging()
        {
            Console.WriteLine("Для xiaomi необходим кабель USB Type-C");
        }
    }
}
