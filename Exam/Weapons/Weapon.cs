using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Weapons
{
    internal abstract class Weapon
    {
        public abstract int BulletCapacity { get; set; }
        public abstract int BulletCount { get; set; }
        public abstract void ShowAllProp();
        public abstract int GetRemainBulletCount();
        public abstract void Reload();
    }
}
