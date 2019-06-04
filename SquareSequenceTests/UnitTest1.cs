using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareSequence_7;

namespace SquareSequenceTests
{
    //[TestInitialize] - execute method before each test

    [TestClass]
    public class SquareSequenceTests
    {
        [TestMethod]
        public void TestGetSequence_Input10_Return0123()
        {
            // arrange 
            int number = 10;
            ISequence sequence = new SquareSequence(number);

            //act
            IEnumerable<int> result = sequence.GetSequence();

            //assert
            CollectionAssert.AreEqual(result.ToList(), new List<int>{ 0, 1, 2, 3 });
        }

        [TestMethod]
        public void TestGetSequence_Input1_Return0()
        {
            // arrange 
            int number = 1;
            ISequence sequence = new SquareSequence(number);

            //act
            IEnumerable<int> result = sequence.GetSequence();
            
            //assert
            CollectionAssert.AreEqual(result.ToList(), new List<int> { 0 });
        }

        [TestMethod]
        public void TestGetSequence_Input0_ReturnError()
        {
            // arrange 
            int number = 0;

        }

        [TestMethod]
        public void TestGetSequence_InputMinus10_ReturnError()
        {
            // arrange 
            int number = 10;

            //act
            ISequence sequence = new SquareSequence(number);
            IEnumerable<int> result = sequence.GetSequence();
            List<int> l = new List<int>();
            foreach (int item in result)
            {
                l.Add(item);
            }

            //assert
            CollectionAssert.AreEqual(l, new List<int> { 0, 1 });
        }

        [TestMethod]
        public void TestGetStringResult_Input10_ReturnStr0123()
        {
            // arrange 
            int number = 10;
            List<int> l = new List<int>() { 0, 1, 2, 3 };
            ISequence sequence = new SquareSequence(number);

            //act
            string result = sequence.GetStringResult(l);
            
            //assert
            Assert.AreEqual(result, "0, 1, 2, 3");
        }

        [TestMethod]
        public void TestGetStringResult_Input1_ReturnStr0()
        {
            // arrange 
            int number = 10;
            List<int> l = new List<int>() { 0 };
            ISequence sequence = new SquareSequence(number);

            //act
            string result = sequence.GetStringResult(l);

            //assert
            Assert.AreEqual(result, "0");
        }
    }
}
