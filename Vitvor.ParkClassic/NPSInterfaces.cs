using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IAddict
    {
        int Dose { get; set; }
        void Kick();
    }
    interface IDrunk
    {
        int Volume { get; set; }
        void Hit();
    }
    interface IBum
    {
        void Lie();
    }
}
