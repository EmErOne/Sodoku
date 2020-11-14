using Sodoku.Core.Exceptions;
using Sodoku.Core.Models;
using System;
using System.Collections.Generic;

namespace Sodoku.Core.Helper
{
    public static class SquareHelper
    {
        private static Random random = new Random();

        public static Square GenerateInitSqare()
        {
            List<int> mFields = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> outFields = new List<int>();


            for (int i = 0; i < 9; i++)
            {

                int number = GetANumber(mFields.ToArray());
                outFields.Add(number);
                mFields.Remove(number);
            }

            Square output = new Square();
            output.Set(outFields.ToArray());

            return output;
        }

        public static Square GenerateMatchfieldRow1(Square[] squares)
        {
            Square output = new Square();
            List<int> mRow1 = new List<int>();
            List<int> mRow2 = new List<int>();
            List<int> mRow3 = new List<int>();

            foreach (var square in squares)
            {
                mRow1.AddRange(square.GetRowNumbers(SquareRow.Row1));
                mRow2.AddRange(square.GetRowNumbers(SquareRow.Row2));
                mRow3.AddRange(square.GetRowNumbers(SquareRow.Row3));
            }

            while (output.IsCorrectly() == false)
            {
                List<int> mOutputFields = new List<int>();

                try
                {
                    // Row 1 for Sqare B
                    for (int i = 0; i < 3; i++)
                    {

                        int number = GetPosibleRowNumbers(mRow1.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);
                    }


                    //Row 2 for Sqare B
                    for (int i = 0; i < 3; i++)
                    {
                        int number = GetPosibleRowNumbers(mRow2.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);
                    }

                    // Row 3 for Sqare B
                    for (int i = 0; i < 3; i++)
                    {
                        int number = GetPosibleRowNumbers(mRow3.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);
                    }


                    output.Set(mOutputFields.ToArray());
                }
                catch (NoMoreSolution)
                {
                    output.Set(new int[9]);
                }
            }

            return output;
        }

        public static Square GenerateMatchfieldColumn1(Square[] squares)
        {
            Square output = new Square();
            List<int> mColumn1 = new List<int>();
            List<int> mColumn2 = new List<int>();
            List<int> mColumn3 = new List<int>();


            foreach (var square in squares)
            {
                mColumn1.AddRange(square.GetColumnNumbers(SquareColumn.Column1));
                mColumn2.AddRange(square.GetColumnNumbers(SquareColumn.Column2));
                mColumn3.AddRange(square.GetColumnNumbers(SquareColumn.Column3));
            }

            List<int> mOutputFields = new List<int>();
            int[] fields = new int[9];

            while (!output.IsCorrectly())
            {
                try
                {
                    // Row 1 for Sqare B
                    for (int i = 0; i < 7; i += 3)
                    {
                        int number = GetPosibleRowNumbers(mColumn1.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);

                        fields[i] = number;
                    }


                    //Row 2 for Sqare B
                    for (int i = 1; i < 8; i += 3)
                    {
                        int number = GetPosibleRowNumbers(mColumn2.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);
                        fields[i] = number;
                    }

                    // Row 3 for Sqare B
                    for (int i = 2; i < 9; i += 3)
                    {
                        int number = GetPosibleRowNumbers(mColumn3.ToArray(), mOutputFields.ToArray());
                        mOutputFields.Add(number);
                        fields[i] = number;
                    }

                    output.Set(fields);
                }
                catch (NoMoreSolution)
                {
                    mOutputFields = new List<int>();
                    fields = new int[9];
                }
            }

            return output;
        }



        public static Square GenerateSqare(Square[] rows, Square[] columns)
        {
            Square output = new Square();
            List<int> mColumn1 = new List<int>();
            List<int> mColumn2 = new List<int>();
            List<int> mColumn3 = new List<int>();

            List<int> mRow1 = new List<int>();
            List<int> mRow2 = new List<int>();
            List<int> mRow3 = new List<int>();

            foreach (var rowSquare in rows)
            {
                mRow1.AddRange(rowSquare.GetRowNumbers(SquareRow.Row1));
                mRow2.AddRange(rowSquare.GetRowNumbers(SquareRow.Row2));
                mRow3.AddRange(rowSquare.GetRowNumbers(SquareRow.Row3));
            }

            foreach (var columnSquare in columns)
            {
                mColumn1.AddRange(columnSquare.GetColumnNumbers(SquareColumn.Column1));
                mColumn2.AddRange(columnSquare.GetColumnNumbers(SquareColumn.Column2));
                mColumn3.AddRange(columnSquare.GetColumnNumbers(SquareColumn.Column3));
            }


            int exceptionCunt = 0;

            while (!output.IsCorrectly())
            {

                List<int> mOutputFields = new List<int>();

                try
                {
                    int a = GetCell(mRow1, mColumn1, mOutputFields);
                    mOutputFields.Add(a);

                    int b = GetCell(mRow1, mColumn2, mOutputFields);
                    mOutputFields.Add(b);

                    int c = GetCell(mRow1, mColumn3, mOutputFields);
                    mOutputFields.Add(c);

                    int d = GetCell(mRow2, mColumn1, mOutputFields);
                    mOutputFields.Add(d);

                    int e = GetCell(mRow2, mColumn2, mOutputFields);
                    mOutputFields.Add(e);

                    int f = GetCell(mRow2, mColumn3, mOutputFields);
                    mOutputFields.Add(f);

                    int g = GetCell(mRow3, mColumn1, mOutputFields);
                    mOutputFields.Add(g);

                    int h = GetCell(mRow3, mColumn2, mOutputFields);
                    mOutputFields.Add(h);

                    int i = GetCell(mRow3, mColumn3, mOutputFields);
                    mOutputFields.Add(i);

                    output.Set(mOutputFields.ToArray());
                }
                catch (NoMoreSolution)
                {
                    output.Set(new int[9]);
                    exceptionCunt++;

                    if (exceptionCunt > 100)
                    {
                        throw new NoMoreSolution("Projekt neu erstellen");
                    }
                }
            }


            return output;
        }


        private static int GetCell(List<int> assigNumbersRow, List<int> assigNumberColumn, List<int> ownNumers)
        {
            List<int> list = new List<int>();
            list.AddRange(assigNumbersRow);
            list.AddRange(assigNumberColumn);

            int number = GetPosibleRowNumbers(list.ToArray(), ownNumers.ToArray());

            return number;
        }


        private static int GetANumber(int[] possibleNumbers)
        {

            int output;
            if (possibleNumbers.Length == 0)
            {
                random = new Random();
                throw new NoMoreSolution();
            }
            else if (possibleNumbers.Length > 1)
            {

                int index = random.Next(0, possibleNumbers.Length);
                output = possibleNumbers[index];
            }
            else
            {
                output = possibleNumbers[0];
            }

            return output;
        }


        public static int GetPosibleRowNumbers(int[] rowNumbers, int[] assignNumbers)
        {
            var possible = GetPosibleNumbers(assignNumbers);

            foreach (int number in rowNumbers)
            {
                if (possible.Contains(number))
                {
                    possible.Remove(number);
                }
            }

            int output = GetANumber(possible.ToArray());

            return output;
        }


        public static List<int> GetPosibleNumbers(int[] assignNumbers)
        {
            List<int> output = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int number in assignNumbers)
            {
                if (output.Contains(number))
                {
                    output.Remove(number);
                }
            }

            return output;
        }

    }
}
