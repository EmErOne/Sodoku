using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodoku.Core.Models;
using Sodoku.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Sodoku.Core.Test
{
    [TestClass]
    public class MatchfieldStoreServiceTest
    {
        Matchfield matchfield = null;
        string tempPath = null;

        [TestCleanup]
        public void After()
        {
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }

        [TestInitialize]
        public void Init()
        {
            tempPath = Path.GetTempFileName();

            Square[] squares = new Square[9];

            Square squareA = new Square();
            squareA.Set(new[] { 5, 3, 4, 6, 7, 2, 1, 9, 8 });
            squares[0] = squareA;

            Square squareB = new Square();
            squareB.Set(new[] { 6, 7, 8, 1, 9, 5, 3, 4, 2 });
            squares[1] = squareB;

            Square squareC = new Square();
            squareC.Set(new[] { 9, 1, 2, 3, 4, 8, 5, 6, 7 });
            squares[2] = squareC;

            Square squareD = new Square();
            squareD.Set(new[] { 8, 5, 9, 4, 2, 6, 7, 1, 3 });
            squares[3] = squareD;

            Square squareE = new Square();
            squareE.Set(new[] { 7, 6, 1, 8, 5, 3, 9, 2, 4 });
            squares[4] = squareE;

            Square squareF = new Square();
            squareF.Set(new[] { 4, 2, 3, 7, 9, 1, 8, 5, 6 });
            squares[5] = squareF;

            Square squareG = new Square();
            squareG.Set(new[] { 9, 6, 1, 2, 8, 7, 3, 4, 5 });
            squares[6] = squareG;

            Square squareH = new Square();
            squareH.Set(new[] { 5, 3, 7, 4, 1, 9, 2, 8, 6 });
            squares[7] = squareH;

            Square squareI = new Square();
            squareI.Set(new[] { 2, 8, 4, 6, 3, 5, 1, 7, 9 });
            squares[8] = squareI;


            matchfield = new Matchfield(squares);
        }

        [TestMethod]
        public void TestSerialize()
        {
            int[] expectedArray = new int[] { 5, 3, 4, 6, 7, 2, 1, 9, 8, 6, 7, 8, 1, 9, 5, 3, 4, 2, 9, 1, 2, 3, 4, 8, 5, 6, 7, 8, 5, 9, 4, 2, 6, 7, 1, 3, 7, 6, 1, 8, 5, 3, 9, 2, 4, 4, 2, 3, 7, 9, 1, 8, 5, 6, 9, 6, 1, 2, 8, 7, 3, 4, 5, 5, 3, 7, 4, 1, 9, 2, 8, 6, 2, 8, 4, 6, 3, 5, 1, 7, 9 };
            string expected = "534672198678195342912348567859426713761853924423791856961287345537419286284635179";

            MatchfieldStoreService matchfieldStoreService = new MatchfieldStoreService(tempPath);

            Type type = matchfieldStoreService.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            MethodInfo method = type.GetMethod("Serialize", bindingAttr);
            var actual = (string)method.Invoke(matchfieldStoreService, new object[] { matchfield });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeserialize()
        {
            string data = "534672198678195342912348567859426713761853924423791856961287345537419286284635179";

            MatchfieldStoreService matchfieldStoreService = new MatchfieldStoreService(tempPath);

            Type type = matchfieldStoreService.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            MethodInfo method = type.GetMethod("Deserialize", bindingAttr);
            var squares = (Square[])method.Invoke(matchfieldStoreService, new object[] { data });

            Matchfield tempMatchfield = new Matchfield(squares);

            Assert.AreEqual(9, squares.Length);


            method = type.GetMethod("Serialize", bindingAttr);
            var actual = (string)method.Invoke(matchfieldStoreService, new object[] { tempMatchfield });

            Assert.AreEqual(data, actual);
        }
    }
}


