using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICAPNameSpace.ICAP icap = new ICAPNameSpace.ICAP("192.168.1.5",1344,"avscan");


            String[] files = new String[]{
                @"C:\Users\Neel\ScanFolder\Test.txt"
            };

            foreach (String file in files)
            {
                try
                {
                    Console.Write(file + ": ");
                    bool result = icap.scanFile(file);
                    Console.Write(result + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not scan file " + file + ":" + ex);
                }
            }

            System.Threading.Thread.Sleep(1000);
        }
    }
}
