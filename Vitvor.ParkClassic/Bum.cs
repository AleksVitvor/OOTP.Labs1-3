using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class EazyBum : IBum
    {
        public void Lie()
        {
            
        }
    }
    class MiddleBum : IBum
    {
        public void Lie()
        {
            
        }
    }
    class HardBum : IBum
    {
        public void Attack()
        {
            Console.WriteLine("БОМЖ атакует");
        }
        public void Lie()
        {
            Random randomForChoise = new Random();
            int choise = randomForChoise.Next(1, 3);
            switch (choise)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        this.Attack();
                        break;
                    }
            }
        }
    }
}