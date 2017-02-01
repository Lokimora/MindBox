using MaindBoxDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDomain.Helpers
{
    public static class TicketHelper
    {
        const int MaxCount = 24;

        private static readonly List<string> Cities = new List<string>()
        {
            "Абакан", "Абу-Даби", "Баклажан", "Березки", "Воложки", "Вертуханы",
            "Геленджик", "Грибочки", "Деревня", "Дастан", "Драники", "Липецк",
            "Роттрдам", "Роснадзор", "Якутск", "Монако", "Пипецк", "Репа",
            "Шишки", "Челябинск", "Фонарр", "Местечко", "Оболенск", "Центр"
        };

        public static List<Ticket> GenerateTickets()
        {
            Random rnd = new Random();

            
            int count = Cities.Count() / 2;

            List< Ticket> tickets = new List<Ticket>();

            for(int i = 0; i < count - 2; i++)
            {
                var ticket = new Ticket(Cities[i], Cities[i + 1]);

                tickets.Add(ticket);
            }

            ShuffleTickets(tickets);

            return tickets;
        }

        public static void DisplayTickets(List<Ticket> tickets)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var v in tickets)
            {
                sb.AppendFormat($"{v.From} -> {v.To} \n");
            }

            Console.WriteLine(sb.ToString());
           
        }

        public static void ShuffleTickets(List<Ticket> tickets)
        {
            int n = tickets.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Ticket value = tickets[k];
                tickets[k] = tickets[n];
                tickets[n] = value;
            }
        }

        public static bool IsOrdered(Ticket[] tickets)
        {
            int count = tickets.Count();

            if (count < 2)
                return true;

            for(int i = 1; i < tickets.Count() - 1; i++)
            {

                if(String.Compare(tickets[i - 1].To, tickets[i].From, true) != 0)
                    return false;
  
            }

            return true;
        } 


    }
}
