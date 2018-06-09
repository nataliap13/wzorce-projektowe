using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFactoryMethod
{
    public abstract class Sandwich
    {
        public abstract double GetPrice();

        public enum SandwichType { Ham, Cheese }
        public static Sandwich SandwichFactory(SandwichType SandwichType_)
        {
            switch (SandwichType_)
            {
                case SandwichType.Ham:
                    return new HamSandwich();

                case SandwichType.Cheese:
                    return new CheeseSandwich();

                default:
                    break;
            }

            throw new System.NotSupportedException("The Sandwich type " + SandwichType_.ToString() + " is not recognized.");
        }
    }

    public class HamSandwich : Sandwich
    {
        private double price = 7.5;
        public override double GetPrice() { return price; }
    }

    public class CheeseSandwich : Sandwich
    {
        private double price = 6;
        public override double GetPrice() { return price; }
    }
}
