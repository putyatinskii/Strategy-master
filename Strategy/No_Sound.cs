using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class No_Sound : Sound_Phone
    {

        public void Sound()
        {
            Console.WriteLine("Беззвучный режим");
        }
    }
}
