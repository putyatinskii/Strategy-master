using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Iphone : I_Phone
    {
        public void Charging()
        {
            Console.WriteLine("Для iphone необходим кабель Lighting");
        }
    }
}
