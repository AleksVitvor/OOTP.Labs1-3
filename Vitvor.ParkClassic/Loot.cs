using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.ParkClassic
{
    abstract class Loot
    {
        public Loot(string Name, bool status)
        {
            this.Name = Name;
            Status = status;
        }
        public string Name { get; protected set; }
        public abstract int Count();
        public abstract bool Status { get; set; }
    }
    class chargeForPistol:Loot
    {
        public chargeForPistol():base("Патроны для пистолета", true)
        { }

        public override bool Status { get; set; }

        public override int Count()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }
    }
    class chargeForRifle : Loot
    {
        public chargeForRifle():base("Патроны для винтовки", true)
        { }
        public override bool Status { get; set; }
        public override int Count()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }
    }
    abstract class chargeDecorator:Loot
    {
        protected Loot loot;
        public chargeDecorator(string n, Loot loot):base(n, true)
        {
            this.loot = loot;
        }
    }
    class bigPackChargeForPistol:chargeDecorator
    {
        public bigPackChargeForPistol(Loot loot):base(loot.Name+", большой пак", loot)
        { }
        public override bool Status { get; set; }
        public override int Count()
        {
            return loot.Count() + 10;
        }
    }
    class bigPackChargeForRifle : chargeDecorator
    {
        public bigPackChargeForRifle(Loot loot) : base(loot.Name + ", большой пак", loot)
        { }
        public override bool Status { get; set; }
        public override int Count()
        {
            return loot.Count() + 5;
        }
    }
}
