using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IParkBuilder
    {
        void AddTree();
        void AddBench();
        void AddLane();
        void AddGrass();
        IParkBuilder GetResult();
    }
}
