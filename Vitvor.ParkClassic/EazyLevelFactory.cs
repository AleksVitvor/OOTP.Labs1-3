using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class EazyLevelFactory : IAbstractFactory
    {
        public IAddict CreateAddict()
        {
            Random random = new Random();
            return new EazyAddict(random.Next(1, 4));
        }

        public IBum CreateBum()
        {
            return new EazyBum();
        }

        public IDrunk CreateDrunk()
        {
            Random random = new Random();
            return new EazyDrunk(random.Next(30, 250));
        }
    }
}
