using designPattern.Abstraction;
using designPattern.Receiver;

namespace designPattern.Commands {
    public class SetHeightCommand : ICommand {
        private readonly Rectangle _rectangle;
        private readonly int _height;
        public SetHeightCommand (Rectangle rectangle, int height) {
            this._height = height;
            this._rectangle = rectangle;
        }
        public void Execute() => _rectangle.SetHeight(_height);
    }
}