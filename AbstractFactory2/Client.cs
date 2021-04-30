using AbstractFactory2.Abstract;

namespace AbstractFactory2
{
    public class Client
    {
        private AbstractBottle bottle;
        private AbstractWater water;
        private AbstractCover cover; 
        
        public Client(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            bottle.Interact(cover);
        }
    }
}