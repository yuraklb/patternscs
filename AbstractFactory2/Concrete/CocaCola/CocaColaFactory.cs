using AbstractFactory2.Abstract;
using AbstractFactory2.Concrete.Pepsi;

namespace AbstractFactory2.Concrete.CocaCola
{
    public class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
    }
}