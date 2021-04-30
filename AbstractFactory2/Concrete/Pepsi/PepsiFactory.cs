using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Pepsi
{
    public class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
    }
}