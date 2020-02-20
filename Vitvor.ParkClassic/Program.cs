using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAddict> addicts = new List<IAddict>();
            List<IDrunk> drunks = new List<IDrunk>();
            List<IBum> bums = new List<IBum>();
            List<IPlant> plants = new List<IPlant>();
            ParkBuilder park = new ParkBuilder("Окружающий парк");
            Director director = new Director(park);
            director.BuildBasePark();
            Console.WriteLine($"Парк состоит из {park.countOfObjects} объектов");
            park.Draw();
            Console.WriteLine(park.Find("Клён").ToString());
            Console.WriteLine("Введите имя игрового персонажа");
            string personName = Console.ReadLine();
            Console.WriteLine("Выберите уровень сложности\n1-Простой уровень\n2-Средний уровень\n3-Сложный уровень");
            int levelOfDifficulty = Convert.ToInt32(Console.ReadLine());
            SingletonMainPerson mainPerson = SingletonMainPerson.getInstance(personName, levelOfDifficulty);
            switch(mainPerson.levelOfDifficulty)
            {
                case 1:
                    {
                        IAbstractFactory factory = new EazyLevelFactory();
                        for (int i = 0; i < 10; i++) 
                        {
                            addicts.Add(factory.CreateAddict());
                        }
                        for (int i = 0; i < 5; i++) 
                        {
                            bums.Add(factory.CreateBum());
                        }
                        for (int i = 0; i < 8; i++) 
                        {
                            drunks.Add(factory.CreateDrunk());
                        }
                        break; 
                    }
                case 2:
                    {
                        IAbstractFactory factory = new MiddleLevelFactory();
                        for (int i = 0; i < 10; i++) 
                        {
                            addicts.Add(factory.CreateAddict());
                        }
                        for (int i = 0; i < 5; i++) 
                        {
                            bums.Add(factory.CreateBum());
                        }
                        for (int i = 0; i < 8; i++) 
                        {
                            drunks.Add(factory.CreateDrunk());
                        }
                        break;
                    }
                case 3:
                    {
                        IAbstractFactory factory = new HardLevelFactory();
                        for (int i = 0; i < 10; i++)
                        {
                            addicts.Add(factory.CreateAddict());
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            bums.Add(factory.CreateBum());
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            drunks.Add(factory.CreateDrunk());
                        }
                        break;
                    }
            }
            foreach(var i in addicts)
            {
                i.Kick();
            }
            foreach (var i in drunks)
            {
                i.Hit();
            }
            foreach (var i in bums)
            {
                i.Lie();
            }
            Pistol pistol = new Pistol();
            Loot loot = new chargeForPistol();
            Random random = new Random();
            if (random.Next(0, 20) == 11)
                loot = new bigPackChargeForPistol(loot);
            while(true)
            {
                mainPerson.Defend(pistol);
                pistol.Charge--;
                if (pistol.Charge == 0 && loot.Status == true)
                {
                    loot.Status = false;
                    pistol.Charge += loot.Count();
                    continue;
                }
                else if (pistol.Charge == 0)
                    break;
            }
            Bit bit = new Bit();
            IGun bit1 = new BitToGunAdapter(bit);
            for (int i = 0; i < 5; i++) 
            {
                mainPerson.Defend(bit1);
            }
            Console.ReadKey();
        }
    }
}
