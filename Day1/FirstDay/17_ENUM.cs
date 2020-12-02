using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class ENUM
    {
        public enum Season { WINTER, SPRING, SUMMER, FALL }
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main()
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);
            Console.WriteLine("----------------------------------------");
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------------------");
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }
        }
    }
}
