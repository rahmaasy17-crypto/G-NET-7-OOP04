using ConsoleApp1.part2;
using System;
using System.Buffers.Text;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1
{
    #region  Part 01 
    #region Q1

    // Static Binding called Early Binding  happened at Compile-Time that Look at the Variable type and Compile decides which be method will called based on the method signature
    //[happened in Method Overloading, Operators Overloading and Method Hiding]

    //  Dynamic Binding called Late Binding happened at Run-Time that Look at the Object type and CLR decides which method will be called[happened at
    //Method Overriding, Abstract Method and Interface Implementation
    #endregion
    #region Q2
//    :  method overloading doesn't need inheritance , doing Same method name with different parameter lists within the same class
// Resolved at compile time

// method overriding happened in inheritance, Derived class overrides a method from the base class using the override keyword ,inherit
//method  but change behavior
    #endregion
    #region Q3
    //        : Derived class overrides using override keyword and virtual keyword in the base class method
    //virtual keyword:  Used in the base class and mean that base allow overridden in derived classes[change behavior]
    //override keyword: Used in the derived class and Provides a new implementation of the base class method
    #endregion
    #endregion
    internal class Program
    {
        public static void ProcessTicket(Ticket t)
        {
            if (t == null) Console.WriteLine( "Please Add Valid Ticket");
             t.PrintTicket();
        }
        static void Main(string[] args)
        {


            #region Part02 

            //a:
            Cinema cinema = new Cinema("City Cinema");
            cinema.OpenCinema();
            Console.WriteLine();

            //b:
            StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", 150, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);


            //c: //overloding
            Console.WriteLine("==========Set Price Test==========");
            t1.SetPrice(120);
            t1.SetPrice(120, 2);
            Console.WriteLine();

            //d:
            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);
            Console.WriteLine("==========ALL Tickets==========");
            cinema.PrintAllTickets();
            Console.WriteLine();

            //e:
            Console.WriteLine("==========Process Single Ticket==========");
            ProcessTicket(t2);
            //f:
            Console.WriteLine();
            cinema.CloseCinema();

            #endregion
        }
    }
}
