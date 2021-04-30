using Command.ConcreteCommands;

namespace Command
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();

            LightOnCommand lightOn = new LightOnCommand(light);
            
            remote.setCommand(lightOn);
            remote.buttonWasPressed();
        }
    }
}