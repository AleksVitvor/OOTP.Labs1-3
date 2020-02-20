using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IAbstractFactory
    {
        IBum CreateBum();
        IDrunk CreateDrunk();
        IAddict CreateAddict();
    }
}
