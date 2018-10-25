using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorythm
{
    static class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class OrderItem
    {
        public int OrderValue { get; set; }

        public string OrderName { get; set; }
    }

    public static class OrderHelper
    {
        public static int DivideRoundingUp(int x, int y)
        {
            int remainder;
            var quotient = Math.DivRem(x, y, out remainder);
            return remainder == 0 ? quotient : quotient + 1;
        }

        private const int StartingPoint = 5;

        public static OrderItem[] Reorder(IEnumerable<OrderItem> source, int oldPosition, int newPosition)
       {
           try
           {

               int newOrderValue;
               var orderItems = source as OrderItem[] ?? source.ToArray();

               if (orderItems[oldPosition].OrderValue > orderItems[newPosition].OrderValue)
               {
                   if (newPosition == 0)
                   {
                       newOrderValue = StartingPoint;
                       orderItems[oldPosition].OrderValue = newOrderValue;
                   }
                   else
                   {
                       newOrderValue = DivideRoundingUp(orderItems[newPosition].OrderValue + orderItems[newPosition - 1].OrderValue, 2);
                       orderItems[oldPosition].OrderValue = newOrderValue;
                   }

                   if (newOrderValue != orderItems[newPosition].OrderValue) return orderItems;

                   orderItems[newPosition].OrderValue++;

                   while (orderItems[newPosition + 1].OrderValue == orderItems[newPosition].OrderValue)
                   {
                       orderItems[newPosition + 1].OrderValue++;
                       newPosition++;
                   }

               }
               else if (orderItems[oldPosition].OrderValue < orderItems[newPosition].OrderValue)
               {
                   if (newPosition == orderItems.Length - 1)
                   {
                       orderItems[oldPosition].OrderValue = orderItems[newPosition].OrderValue + 1;
                   }
                   else
                   {
                       newOrderValue = DivideRoundingUp(orderItems[newPosition].OrderValue + orderItems[newPosition + 1].OrderValue, 2);
                       orderItems[oldPosition].OrderValue = newOrderValue;

                       if (newOrderValue != orderItems[newPosition + 1].OrderValue) return orderItems;
                       orderItems[newPosition + 1].OrderValue++;

                       if (newPosition + 1 == orderItems.Length - 1) return orderItems;

                       while (orderItems[newPosition + 1].OrderValue == orderItems[newPosition + 2].OrderValue)
                       {
                           orderItems[newPosition + 2].OrderValue++;
                           newPosition++;
                           if (newPosition == orderItems.Length - 2)
                           {
                               break;
                           }
                       }
                   }
               }

               return orderItems;
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
           return null;
        }
    }
}
