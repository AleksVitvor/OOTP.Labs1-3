using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class Lane : IObject
    {
        public string Title { get; set; }
        public Lane(string name)
        {
            Title = name;
        }
        public void Draw()
        {
            Console.WriteLine("Нарисована дорожка");
        }
        public override string ToString()
        {
            return $"Тропинка: {this.Title}";
        }
    }
}
