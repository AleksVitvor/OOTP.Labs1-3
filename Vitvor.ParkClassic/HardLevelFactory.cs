using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class HardLevelFactory : IAbstractFactory
    {
        public IAddict CreateAddict()
        {
            Random random = new Random();
            return new HardAddict(random.Next(10,15));
        }

        public IBum CreateBum()
        {
            return new HardBum();
        }

        public IDrunk CreateDrunk()
        {
            Random random = new Random();
            return new HardDrunk(random.Next(1000, 3000));
        }
    }
}
