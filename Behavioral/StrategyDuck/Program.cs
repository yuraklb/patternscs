using System;
using StrategyDuck.Behavior;

namespace StrategyDuck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var mallardDuck = new MallardDuck();
            mallardDuck.display();
            mallardDuck.performFly();
            mallardDuck.performQuack();
            
            var redheadDuck = new RedheadDuck();
            redheadDuck.display();
            redheadDuck.performFly();
            redheadDuck.performQuack();
            
            var rubberDuck = new RubberDuck();
            rubberDuck.display();
            rubberDuck.performFly();
            rubberDuck.performQuack();
            
            
            rubberDuck.display();
            rubberDuck.SetFlyBehavior(new FlyWithWings());
            rubberDuck.performFly();
            rubberDuck.performQuack();

        }
    }
}