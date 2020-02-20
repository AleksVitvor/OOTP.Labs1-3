using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class MiddleLevelFactory : IAbstractFactory
    {
        public IAddict CreateAddict()
        {
            Random random = new Random();
            return new MiddleAddict(random.Next(5, 9));
        }

        public IBum CreateBum()
        {
            return new MiddleBum();
        }

        public IDrunk CreateDrunk()
        {
            Random random = new Random();
            return new MiddleDrunk(random.Next(300, 750));
        }
    }
}
