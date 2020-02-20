using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Vitvor.ParkClassic
{
    [Serializable]
    class Grass:IPlant, IObject
    {
        public int height { get; set; }
        public string type { get; set; }
        public string Title { get; set; }

        public Grass()
        { }
        public Grass(int height, string type)
        {
            this.height = height;
            this.type = type;
            Title = type;
        }
        public IPlant Clone()
        {
            return new Grass(height, type);
        }

        public IPlant DeepClone()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream= new MemoryStream())
            {
                formatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;
                return (IPlant)formatter.Deserialize(memoryStream);
            }
        }

        public void Draw()
        {
            Console.WriteLine("Нарисована полянка");
        }
        public override string ToString()
        {
            return $"Полянка полная {this.Title}";
        }
    }
}
