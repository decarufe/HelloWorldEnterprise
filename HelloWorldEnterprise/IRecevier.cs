using System;

namespace HelloWorldEnterprise
{
    public interface IRecevier
    {
        void ReceiveMessage(string message);
    }

    class ConsoleRecevier : IRecevier
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}