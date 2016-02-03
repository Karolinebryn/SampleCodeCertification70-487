using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfClient.CallbackExample.CalculatorService;

namespace WcfClient.CallbackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program.");
            // Construct InstanceContext to handle messages on callback interface
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            // Create a client
            Console.WriteLine("Creating client.");
            CalculatorDuplexClient client = new CalculatorDuplexClient(instanceContext);
            //perform operations
            Console.WriteLine("Adding 10");
            client.AddTo(10);
            Console.WriteLine("Substracting 2");
            client.SubtractFrom(2);
            Console.WriteLine("Multiplying by 100");
            client.MultiplyBy(100);
            Console.WriteLine("Dividing by 6");
            client.DivideBy(6);
            Console.WriteLine("Adding -89");
            client.AddTo(-89);

            Console.ReadLine();
        }
    }
}
