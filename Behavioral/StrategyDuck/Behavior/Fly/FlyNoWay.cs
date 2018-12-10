using System;

namespace StrategyDuck.Behavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("NOFLY");
        }
    }
}