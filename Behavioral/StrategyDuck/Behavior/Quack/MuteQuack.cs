using System;

namespace StrategyDuck.Behavior
{
    public class MuteQuack: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Mute");
        }
    }
}