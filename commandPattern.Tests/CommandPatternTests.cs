using System;
using designPattern.Commands;
using designPattern.Invoker;
using designPattern.Receiver;
using Xunit;

namespace commandPattern.Tests
{
    public class commandPatternTests
    {
        private readonly ModifyRectangleSize _invoker;

        public commandPatternTests()
        {
            _invoker = new ModifyRectangleSize();
        }
        [Fact]
        public void MultipleCommandInvoke_ShouldSetCorrectValue()
        {
            var rectangle = new Rectangle();

            var setHeight20Command = new SetHeightCommand(rectangle, 20);
            var setHeight30Command = new SetHeightCommand(rectangle, 30);
            var setWidth20Command = new SetWidthCommand(rectangle, 20);

            _invoker.SetCommand(setHeight20Command);
            _invoker.Invoke();
            _invoker.SetCommand(setWidth20Command);
            _invoker.Invoke();
            _invoker.SetCommand(setHeight30Command);
            _invoker.Invoke();

            Assert.Equal(30, rectangle.Height);
            Assert.Equal(20, rectangle.Width);
        }

        [Fact]
        public void WidthUndo_ShouldUndoLastCommand()
        {
            var rectangle = new Rectangle();
            var setWidth20Command = new SetWidthCommand(rectangle, 20);
            var setWidth30Command = new SetWidthCommand(rectangle, 30);


            _invoker.SetCommand(setWidth20Command);
            _invoker.Invoke();
            _invoker.SetCommand(setWidth30Command);
            _invoker.Invoke();

            Assert.Equal(30, rectangle.Width);

            setWidth30Command.Undo();
            _invoker.Invoke();

            Assert.Equal(20, rectangle.Width);
        }

         [Fact]
        public void HeightUndo_ShouldUndoLastCommand()
        {
            var rectangle = new Rectangle();
            var setHeight20Command = new SetHeightCommand(rectangle, 20);
            var setHeight30Command = new SetHeightCommand(rectangle, 30);

            _invoker.SetCommand(setHeight20Command);
            _invoker.Invoke();
            _invoker.SetCommand(setHeight30Command);
            _invoker.Invoke();

            Assert.Equal(30, rectangle.Height);

            setHeight30Command.Undo();
            _invoker.Invoke();

            Assert.Equal(20, rectangle.Height);
        }
    }
}
