using System;
using StrategyDuck.Behavior;

namespace StrategyDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public void performQuack()
        {
            _quackBehavior.quack();
        }

        public void performFly()
        {
            _flyBehavior.fly();
        }
        
        public void display()
        {
            Console.WriteLine("BASE duck");
        }

        public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            _flyBehavior = newFlyBehavior;
        }
        
        public void SetQuackBehavior(IQuackBehavior newQuackBehavior)
        {
            _quackBehavior = newQuackBehavior;
        }
    }
}