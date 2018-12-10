using System;
using StrategyDuck.Behavior;

namespace StrategyDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }
        
        public void display()
        {
            Console.WriteLine("Rubber duck");
        }
        
    }
}