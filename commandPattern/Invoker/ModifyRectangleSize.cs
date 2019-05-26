using designPattern.Abstraction;

namespace designPattern.Invoker
{
    public class ModifyRectangleSize
    {
        private ICommand _command; 
        public void SetCommand(ICommand command) => _command = command;

        public void Invoke() => _command.Execute();
    }
}