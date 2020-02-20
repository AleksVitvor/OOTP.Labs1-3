using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    class ParkBuilder : IParkBuilder, IObject
    {
        private readonly List<IObject> objects = new List<IObject>();
        public int countOfObjects { get; private set; } = 0;
        public string Title { get; set; }
        public ParkBuilder(string name)
        {
            Title = name;
        }
        public void AddBench()
        {
            countOfObjects++;
            objects.Add(new Bench("Лавочка за углом"));
        }

        public void AddGrass()
        {
            countOfObjects++;
            objects.Add(new Grass(150,"Крапива"));
        }

        public void AddLane()
        {
            countOfObjects++;
            objects.Add(new Lane("аллея выпускников"));
        }

        public void AddTree()
        {
            countOfObjects++;
            objects.Add(new Tree(15, "Клён"));
        }

        public void Draw()
        {
            foreach (var i in objects)
                i.Draw();
        }
        public IObject Find(string title)
        {
            return objects.Find(u => u.Title == title);
        }

        public IParkBuilder GetResult()
        {
            return this;
        }
    }
}
