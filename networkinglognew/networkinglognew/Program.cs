using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkinglognew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Networklog ReadNetworkData = new Networklog();
            ReadNetworkData.Networklogging();
            Console.ReadLine();

        }
    }
}
