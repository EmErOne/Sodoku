using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodoku.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sodoku.Core.Test
{
    [TestClass]
    public class MatchfieldTest
    {

        [TestMethod]
        public void FieldsTest()
        {
            Matchfield matchfield = new Matchfield();

            int[,] array = matchfield.Field;

            #region ROW0 - ROW2

            for (int i = 0; i < 9; i += 3)
            {
                int rowNumber = i / 3;
                int expacted_0 = matchfield.Squares[0].Fields[i];
                Assert.AreEqual(expacted_0, array[rowNumber, 0]);
                Assert.AreEqual(expacted_0, matchfield.GetRow(rowNumber)[0]);

                int expacted_1 = matchfield.Squares[0].Fields[i + 1];
                Assert.AreEqual(expacted_1, array[rowNumber, 1]);
                Assert.AreEqual(expacted_1, matchfield.GetRow(rowNumber)[1]);

                int expacted_2 = matchfield.Squares[0].Fields[i + 2];
                Assert.AreEqual(expacted_2, array[rowNumber, 2]);
                Assert.AreEqual(expacted_2, matchfield.GetRow(rowNumber)[2]);

                int expacted_3 = matchfield.Squares[1].Fields[i];
                Assert.AreEqual(expacted_3, array[rowNumber, 3]);
                Assert.AreEqual(expacted_3, matchfield.GetRow(rowNumber)[3]);

                int expacted_4 = matchfield.Squares[1].Fields[i + 1];
                Assert.AreEqual(expacted_4, array[rowNumber, 4]);
                Assert.AreEqual(expacted_4, matchfield.GetRow(rowNumber)[4]);

                int expacted_5 = matchfield.Squares[1].Fields[i + 2];
                Assert.AreEqual(expacted_5, array[rowNumber, 5]);
                Assert.AreEqual(expacted_5, matchfield.GetRow(rowNumber)[5]);

                int expacted_6 = matchfield.Squares[2].Fields[i];
                Assert.AreEqual(expacted_6, array[rowNumber, 6]);
                Assert.AreEqual(expacted_6, matchfield.GetRow(rowNumber)[6]);

                int expacted_7 = matchfield.Squares[2].Fields[i + 1];
                Assert.AreEqual(expacted_7, array[rowNumber, 7]);
                Assert.AreEqual(expacted_7, matchfield.GetRow(rowNumber)[7]);

                int expacted_8 = matchfield.Squares[2].Fields[i + 2];
                Assert.AreEqual(expacted_8, array[rowNumber, 8]);
                Assert.AreEqual(expacted_8, matchfield.GetRow(rowNumber)[8]);
            }


            #endregion

            #region ROW3 - ROW5
            for (int i = 0; i < 9; i += 3)
            {
                int rowNumber = (i / 3) + 3;
                int expacted_0 = matchfield.Squares[3].Fields[i];
                Assert.AreEqual(expacted_0, array[rowNumber, 0]);
                Assert.AreEqual(expacted_0, matchfield.GetRow(rowNumber)[0]);

                int expacted_1 = matchfield.Squares[3].Fields[i + 1];
                Assert.AreEqual(expacted_1, array[rowNumber, 1]);
                Assert.AreEqual(expacted_1, matchfield.GetRow(rowNumber)[1]);

                int expacted_2 = matchfield.Squares[3].Fields[i + 2];
                Assert.AreEqual(expacted_2, array[rowNumber, 2]);
                Assert.AreEqual(expacted_2, matchfield.GetRow(rowNumber)[2]);

                int expacted_3 = matchfield.Squares[4].Fields[i];
                Assert.AreEqual(expacted_3, array[rowNumber, 3]);
                Assert.AreEqual(expacted_3, matchfield.GetRow(rowNumber)[3]);

                int expacted_4 = matchfield.Squares[4].Fields[i + 1];
                Assert.AreEqual(expacted_4, array[rowNumber, 4]);
                Assert.AreEqual(expacted_4, matchfield.GetRow(rowNumber)[4]);

                int expacted_5 = matchfield.Squares[4].Fields[i + 2];
                Assert.AreEqual(expacted_5, array[rowNumber, 5]);
                Assert.AreEqual(expacted_5, matchfield.GetRow(rowNumber)[5]);

                int expacted_6 = matchfield.Squares[5].Fields[i];
                Assert.AreEqual(expacted_6, array[rowNumber, 6]);
                Assert.AreEqual(expacted_6, matchfield.GetRow(rowNumber)[6]);

                int expacted_7 = matchfield.Squares[5].Fields[i + 1];
                Assert.AreEqual(expacted_7, array[rowNumber, 7]);
                Assert.AreEqual(expacted_7, matchfield.GetRow(rowNumber)[7]);

                int expacted_8 = matchfield.Squares[5].Fields[i + 2];
                Assert.AreEqual(expacted_8, array[rowNumber, 8]);
                Assert.AreEqual(expacted_8, matchfield.GetRow(rowNumber)[8]);
            }


            #endregion

            #region ROW6 - ROW8

            for (int i = 0; i < 9; i += 3)
            {
                int rowNumber = (i / 3) + 6;
                int expacted_0 = matchfield.Squares[6].Fields[i];
                Assert.AreEqual(expacted_0, array[rowNumber, 0]);
                Assert.AreEqual(expacted_0, matchfield.GetRow(rowNumber)[0]);

                int expacted_1 = matchfield.Squares[6].Fields[i + 1];
                Assert.AreEqual(expacted_1, array[rowNumber, 1]);
                Assert.AreEqual(expacted_1, matchfield.GetRow(rowNumber)[1]);

                int expacted_2 = matchfield.Squares[6].Fields[i + 2];
                Assert.AreEqual(expacted_2, array[rowNumber, 2]);
                Assert.AreEqual(expacted_2, matchfield.GetRow(rowNumber)[2]);

                int expacted_3 = matchfield.Squares[7].Fields[i];
                Assert.AreEqual(expacted_3, array[rowNumber, 3]);
                Assert.AreEqual(expacted_3, matchfield.GetRow(rowNumber)[3]);

                int expacted_4 = matchfield.Squares[7].Fields[i + 1];
                Assert.AreEqual(expacted_4, array[rowNumber, 4]);
                Assert.AreEqual(expacted_4, matchfield.GetRow(rowNumber)[4]);

                int expacted_5 = matchfield.Squares[7].Fields[i + 2];
                Assert.AreEqual(expacted_5, array[rowNumber, 5]);
                Assert.AreEqual(expacted_5, matchfield.GetRow(rowNumber)[5]);

                int expacted_6 = matchfield.Squares[8].Fields[i];
                Assert.AreEqual(expacted_6, array[rowNumber, 6]);
                Assert.AreEqual(expacted_6, matchfield.GetRow(rowNumber)[6]);

                int expacted_7 = matchfield.Squares[8].Fields[i + 1];
                Assert.AreEqual(expacted_7, array[rowNumber, 7]);
                Assert.AreEqual(expacted_7, matchfield.GetRow(rowNumber)[7]);

                int expacted_8 = matchfield.Squares[8].Fields[i + 2];
                Assert.AreEqual(expacted_8, array[rowNumber, 8]);
                Assert.AreEqual(expacted_8, matchfield.GetRow(rowNumber)[8]);
            }


            #endregion
        }


    }
}
