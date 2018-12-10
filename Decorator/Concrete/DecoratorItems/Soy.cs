using Decorator.Abstract;

namespace Decorator.Concrete.DecoratorItems
{
    public class Soy : CondimentDecorator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return .30 + beverage.cost();
        }
        

    }
}