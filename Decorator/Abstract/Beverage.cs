namespace Decorator.Abstract
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}