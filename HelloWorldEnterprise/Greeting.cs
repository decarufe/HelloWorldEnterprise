using System;

namespace HelloWorldEnterprise
{
    public class Greeting
    {
        private readonly IRecevier _recevier;

        public Greeting(IRecevier recevier)
        {
            _recevier = recevier;
        }

        public void SayHello(string name)
        {
            _recevier.ReceiveMessage($"Hello {name}!");
        }
    }
}