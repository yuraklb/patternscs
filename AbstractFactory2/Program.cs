using AbstractFactory2.Concrete.CocaCola;
using AbstractFactory2.Concrete.Pepsi;

namespace AbstractFactory2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client client = null;
            
            client = new Client(new CocaColaFactory());
            client.Run();
            
            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}