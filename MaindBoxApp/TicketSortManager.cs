using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaindBoxApp
{
    public static class TicketSortManager
    {
        public static List<Ticket> StupidSort(List<Ticket> original)
        {
            Ticket[] sorted = original.ToArray();
            int len = sorted.Length;
            int c = sorted.Count();

            for(int i = 0; i < sorted.Length - 2; i++)
            {
                for(int j = i + 1; j < sorted.Length - 2; j++)
                {
                    Ticket temp = sorted[i];
                   
                    if(temp.From == sorted[j].To)
                    {
                        sorted[i] = sorted[j];
                        sorted[j] = temp;
                    }

                }
            }

           

            return sorted.ToList();
        }
    }
}
