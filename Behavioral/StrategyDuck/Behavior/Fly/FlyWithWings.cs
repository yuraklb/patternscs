using System;

namespace StrategyDuck.Behavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FLY!!!");
        }
    }
}