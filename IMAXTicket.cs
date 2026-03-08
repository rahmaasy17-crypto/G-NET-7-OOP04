using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part2
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            Console.WriteLine( $" TicketId: #{TicketId} | Movie: {MovieName} | Price: {Price:F2} | Price After Tax: {PriceAfterTax:F2} EGP | 3D Movie: {(Is3D ? "Yes" : "No")}");
            
        }
    }
}
