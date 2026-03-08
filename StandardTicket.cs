using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part2
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override void PrintTicket()
        {
            Console.WriteLine( $"TicketId: #{TicketId} | Movie: {MovieName} | Price: {Price:F2} | Price After Tax: {PriceAfterTax:F2} EGP | Seat Number: {SeatNumber}");
        }
    }
}