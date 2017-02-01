using MaindBoxDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDomain.Helpers
{
    public static class TicketSortManager
    {

        /// <summary>
        /// Сложность что-то вроде O(n) т.к. поиск в словаре O(1)
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static List<Ticket> Sort(List<Ticket> original)
        {

            Dictionary<string, Ticket> fromDic = original.ToDictionary(p => p.From);
            Dictionary<string, Ticket> toDic = original.ToDictionary(p => p.To);

            LinkedList<Ticket> ordered = new LinkedList<Ticket>();

            ordered.AddFirst(fromDic.First().Value);
        
            for (int i = 0; i < original.Count() - 1; i++)
            {
                Ticket left = ordered.First.Value;
                Ticket right = ordered.Last.Value;

                if (toDic.ContainsKey(left.From))
                {
                    Ticket L = toDic[left.From];
                    ordered.AddFirst(L);
                }


                if (fromDic.ContainsKey(right.To))
                {
                    Ticket R = fromDic[right.To];
                    ordered.AddLast(R);
                }

             
            }

            return ordered.ToList();

          
        }
    }
}
