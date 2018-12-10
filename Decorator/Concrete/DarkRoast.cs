using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double cost()
        {
            return 2.99;
        }
    }
}