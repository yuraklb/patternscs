namespace Command.ConcreteCommands
{
    public class LightOnCommand : Interfaces.Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.On();
        }
    }
}