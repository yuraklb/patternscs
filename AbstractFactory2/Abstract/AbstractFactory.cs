namespace AbstractFactory2.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
        public abstract AbstractCover CreateCover();
    }
}