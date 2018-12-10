using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double cost()
        {
            return 3.99;
        }
    }
}