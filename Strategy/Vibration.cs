using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Vibration : Sound_Phone
    {
        public void Sound()
        {
            Console.WriteLine("Режим с вибрацией");
        }
    }
}
