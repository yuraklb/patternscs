namespace Command
{
    public class SimpleRemoteControl
    {
        private Interfaces.Command slot;

        public SimpleRemoteControl()
        {
        }

        public void setCommand(Interfaces.Command command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }

    }
}