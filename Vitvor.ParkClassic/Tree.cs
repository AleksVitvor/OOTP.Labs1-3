using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Vitvor.ParkClassic
{
    [Serializable]
    class Tree:IPlant, IObject
    {
        public int height { get; set; }
        public string type { get; set; }
        public string Title { get; set; }

        public Tree()
        { }
        public Tree(int height, string type)
        {
            this.height = height;
            this.type = type;
            Title = type;
        }
        public IPlant Clone()
        {
            return new Tree(height, type);
        }

        public IPlant DeepClone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;
                return (IPlant)formatter.Deserialize(memoryStream);
            }
        }

        public void Draw()
        {
            Console.WriteLine("Нарисовано дерево");
        }
        public override string ToString()
        {
            return $"Дерево {this.Title}";
        }

    }
}
