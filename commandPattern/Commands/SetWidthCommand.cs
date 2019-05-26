using System;
using designPattern.Abstraction;
using designPattern.Receiver;

namespace designPattern.Commands {
    public class SetWidthCommand : ICommand {
        private readonly Rectangle _rectangle;
        private int _width;
        private int _oldValue;
        public SetWidthCommand (Rectangle rectangle, int width) {
            this._width = width;
            this._rectangle = rectangle;
        }
        public void Execute () {
            this._oldValue = _rectangle.Width;
            _rectangle.SetWidth(_width);
        }

        public void Undo()
        {
            this._width = _oldValue;
        }
    }
}