using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

// See https://aka.ms/new-console-template for more information


namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Timer myTimer = new Timer(1000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;
            myTimer.Start();

            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            
            Console.ReadLine();
        }
        
        private static void MyTimer_Elapsed1(Object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Elapsed1: {0:hh:mm:ss.ms.fff}",e.SignalTime);
        }
        private static void MyTimer_Elapsed(Object sender, ElapsedEventArgs e)
        {
           
            Console.WriteLine("Elapsed: {0:HH:mm:ss.zzz}",e.SignalTime);
        }
       

    }
}

