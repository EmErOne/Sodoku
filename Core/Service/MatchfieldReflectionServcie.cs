using Sodoku.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sodoku.Core.Service
{
    public class MatchfieldReflectionServcie
    {



        private readonly Matchfield _matchfield;

        public MatchfieldReflectionServcie(Matchfield matchfield)
        {
            _matchfield = matchfield;
        }

        public Matchfield ReflactHorizontal()
        {
            Matchfield output = null;



            return output;
        }

        public Matchfield ReflactVertical()
        {
            Matchfield output = null;

            int[,] field = new int[9, 9];


            for (int row = 0; row < 9; row++)
            {
                int[] rowValues = _matchfield.GetRow(row);
                int[] reflection = ReflectRow(rowValues);
                for (int column = 0; column < 9; column++)
                {
                    field[row, column] = reflection[column];
                }
            }

            return output;
        }


        private int[] ReflectRow(int[] row)
        {
            Array array = Array.CreateInstance(typeof(int), 9);
            for (int i = 0; i < 9; i++)
            {
                array.SetValue(row[i], i);
            }

            Array.Reverse(array);

            int[] output = new int[9];

            for (int i = 0; i < 9; i++)
            {
                output[i] = (int)(array.GetValue(i));
            }

            return output;

        }

    }
}
