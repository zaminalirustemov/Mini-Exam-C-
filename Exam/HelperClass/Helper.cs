using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.HelperClass
{
    internal static class Helper
    {
        public static int bulletCapacity;
        public static int bulletCount;
        public static bool check;
        public static int WriteBulletCapacity()
        {
            do
            {
                Console.Write("---Enter the bulletcapacity:");
                check = int.TryParse(Console.ReadLine(), out bulletCapacity);
                if (bulletCapacity <= 0)
                {
                    check = false;
                    Console.WriteLine("Error: Bullet capacity is a number and must be greater than 0");
                }
                
            } while (!check);
            return bulletCapacity;
        }
        public static int WriteBulletCount()
        {
            do
            {
                Console.Write("---Enter the bulletcount:");
                check = int.TryParse(Console.ReadLine(), out bulletCount);
                if (bulletCount > bulletCapacity || bulletCount < 0)
                {
                    check = false;
                    Console.WriteLine("Error: Bullet capacity is a number and must be greater than 0 and not greater than capacity");
                }
            } while (!check);
            return bulletCount;
        }
    }
}
