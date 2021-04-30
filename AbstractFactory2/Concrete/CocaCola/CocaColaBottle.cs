using System;
using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.CocaCola
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater a)
        {
            Console.WriteLine(this + " interact " + a);
        }

        public override void Interact(AbstractCover a)
        {
            Console.WriteLine(this + " interact " + a);
        }
    }
}