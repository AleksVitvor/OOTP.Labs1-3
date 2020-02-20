using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class SingletonMainPerson
    {
        private static SingletonMainPerson instance;
        private string Name;
        public int levelOfDifficulty { get; private set; }
        private SingletonMainPerson(string Name, int levelOfDifficulty)
        {
            this.Name = Name;
            this.levelOfDifficulty = levelOfDifficulty;
        }
        public static SingletonMainPerson getInstance(string Name, int levelOfDifficulty)
        {
            if (instance == null)
                instance = new SingletonMainPerson(Name, levelOfDifficulty);
            return instance;
        }

        //новое
        public void Defend(IGun gun)
        {
            gun.Shot();
        }
    }
}
