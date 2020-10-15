using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Honor : I_Phone
    {
        public void Charging()
        {
            Console.WriteLine("Для honor необходим кабель micro-USB");
        }
    }
}
