using Decorator.Abstract;

namespace Decorator.Concrete.DecoratorItems
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return .40 + beverage.cost();
        }
        

    }
}