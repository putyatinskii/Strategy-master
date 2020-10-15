using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class With_Sound : Sound_Phone
    {
        public void Sound()
        {
            Console.WriteLine("Режим со звуком");
        }
    }
}
