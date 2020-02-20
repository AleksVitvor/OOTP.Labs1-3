using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IManualWeapon
    {
        void Hit();
    }
    class Bit : IManualWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Удар битой");
        }
    }
    class BitToGunAdapter:IGun
    {
        Bit bit;
        public BitToGunAdapter(Bit b)
        {
            bit = b;
        }
        public void Shot()
        {
            bit.Hit();
        }
    }
}
