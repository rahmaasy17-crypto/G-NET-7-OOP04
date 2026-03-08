using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part2
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;
        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price + 50m)
        {
            LoungeAccess = loungeAccess;

        }

        public override void PrintTicket()
        {
            Console.WriteLine( $"TicketId: #{TicketId} | Movie: {MovieName} | Price: {Price:F2} | Price After Tax: {PriceAfterTax:F2} EGP  | Lounge Access: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee}");
        }
    }

}