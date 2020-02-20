using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class Director
    {
        private IParkBuilder parkBuilder;
        public Director(IParkBuilder parkBuilder)
        {
            this.parkBuilder = parkBuilder;
        }
        public IParkBuilder BuildBasePark()
        {
            Random random = new Random();
            int countOfBenches = random.Next(0, 10);
            for (int i = 0; i < countOfBenches; i++) 
            {
                parkBuilder.AddBench();
            }
            int coutOfGrass = random.Next(1, 7);
            for (int i = 0; i < coutOfGrass; i++)
            {
                parkBuilder.AddGrass();
            }
            int countOfLanes = random.Next(1, 3);
            for (int i = 0; i < countOfLanes; i++) 
            {
                parkBuilder.AddLane();
            }
            int countOfTrees = random.Next(10, 15);
            for (int i = 0; i < countOfTrees; i++)
            {
                parkBuilder.AddTree();
            }
            return parkBuilder.GetResult();
        }
    }
}
