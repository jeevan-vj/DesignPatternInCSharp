using designPattern.Abstraction;
using designPattern.Receiver;

namespace designPattern.Commands {
    public class SetWidthCommand : ICommand {
        private readonly Rectangle _rectangle;
        private readonly int _width;
        public SetWidthCommand (Rectangle rectangle, int width) {
            this._width = width;
            this._rectangle = rectangle;
        }
        public void Execute () {
            _rectangle.SetWidth(_width);
        }
    }
}