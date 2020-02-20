using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class EazyDrunk : IDrunk
    {
        public int Volume { get; set; }

        public void Hit()
        {
            Random random = new Random();
            Console.WriteLine($"Алкаш наносит {random.Next(7, 17)}");
        }
        public EazyDrunk(int Volume)
        {
            this.Volume = Volume;
        }
    }
    class MiddleDrunk : IDrunk
    {
        public int Volume { get; set; }

        public void Hit()
        {
            Random random = new Random();
            Console.WriteLine($"Алкаш наносит {random.Next(27, 50)}");
        }
        public MiddleDrunk(int Volume)
        {
            this.Volume = Volume;
        }
    }
    class HardDrunk : IDrunk
    {
        public int Volume { get; set; }

        public void Hit()
        {
            Random random = new Random();
            Random randomForChoise = new Random();
            int choise=randomForChoise.Next(1, 3);
            switch(choise)
            {
                case 1:
                    {
                        Console.WriteLine($"Алкаш наносит {random.Next(100, 250)}");
                        break;
                    }
                case 2:
                    {
                        this.Attack();
                        break;
                    }
            }
            
        }
        public HardDrunk(int Volume)
        {
            this.Volume = Volume;
        }
        public void Attack()
        {
            Random random = new Random();
            Console.WriteLine($"Алкаш атакует розочкой и наносит критический урон {random.Next(100, 250) * 3}");
        }
    }
}