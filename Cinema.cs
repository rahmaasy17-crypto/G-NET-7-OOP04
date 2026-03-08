using ConsoleApp1.part2;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    class Cinema
    {
        public string CinemaName { get; set; }

        private Projector _projector;
        private Ticket[] _tickets;
        private int _ticketCount;

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;

            _projector = new Projector();

            _tickets = new Ticket[20];
            _ticketCount = 0;
        }

        public void AddTicket(Ticket t)
        {
            if (_ticketCount < 20)
            {
                _tickets[_ticketCount] = t;
                _ticketCount++;
            }
            else
                Console.WriteLine("Cinema is full");

        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < _ticketCount; i++)
            {
                _tickets[i].PrintTicket();
            }
        }

        public void OpenCinema()
        {
            _projector.StartProjector();
        }

        public void CloseCinema()
        {
            _projector.StopProjector();
        }
    }
}

