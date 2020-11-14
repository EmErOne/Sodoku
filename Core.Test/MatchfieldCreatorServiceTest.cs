using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodoku.Core.Models;
using Sodoku.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sodoku.Core.Test
{
    public class MatchfieldCreatorServiceTest
    {
        [TestMethod]
        public void TestMatchfieldCreatorService()
        {
            Square[] squares = MatchfieldCreatorService.GetSquares();

            Square squareA = squares[0];
            Square squareB = squares[1];
            Square squareC = squares[2];
            Square squareD = squares[3];
            Square squareE = squares[4];
            Square squareF = squares[5];
            Square squareG = squares[6];
            Square squareH = squares[7];
            Square squareI = squares[8];

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
    }
}
