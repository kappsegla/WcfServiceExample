using ServiceClientConsole.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            // Använd klientvariabeln för att anropa åtgärder i den här tjänsten.
            Console.WriteLine(client.GetData(1));

            // Stäng alltid klienten.
            client.Close();

        }
    }
}