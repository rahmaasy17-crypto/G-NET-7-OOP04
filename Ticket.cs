using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Ticket
    {
        private static int totalTickets = 0;
        public string MovieName { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Price must be >= zero");
                price = value;
            }
        }
        public void SetPrice(decimal price) 
        {
            Console.WriteLine($"Setting price directly :{Price = price}");}
        public void SetPrice(decimal base_price, decimal multiplier) { 
            Console.WriteLine($"Setting price with multiplie :{base_price} x {multiplier} = {Price = base_price * multiplier}");
        }
   
        public int TicketId { get; }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            totalTickets++;
            TicketId = totalTickets;
        }

        public decimal PriceAfterTax => Price * 1.14m;
        public static int GetTotalTickets() => totalTickets;
        public virtual void PrintTicket()
        {
            Console.WriteLine( $"TicketId: #{TicketId} | Movie: {MovieName} | Price: {Price:F2} | Price After Tax: {PriceAfterTax:F2} EGP");
        }
    }
}

