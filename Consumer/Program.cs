using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vi kan lave et ny service, som vi så kan kalde de metoder vi har fra.  
            using (var client = new ServiceReference.Service1Client())
            {
                Console.WriteLine(client.getMyEmail());
                Console.WriteLine((client.getMyName()));
            }
            Console.ReadLine();
        }
    }
}
