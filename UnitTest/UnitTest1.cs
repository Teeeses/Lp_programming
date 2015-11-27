using System;
using Lp_programming;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Data data = new Data();
            data.numberVariables = 5;
            data.numberLimit = 3;
            
            data.table = new List<List<double>> {
                new List<double> {0, 1, 2, 3, 4, 5, 0},
                new List<double> {6, 0, 10, 1, 2, 3, 25},
                new List<double> {7, -1, 5, 1, 1, 1, 10},
                new List<double> {8, 2, -1, 1, -3, 0, 6},
                new List<double> {0, -1, -14, -3, 0, -4, -41},
            };
            BasisAlgoritm alg = new BasisAlgoritm(data);
            alg.bearing = 5;
            alg.bearingX = 2;
            alg.bearingY = 2;
            List<List<double>> temp = alg.conversionRowCol();
            CollectionAssert.AreEqual(new List<List<double>> {
                new List<double> {0, 1, 2, 3, 4, 5, 0},
                new List<double> {6, 0, -2, 1, 2, 3, 25},
                new List<double> {7, -0.2, 0.2, 0.2, 0.2, 0.2, 2},
                new List<double> {8, 2, 0.2, 1, -3, 0, 6},
                new List<double> {0, -1, 14/5, -3, 0, -4, -41},
            }, temp);
        }
    }
}
