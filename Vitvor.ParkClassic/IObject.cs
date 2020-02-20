using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    interface IObject
    {
        string Title { get; set; }
        void Draw();
    }
}
