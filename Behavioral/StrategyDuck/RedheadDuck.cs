using System;
using StrategyDuck.Behavior;

namespace StrategyDuck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }
        
        public void display()
        {
            Console.WriteLine("Redhead duck");
        }
    }
}