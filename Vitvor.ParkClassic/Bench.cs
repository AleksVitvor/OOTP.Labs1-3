using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class Bench : IObject
    {
        public string Title { get; set; }
        public Bench(string name)
        {
            Title = name;
        }
        public void Draw()
        {
            Console.WriteLine("Нарисована скамейка");
        }
        public override string ToString()
        {
            return $"Скамейка {this.Title}";
        }
    }
}
