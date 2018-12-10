using System;
using StrategyDuck.Behavior;

namespace StrategyDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }
        
        public void display()
        {
            Console.WriteLine("Mallard duck");
        }
    }
}