using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IGun
    {
        void Shot();
    }
    class Pistol : IGun
    {
        public int Charge { get; set; } = 7;
        public void Shot()
        {
            Console.WriteLine("Выстрел с пистолета");
        }
    }
}
