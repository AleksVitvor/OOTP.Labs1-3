using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class EazyAddict : IAddict
    {
        public int Dose { get; set; }
        public void Kick()
        {
            Random random = new Random();
            Console.WriteLine($"Вам нанесём удар силой {random.Next(1, 5)}");
        }
        public EazyAddict(int Dose)
        {
            this.Dose = Dose;    
        }
    }
    class MiddleAddict: IAddict
    {
        public int Dose { get; set; }

        public void Kick()
        {
            Random random = new Random();
            Console.WriteLine($"Вам нанесём удар силой {random.Next(10, 30)}");
        }
        public MiddleAddict(int Dose)
        {
            this.Dose = Dose;    
        }
    }
    class HardAddict : IAddict
    {
        public int Dose { get; set; }

        public void Kick()
        {
            Random random = new Random();
            
            Random randomForChoise = new Random();
            int choise = randomForChoise.Next(1, 3);
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine($"Наркоман нанес удар силой {random.Next(100, 300)}");
                        break;
                    }
                case 2:
                    {
                        this.Shoot();
                        break;
                    }
            }
        }
        public void Shoot()
        {
            Random random = new Random();
            Console.WriteLine($"Наркоман использовал оружие и нанёс {random.Next(1000,2000)} урона") ;
        }
        public HardAddict(int Dose)
        {
            this.Dose = Dose;
        }
    }
}
