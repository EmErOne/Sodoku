using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodoku.Core.Exceptions;
using Sodoku.Core.Helper;
using Sodoku.Core.Models;
using Sodoku.Core.Service;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sodoku.Core.Test
{
    [TestClass]
    public class SquareHelperTest
    {
        [TestMethod]
        public void TestGenerateInitSqare()
        {
            Square square = SquareHelper.GenerateInitSqare();
            Assert.IsTrue(square.IsCorrectly());
        }

        [TestMethod]
        public void TestGenerateSqareB()
        {
            Square squareA = SquareHelper.GenerateInitSqare();

            Square[] squares = new Square[] { squareA };
            Square squareB = SquareHelper.GenerateMatchfieldRow1(squares);

            Assert.IsTrue(squareB.IsCorrectly());

            List<int> row1 = new List<int>();
            row1.AddRange(squareA.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareB.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareA.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareB.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareA.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareB.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);
        }

        [TestMethod]
        public void TestGenerateSqareC()
        {
            Square squareA = SquareHelper.GenerateInitSqare();

            squareA.Set(new int[] { 5, 3, 4,
                                    6, 7, 2,
                                    1, 9, 8 });

            Square squareB = SquareHelper.GenerateInitSqare();

            squareB.Set(new int[] { 6, 7, 8,
                                    1, 9, 5,
                                    3, 4, 2 });

            Square[] squares = new Square[] { squareA, squareB };

            Square squareC = SquareHelper.GenerateMatchfieldRow1(squares);

            Assert.IsTrue(squareC.IsCorrectly());

            List<int> row1 = new List<int>();
            row1.AddRange(squareA.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareB.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareC.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareA.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareB.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareC.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareA.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareB.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareC.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);
        }

        [TestMethod]
        public void TestGenerateSqareD()
        {
            Square squareA = SquareHelper.GenerateInitSqare();

            squareA.Set(new int[] { 5, 3, 4,
                                    6, 7, 2,
                                    1, 9, 8 });



            Square[] squares = new Square[] { squareA };

            Square squareD = SquareHelper.GenerateMatchfieldColumn1(squares);

            Assert.IsTrue(squareD.IsCorrectly());

            List<int> column1 = new List<int>();
            column1.AddRange(squareA.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareD.GetColumnNumbers(SquareColumn.Column1));
            int count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareA.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareD.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareA.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareD.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

        }

        [TestMethod]
        public void TestGenerateSqareG()
        {
            Square squareA = SquareHelper.GenerateInitSqare();

            squareA.Set(new int[] { 5, 3, 4,
                                    6, 7, 2,
                                    1, 9, 8 });

            Square squareD = new Square();

            squareD.Set(new int[] { 8, 5, 9,
                                    4, 2, 6,
                                    7, 1, 3 });

            Square[] squares = new Square[] { squareA, squareD };

            Square squareG = SquareHelper.GenerateMatchfieldColumn1(squares);

            Assert.IsTrue(squareG.IsCorrectly());

            List<int> column1 = new List<int>();
            column1.AddRange(squareA.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareD.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareG.GetColumnNumbers(SquareColumn.Column1));
            int count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareA.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareD.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareG.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareA.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareD.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareG.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

        }

        [TestMethod]
        public void TestGenerateSqareE()
        {
            Square squareA = SquareHelper.GenerateInitSqare();
            Square[] squares = new Square[] { squareA };
            Square squareB = SquareHelper.GenerateMatchfieldRow1(squares);
            Square squareD = SquareHelper.GenerateMatchfieldColumn1(squares);

            squares = new Square[] { squareA, squareB };
            Square squareC = SquareHelper.GenerateMatchfieldRow1(squares);

            squares = new Square[] { squareA, squareD };
            Square squareG = SquareHelper.GenerateMatchfieldColumn1(squares);

            Square[] rows = new Square[] { squareD };
            Square[] columns = new Square[] { squareB };
            Square squareE = SquareHelper.GenerateSqare(rows, columns);

            Assert.IsTrue(squareE.IsCorrectly());

            Trace.WriteLine($"{squareA.Get(SquarePlace.A)} {squareA.Get(SquarePlace.B)} {squareA.Get(SquarePlace.C)} | {squareB.Get(SquarePlace.A)} {squareB.Get(SquarePlace.B)} {squareB.Get(SquarePlace.C)} | {squareC.Get(SquarePlace.A)} {squareC.Get(SquarePlace.B)} {squareC.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.D)} {squareA.Get(SquarePlace.E)} {squareA.Get(SquarePlace.F)} | {squareB.Get(SquarePlace.D)} {squareB.Get(SquarePlace.E)} {squareB.Get(SquarePlace.F)} | {squareC.Get(SquarePlace.D)} {squareC.Get(SquarePlace.E)} {squareC.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.G)} {squareA.Get(SquarePlace.H)} {squareA.Get(SquarePlace.I)} | {squareB.Get(SquarePlace.G)} {squareB.Get(SquarePlace.H)} {squareB.Get(SquarePlace.I)} | {squareC.Get(SquarePlace.G)} {squareC.Get(SquarePlace.H)} {squareC.Get(SquarePlace.I)}");
            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareD.Get(SquarePlace.A)} {squareD.Get(SquarePlace.B)} {squareD.Get(SquarePlace.C)} | {squareE.Get(SquarePlace.A)} {squareE.Get(SquarePlace.B)} {squareE.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.D)} {squareD.Get(SquarePlace.E)} {squareD.Get(SquarePlace.F)} | {squareE.Get(SquarePlace.D)} {squareE.Get(SquarePlace.E)} {squareE.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.G)} {squareD.Get(SquarePlace.H)} {squareD.Get(SquarePlace.I)} | {squareE.Get(SquarePlace.G)} {squareE.Get(SquarePlace.H)} {squareE.Get(SquarePlace.I)} ");
            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareG.Get(SquarePlace.A)} {squareG.Get(SquarePlace.B)} {squareG.Get(SquarePlace.C)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.D)} {squareG.Get(SquarePlace.E)} {squareG.Get(SquarePlace.F)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.G)} {squareG.Get(SquarePlace.H)} {squareG.Get(SquarePlace.I)} |");


            List<int> row1 = new List<int>();
            row1.AddRange(squareD.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareE.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareD.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareE.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareD.GetRowNumbers(SquareRow.Row2));
            row3.AddRange(squareE.GetRowNumbers(SquareRow.Row2));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column1 = new List<int>();
            column1.AddRange(squareB.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareE.GetColumnNumbers(SquareColumn.Column1));
            count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareB.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareE.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareB.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareE.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);
        }



        [TestMethod]
        public void TestGenerateSqareF()
        {
            Square squareA = SquareHelper.GenerateInitSqare();
            Square[] squares = new Square[] { squareA };
            Square squareB = SquareHelper.GenerateMatchfieldRow1(squares);
            Square squareD = SquareHelper.GenerateMatchfieldColumn1(squares);

            squares = new Square[] { squareA, squareB };
            Square squareC = SquareHelper.GenerateMatchfieldRow1(squares);

            squares = new Square[] { squareA, squareD };
            Square squareG = SquareHelper.GenerateMatchfieldColumn1(squares);

            Square[] rows = new Square[] { squareD };
            Square[] columns = new Square[] { squareB };
            Square squareE = SquareHelper.GenerateSqare(rows, columns);


            Trace.WriteLine($"{squareA.Get(SquarePlace.A)} {squareA.Get(SquarePlace.B)} {squareA.Get(SquarePlace.C)} | {squareB.Get(SquarePlace.A)} {squareB.Get(SquarePlace.B)} {squareB.Get(SquarePlace.C)} | {squareC.Get(SquarePlace.A)} {squareC.Get(SquarePlace.B)} {squareC.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.D)} {squareA.Get(SquarePlace.E)} {squareA.Get(SquarePlace.F)} | {squareB.Get(SquarePlace.D)} {squareB.Get(SquarePlace.E)} {squareB.Get(SquarePlace.F)} | {squareC.Get(SquarePlace.D)} {squareC.Get(SquarePlace.E)} {squareC.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.G)} {squareA.Get(SquarePlace.H)} {squareA.Get(SquarePlace.I)} | {squareB.Get(SquarePlace.G)} {squareB.Get(SquarePlace.H)} {squareB.Get(SquarePlace.I)} | {squareC.Get(SquarePlace.G)} {squareC.Get(SquarePlace.H)} {squareC.Get(SquarePlace.I)}");

            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareD.Get(SquarePlace.A)} {squareD.Get(SquarePlace.B)} {squareD.Get(SquarePlace.C)} | {squareE.Get(SquarePlace.A)} {squareE.Get(SquarePlace.B)} {squareE.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.D)} {squareD.Get(SquarePlace.E)} {squareD.Get(SquarePlace.F)} | {squareE.Get(SquarePlace.D)} {squareE.Get(SquarePlace.E)} {squareE.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.G)} {squareD.Get(SquarePlace.H)} {squareD.Get(SquarePlace.I)} | {squareE.Get(SquarePlace.G)} {squareE.Get(SquarePlace.H)} {squareE.Get(SquarePlace.I)} ");
            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareG.Get(SquarePlace.A)} {squareG.Get(SquarePlace.B)} {squareG.Get(SquarePlace.C)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.D)} {squareG.Get(SquarePlace.E)} {squareG.Get(SquarePlace.F)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.G)} {squareG.Get(SquarePlace.H)} {squareG.Get(SquarePlace.I)} |");


            rows = new Square[] { squareD, squareE };
            columns = new Square[] { squareC };
            Square squareF = SquareHelper.GenerateSqare(rows, columns);
            Assert.IsTrue(squareF.IsCorrectly());

            Trace.WriteLine($"{squareA.Get(SquarePlace.A)} {squareA.Get(SquarePlace.B)} {squareA.Get(SquarePlace.C)} | {squareB.Get(SquarePlace.A)} {squareB.Get(SquarePlace.B)} {squareB.Get(SquarePlace.C)} | {squareC.Get(SquarePlace.A)} {squareC.Get(SquarePlace.B)} {squareC.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.D)} {squareA.Get(SquarePlace.E)} {squareA.Get(SquarePlace.F)} | {squareB.Get(SquarePlace.D)} {squareB.Get(SquarePlace.E)} {squareB.Get(SquarePlace.F)} | {squareC.Get(SquarePlace.D)} {squareC.Get(SquarePlace.E)} {squareC.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareA.Get(SquarePlace.G)} {squareA.Get(SquarePlace.H)} {squareA.Get(SquarePlace.I)} | {squareB.Get(SquarePlace.G)} {squareB.Get(SquarePlace.H)} {squareB.Get(SquarePlace.I)} | {squareC.Get(SquarePlace.G)} {squareC.Get(SquarePlace.H)} {squareC.Get(SquarePlace.I)}");
            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareD.Get(SquarePlace.A)} {squareD.Get(SquarePlace.B)} {squareD.Get(SquarePlace.C)} | {squareE.Get(SquarePlace.A)} {squareE.Get(SquarePlace.B)} {squareE.Get(SquarePlace.C)} | {squareF.Get(SquarePlace.A)} {squareF.Get(SquarePlace.B)} {squareF.Get(SquarePlace.C)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.D)} {squareD.Get(SquarePlace.E)} {squareD.Get(SquarePlace.F)} | {squareE.Get(SquarePlace.D)} {squareE.Get(SquarePlace.E)} {squareE.Get(SquarePlace.F)} | {squareF.Get(SquarePlace.D)} {squareF.Get(SquarePlace.E)} {squareF.Get(SquarePlace.F)}");
            Trace.WriteLine($"{squareD.Get(SquarePlace.G)} {squareD.Get(SquarePlace.H)} {squareD.Get(SquarePlace.I)} | {squareE.Get(SquarePlace.G)} {squareE.Get(SquarePlace.H)} {squareE.Get(SquarePlace.I)} | {squareF.Get(SquarePlace.G)} {squareF.Get(SquarePlace.H)} {squareF.Get(SquarePlace.I)}");
            Trace.WriteLine("---------------------");
            Trace.WriteLine($"{squareG.Get(SquarePlace.A)} {squareG.Get(SquarePlace.B)} {squareG.Get(SquarePlace.C)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.D)} {squareG.Get(SquarePlace.E)} {squareG.Get(SquarePlace.F)} |");
            Trace.WriteLine($"{squareG.Get(SquarePlace.G)} {squareG.Get(SquarePlace.H)} {squareG.Get(SquarePlace.I)} |");



            List<int> row1 = new List<int>();
            row1.AddRange(squareD.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareE.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareF.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareD.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareE.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareF.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareD.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareE.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareF.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column1 = new List<int>();
            column1.AddRange(squareC.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareF.GetColumnNumbers(SquareColumn.Column1));
            count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareC.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareF.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareC.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareF.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);
        }


        [TestMethod]
        public void TestGenerateSqareH()
        {

            Square squareA = new Square();
            Square squareB = new Square();
            Square squareC = new Square();
            Square squareD = new Square();
            Square squareE = new Square();
            Square squareF = new Square();
            Square squareG = new Square();
            Square squareH = new Square();

            while (!squareH.IsCorrectly())
            {

                try
                {
                    squareA = SquareHelper.GenerateInitSqare();

                    Square[] squares = new Square[] { squareA };
                    squareB = SquareHelper.GenerateMatchfieldRow1(squares);
                    squareD = SquareHelper.GenerateMatchfieldColumn1(squares);

                    squares = new Square[] { squareA, squareB };
                    squareC = SquareHelper.GenerateMatchfieldRow1(squares);

                    squares = new Square[] { squareA, squareD };
                    squareG = SquareHelper.GenerateMatchfieldColumn1(squares);

                    Square[] rows = new Square[] { squareD };
                    Square[] columns = new Square[] { squareB };
                    squareE = SquareHelper.GenerateSqare(rows, columns);

                    rows = new Square[] { squareD, squareE };
                    columns = new Square[] { squareC };
                    squareF = SquareHelper.GenerateSqare(rows, columns);

                    rows = new Square[] { squareG };
                    columns = new Square[] { squareB, squareE };
                    squareH = SquareHelper.GenerateSqare(rows, columns);



                }
                catch (NoMoreSolution)
                {
                    squareH.Set(new int[9]);
                    Trace.WriteLine("Restart");
                }
            }

            Assert.IsTrue(squareH.IsCorrectly());


            List<int> row1 = new List<int>();
            row1.AddRange(squareG.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareH.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareG.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareH.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareG.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareH.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(6, count);

            List<int> column1 = new List<int>();
            column1.AddRange(squareB.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareE.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareH.GetColumnNumbers(SquareColumn.Column1));
            count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareB.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareE.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareH.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareB.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareE.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareH.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);
        }



        [TestMethod]
        public void TestGenerateSqareI()
        {
            Square squareA = new Square();
            squareA.Set(new[] { 5, 3, 4, 6, 7, 2, 1, 9, 8 });
            Square squareB = new Square();
            squareB.Set(new[] { 6, 7, 8, 1, 9, 5, 3, 4, 2 });
            Square squareC = new Square();
            squareC.Set(new[] { 9, 1, 2, 3, 4, 8, 5, 6, 7 });
            Square squareD = new Square();
            squareD.Set(new[] { 8, 5, 9, 4, 2, 6, 7, 1, 3 });
            Square squareE = new Square();
            squareE.Set(new[] { 7, 6, 1, 8, 5, 3, 9, 2, 4 });
            Square squareF = new Square();
            squareF.Set(new[] { 4, 2, 3, 7, 9, 1, 8, 5, 6 });
            Square squareG = new Square();
            squareG.Set(new[] { 9, 6, 1, 2, 8, 7, 3, 4, 5 });
            Square squareH = new Square();
            squareH.Set(new[] { 5, 3, 7, 4, 1, 9, 2, 8, 6 });

            Square[] rows = new Square[] { squareG, squareH };
            Square[] columns = new Square[] { squareC, squareF };

            Square squareI = new Square();

            squareI = SquareHelper.GenerateSqare(rows, columns);
            Assert.IsTrue(squareI.IsCorrectly());

            List<int> row1 = new List<int>();
            row1.AddRange(squareG.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareH.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareI.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareG.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareH.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareI.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareG.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareH.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareI.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column1 = new List<int>();
            column1.AddRange(squareC.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareF.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareI.GetColumnNumbers(SquareColumn.Column1));
            count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareC.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareF.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareI.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareC.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareF.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareI.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);
        }

        [TestMethod]
        public void TestGenerateSqare_Full()
        {
            Square squareA = new Square();
            Square squareB = new Square();
            Square squareC = new Square();
            Square squareD = new Square();
            Square squareE = new Square();
            Square squareF = new Square();
            Square squareG = new Square();
            Square squareH = new Square();
            Square squareI = new Square();

            while (!squareI.IsCorrectly())
            {

                try
                {
                    squareA = SquareHelper.GenerateInitSqare();

                    Square[] squares = new Square[] { squareA };
                    squareB = SquareHelper.GenerateMatchfieldRow1(squares);
                    squareD = SquareHelper.GenerateMatchfieldColumn1(squares);

                    squares = new Square[] { squareA, squareB };
                    squareC = SquareHelper.GenerateMatchfieldRow1(squares);

                    squares = new Square[] { squareA, squareD };
                    squareG = SquareHelper.GenerateMatchfieldColumn1(squares);

                    Square[] rows = new Square[] { squareD };
                    Square[] columns = new Square[] { squareB };
                    squareE = SquareHelper.GenerateSqare(rows, columns);

                    rows = new Square[] { squareD, squareE };
                    columns = new Square[] { squareC };
                    squareF = SquareHelper.GenerateSqare(rows, columns);

                    rows = new Square[] { squareG };
                    columns = new Square[] { squareB, squareE };
                    squareH = SquareHelper.GenerateSqare(rows, columns);


                    rows = new Square[] { squareG, squareH };
                    columns = new Square[] { squareC, squareF };


                    squareI = SquareHelper.GenerateSqare(rows, columns);

                }
                catch (NoMoreSolution)
                {
                    squareI.Set(new int[9]);
                    Trace.WriteLine("Restart");
                }
            }

            List<int> row1 = new List<int>();
            row1.AddRange(squareG.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareH.GetRowNumbers(SquareRow.Row1));
            row1.AddRange(squareI.GetRowNumbers(SquareRow.Row1));
            int count = row1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row2 = new List<int>();
            row2.AddRange(squareG.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareH.GetRowNumbers(SquareRow.Row2));
            row2.AddRange(squareI.GetRowNumbers(SquareRow.Row2));
            count = row2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> row3 = new List<int>();
            row3.AddRange(squareG.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareH.GetRowNumbers(SquareRow.Row3));
            row3.AddRange(squareI.GetRowNumbers(SquareRow.Row3));
            count = row3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column1 = new List<int>();
            column1.AddRange(squareC.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareF.GetColumnNumbers(SquareColumn.Column1));
            column1.AddRange(squareI.GetColumnNumbers(SquareColumn.Column1));
            count = column1.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column2 = new List<int>();
            column2.AddRange(squareC.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareF.GetColumnNumbers(SquareColumn.Column2));
            column2.AddRange(squareI.GetColumnNumbers(SquareColumn.Column2));
            count = column2.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);

            List<int> column3 = new List<int>();
            column3.AddRange(squareC.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareF.GetColumnNumbers(SquareColumn.Column3));
            column3.AddRange(squareI.GetColumnNumbers(SquareColumn.Column3));
            count = column3.GroupBy(v => v).Count();

            Assert.AreEqual(9, count);
        }




        [TestMethod]
        public void TestGetPosibleNumbers()
        {
            int[] a = new int[] { 1, 2, 3 };
            List<int> possibe = SquareHelper.GetPosibleNumbers(a);

            Assert.AreEqual(6, possibe.Count);
        }
    }
}
