
using System;
namespace lab1Jenia
{
    public class RedInterface : IConsoleInterface
    {
        public RedInterface() {}

        public ConsoleColor BackGroundColor { get => ConsoleColor.Red; set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.Clear();
            Console.BackgroundColor = BackGroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

    public class BlueInterface : IConsoleInterface
    {


        public ConsoleColor BackGroundColor { get => ConsoleColor.Blue; set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.Clear();
            Console.BackgroundColor = BackGroundColor;
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}
