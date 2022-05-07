using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeWifiApi
{
    class Program
    {
        static void Main(string[] args)
        {
            platformInvoke.wifi wifiAPI = new platformInvoke.wifi();
            wifiAPI.EnumerateNICs();
            Console.ReadLine();
        }
    }

}

