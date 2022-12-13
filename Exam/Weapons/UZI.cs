using Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Weapons
{
    internal class UZI :Weapon,IAuto
    {
        public override int BulletCapacity { get; set; }
        public override int BulletCount { get; set; }
        public UZI(int bulletCapacity, int bulletCount)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
        }

        public override int GetRemainBulletCount()
        {
            int remainBullet = BulletCapacity - BulletCount;
            return remainBullet;
        }

        public override void Reload()
        {
            if (BulletCount < BulletCapacity)
            {
                BulletCount = BulletCount + GetRemainBulletCount();
                Console.WriteLine($"weapon is reloaded. Bullet:{BulletCount}");
            }
            else
                Console.WriteLine("Full of bullets.");
        }

        public void Fire()
        {
            if (BulletCount > 0)
            {
                BulletCount = 0;
                Console.WriteLine($">>>DIDIDIDIDIDISHHHHHINNNNNN<<< \nBullet count: {BulletCount}");

            }
            else
                Console.WriteLine($"Not enough bullets");
        }

        public override void ShowAllProp()
        {
            Console.WriteLine($"---BulletCapacity:  {BulletCapacity} \n---BulletCount:     {BulletCount} ");
        }
    }
}
