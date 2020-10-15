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
            User user = new User("Iphone", new No_Sound());
            Console.WriteLine("Iphone:");
            user.Sound_Strategy();

            User user2 = new User("Xiaomi", new Vibration());
            Console.WriteLine("Xiaomi:");
            user2.Sound_Strategy();

            User user3 = new User("Iphone", new With_Sound());
            Console.WriteLine("Iphone:");
            user3.Sound_Strategy();
        }
    }
}
