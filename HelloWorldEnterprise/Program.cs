using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            var gretting = new Greeting(new ConsoleRecevier());
            gretting.SayHello("World");
        }
    }
}
