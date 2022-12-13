using Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Weapons
{
    internal class AWP : Weapon,ISingle
    {
        public override int BulletCapacity { get; set; }
        public override int BulletCount { get; set; }
        public AWP(int bulletCapacity, int bulletCount)
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

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine($">>>DISHIN<<< \nBullet count: {BulletCount} ");
            }
            else
                Console.WriteLine("Not enough bullets, reload");
        }

        public override void ShowAllProp()
        {
            Console.WriteLine($"---BulletCapacity:  {BulletCapacity} \n---BulletCount:     {BulletCount} ");
        }
    }
}
