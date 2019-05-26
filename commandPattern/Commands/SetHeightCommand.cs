using System;
using designPattern.Abstraction;
using designPattern.Receiver;

namespace designPattern.Commands {
    public class SetHeightCommand : ICommand {
        private readonly Rectangle _rectangle;
        private int _height;
        private int _oldValue;
        public SetHeightCommand (Rectangle rectangle, int height) {
            this._height = height;
            this._rectangle = rectangle;
            
        }
        public void Execute()
        {
            this._oldValue = _rectangle.Height;
            _rectangle.SetHeight(_height);
        }

        public void Undo()
        {
           this._height = _oldValue;
        }
    }
}