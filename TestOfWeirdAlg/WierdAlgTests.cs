using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorythm;
using System.Linq;

namespace TestOfWeirdAlg
{
    [TestClass]
    public class WierdAlgTests
    {
        #region InsertDown

        [TestMethod]
        public void TestMethodForSwappingFirstTwoElements()
        {
            //Arrange

            #region TestData
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

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 0, 1).OrderBy(x => x.OrderValue).Select(x => x.OrderName).ToArray();

            //Act

            #region ResultData

            var resultArray = new List<OrderItem>()
            {
                new OrderItem()
                {
                    OrderName = "I2",
                    OrderValue = 6
                },
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 7
                },
                new OrderItem()
                {
                    OrderName = "I3",
                    OrderValue = 8
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 9
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 10
                },
                new OrderItem()
                {
                    OrderName = "I6",
                    OrderValue = 11
                }
            }.Select(x => x.OrderName).ToArray();


            #endregion

            CollectionAssert.AreEqual(resultArray, newList);
        }

        [TestMethod]
        public void TestMethodForFirstAndLastElements()
        {
            //Arrange

            #region TestData
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

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 0, inputList1.Count - 1).OrderBy(x => x.OrderValue).Select(x => x.OrderName).ToArray();

            //Act

            #region ResultData

            var resultArray = new List<OrderItem>()
            {
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
                },
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 11
                }
            }.Select(x => x.OrderName).ToArray();


            #endregion

            CollectionAssert.AreEqual(resultArray, newList);
        }

        [TestMethod]
        public void TestMethodForInsertingToMiddleElement()
        {
            //Arrange

            #region TestData
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

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 0, 2).OrderBy(x => x.OrderValue).Select(x => x.OrderName).ToArray();

            //Act

            #region ResultData

            var resultArray = new List<OrderItem>()
            {
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
                    OrderName = "I1",
                    OrderValue = 8
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 9
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 10
                },
                new OrderItem()
                {
                    OrderName = "I6",
                    OrderValue = 11
                }
            }.Select(x => x.OrderName).ToArray();


            #endregion

            CollectionAssert.AreEqual(resultArray, newList);
        }

        #endregion

        #region InsertUp
        [TestMethod]
        public void TestMethodForInsertingToMiddleElementUp()
        {
            //Arrange

            #region TestData
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

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 4, 1).OrderBy(x => x.OrderValue).Select(x => x.OrderName).ToArray();

            //Act

            #region ResultData

            var resultArray = new List<OrderItem>()
            {
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 5
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 6
                },
                new OrderItem()
                {
                    OrderName = "I2",
                    OrderValue = 7
                },
                new OrderItem()
                {
                    OrderName = "I3",
                    OrderValue = 8
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 9
                },
                new OrderItem()
                {
                    OrderName = "I6",
                    OrderValue = 10
                }
            }.Select(x => x.OrderName).ToArray();


            #endregion

            CollectionAssert.AreEqual(resultArray, newList);

        }

        [TestMethod]
        public void TestMethodForInsertingToTheEnd()
        {
            //Arrange

            #region TestData
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

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 3, 0).OrderBy(x => x.OrderValue).Select(x => x.OrderName).ToArray();

            //Act

            #region ResultData

            var resultArray = new List<OrderItem>()
            {
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 5
                },
                new OrderItem()
                {
                    OrderName = "I1",
                    OrderValue = 6
                },
                new OrderItem()
                {
                    OrderName = "I2",
                    OrderValue = 7
                },
                new OrderItem()
                {
                    OrderName = "I3",
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
            }.Select(x => x.OrderName).ToArray();


            #endregion

            CollectionAssert.AreEqual(resultArray, newList);

        }

        #endregion

        [TestMethod]
        public void TestMethodForInsertingRandom()
        {
            //Arrange

            #region TestData
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
                    OrderValue = 10
                },
                new OrderItem()
                {
                    OrderName = "I3",
                    OrderValue = 15
                },
                new OrderItem()
                {
                    OrderName = "I4",
                    OrderValue = 20
                },
                new OrderItem()
                {
                    OrderName = "I5",
                    OrderValue = 25
                },
                new OrderItem()
                {
                    OrderName = "I6",
                    OrderValue = 30
                }
            };

            #endregion

            //Assert

            var newList = OrderHelper.Reorder(inputList1, 4, 5).OrderBy(x => x.OrderValue).Select(x => new
            {
                x.OrderName,
                x.OrderValue
            }).ToArray();

        }
    }
}
