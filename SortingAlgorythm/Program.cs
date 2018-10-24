using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorythm
{
    static class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<OrderItem>()
            {
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 1
                },
                new OrderItem()
                {
                    OrderName = "I2",
                    OrderValue = 5
                },
                new OrderItem()
                {
                    OrderName = "I3",
                    OrderValue = 10
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 20
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 30
                }
            };

            var inputList1 = new List<OrderItem>()
            {
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 5
                },
                new OrderItem()
                {
                    OrderName = "I2",
                    OrderValue = 6
                },
                new OrderItem()
                {
                    OrderName = "I3",
                    OrderValue = 7
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 8
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 9
                },
                new OrderItem()
                {
                    OrderName = "I6",
                    OrderValue = 10
                }
            };

            var newList = OrderHelper.Reorder(inputList1, 0, 1).OrderBy(x => x.OrderValue).ToArray();

            Console.WriteLine("Test");
            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine($"{newList[i].OrderValue} {newList[i].OrderName}");  
            }


            Console.ReadLine();
        }
    }

    public class OrderItem
    {
        public double OrderValue { get; set; }

        public string OrderName { get; set; }

        public static bool operator > (OrderItem oldItem, OrderItem newItem)
        {
            return oldItem.OrderValue > newItem.OrderValue;
        }

        public static bool operator <(OrderItem oldItem, OrderItem newItem)
        {
            return oldItem.OrderValue < newItem.OrderValue;
        }

        public static double operator + (OrderItem oldItem, OrderItem newItem)
        {
            return oldItem.OrderValue + newItem.OrderValue;
        }
    }




    public static class OrderHelper
    {
        private const int StartingPoint = 5;

        public static OrderItem[] Reorder(IEnumerable<OrderItem> source, int oldPosition, int newPosition)
       {
           double newOrderValue;
            var orderItems = source as OrderItem[] ?? source.ToArray();
            if (orderItems[oldPosition] > orderItems[newPosition])
            {
                if (newPosition == 0)
                {
                    newOrderValue = StartingPoint;
                    orderItems[oldPosition].OrderValue = newOrderValue;
                } else {
                    newOrderValue = Math.Ceiling((orderItems[newPosition] + orderItems[newPosition - 1]) / 2);
                    orderItems[oldPosition].OrderValue = newOrderValue;
                }

                if (newOrderValue == orderItems[newPosition].OrderValue)
                {
                    orderItems[newPosition].OrderValue++;
                    while (orderItems[newPosition + 1].OrderValue == orderItems[newPosition].OrderValue)
                    {
                        orderItems[newPosition + 1].OrderValue++;
                        newPosition++;
                    }
                }
               
            } else if (orderItems[oldPosition] < orderItems[newPosition]) {

                //end
                if (newPosition == orderItems.Length - 1)
                {
                    orderItems[oldPosition].OrderValue = orderItems[newPosition].OrderValue + 1;
                }
                else
                {
                    newOrderValue = Math.Ceiling((orderItems[newPosition] + orderItems[newPosition + 1]) / 2);
                    orderItems[oldPosition].OrderValue = newOrderValue;
                    if (newOrderValue == orderItems[newPosition + 1].OrderValue)
                    {
                        orderItems[newPosition + 1].OrderValue++;
                        if (newPosition + 1 != orderItems.Length - 1)
                        {
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
                }       
            }

           return orderItems;
       }
    }
}
