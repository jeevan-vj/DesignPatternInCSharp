using System;
using designPattern.Commands;
using designPattern.Invoker;
using designPattern.Receiver;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new ModifyRectangleSize();
            var rectangle = new Rectangle();

            var setHeight20Command = new SetHeightCommand(rectangle, 20);
            var setHeight30Command = new SetHeightCommand(rectangle, 30);
            var setWidth20Command = new SetWidthCommand(rectangle, 20);

            invoker.SetCommand(setHeight20Command);
            invoker.Invoke();
            invoker.SetCommand(setWidth20Command);
            invoker.Invoke();
            invoker.SetCommand(setHeight30Command);
            invoker.Invoke();
            
            Console.ReadLine();
        }
    }
}
