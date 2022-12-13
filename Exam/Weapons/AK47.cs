using Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Weapons
{
    public enum IsAuto { Single, Auto }
    internal class AK47 : Weapon, ISingle, IAuto,IAutoSingle
    {
        IsAuto _isAuto = IsAuto.Auto;
        public override int BulletCapacity { get; set; }
        public override int BulletCount { get; set; }

        public AK47(IsAuto isAuto, int bulletCapacity, int bulletCount)
        {
            _isAuto = isAuto;
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
        public void Fire()
        {
            if (_isAuto == IsAuto.Auto)
            {
                if (BulletCount > 0)
                {
                    BulletCount = 0;
                    Console.WriteLine($">>>DIDIDIDIDIDISHHHHHINNNNNN<<< \nBullet count: {BulletCount}");
                }
                else 
                    Console.WriteLine($"Not enough bullets");
            }
            else Shoot();
        }

        public override void ShowAllProp()
        {
            Console.WriteLine($"---BulletCapacity:  {BulletCapacity} \n---BulletCount:     {BulletCount} ");
        }

        public void ChangeFireMode()
        {
            if (_isAuto == IsAuto.Auto)
                _isAuto = IsAuto.Single;
            else
                _isAuto = IsAuto.Auto;
            Console.WriteLine("Weapon mode changed.");
        }
    }
}
