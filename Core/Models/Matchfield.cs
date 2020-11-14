using Sodoku.Core.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sodoku.Core.Models
{
    public class Matchfield
    {
        public Square[] Squares { get; } = new Square[9];

        public int[,] Field => GetFields();


        // 1 | 2 | 3
        // 4 | 5 | 6
        // 7 | 8 | 9

        public Matchfield()
        {
            Squares = MatchfieldCreatorService.GetSquares();
        }

        public Matchfield(Square[] squares)
        {
            Squares = squares;
        }

        public Matchfield(int[,] array)
        {

        }

        public int[] GetRow(int row)
        {
            int[] output = new int[9];

            switch (row)
            {
                case 0:
                    output[0] = Squares[0].Fields[0];
                    output[1] = Squares[0].Fields[1];
                    output[2] = Squares[0].Fields[2];
                    output[3] = Squares[1].Fields[0];
                    output[4] = Squares[1].Fields[1];
                    output[5] = Squares[1].Fields[2];
                    output[6] = Squares[2].Fields[0];
                    output[7] = Squares[2].Fields[1];
                    output[8] = Squares[2].Fields[2];
                    break;
                case 1:
                    output[0] = Squares[0].Fields[3];
                    output[1] = Squares[0].Fields[4];
                    output[2] = Squares[0].Fields[5];
                    output[3] = Squares[1].Fields[3];
                    output[4] = Squares[1].Fields[4];
                    output[5] = Squares[1].Fields[5];
                    output[6] = Squares[2].Fields[3];
                    output[7] = Squares[2].Fields[4];
                    output[8] = Squares[2].Fields[5];
                    break;
                case 2:
                    output[0] = Squares[0].Fields[6];
                    output[1] = Squares[0].Fields[7];
                    output[2] = Squares[0].Fields[8];
                    output[3] = Squares[1].Fields[6];
                    output[4] = Squares[1].Fields[7];
                    output[5] = Squares[1].Fields[8];
                    output[6] = Squares[2].Fields[6];
                    output[7] = Squares[2].Fields[7];
                    output[8] = Squares[2].Fields[8];
                    break;
                case 3:
                    output[0] = Squares[3].Fields[0];
                    output[1] = Squares[3].Fields[1];
                    output[2] = Squares[3].Fields[2];
                    output[3] = Squares[4].Fields[0];
                    output[4] = Squares[4].Fields[1];
                    output[5] = Squares[4].Fields[2];
                    output[6] = Squares[5].Fields[0];
                    output[7] = Squares[5].Fields[1];
                    output[8] = Squares[5].Fields[2];
                    break;
                case 4:
                    output[0] = Squares[3].Fields[3];
                    output[1] = Squares[3].Fields[4];
                    output[2] = Squares[3].Fields[5];
                    output[3] = Squares[4].Fields[3];
                    output[4] = Squares[4].Fields[4];
                    output[5] = Squares[4].Fields[5];
                    output[6] = Squares[5].Fields[3];
                    output[7] = Squares[5].Fields[4];
                    output[8] = Squares[5].Fields[5];
                    break;
                case 5:
                    output[0] = Squares[3].Fields[6];
                    output[1] = Squares[3].Fields[7];
                    output[2] = Squares[3].Fields[8];
                    output[3] = Squares[4].Fields[6];
                    output[4] = Squares[4].Fields[7];
                    output[5] = Squares[4].Fields[8];
                    output[6] = Squares[5].Fields[6];
                    output[7] = Squares[5].Fields[7];
                    output[8] = Squares[5].Fields[8];
                    break;
                case 6:
                    output[0] = Squares[6].Fields[0];
                    output[1] = Squares[6].Fields[1];
                    output[2] = Squares[6].Fields[2];
                    output[3] = Squares[7].Fields[0];
                    output[4] = Squares[7].Fields[1];
                    output[5] = Squares[7].Fields[2];
                    output[6] = Squares[8].Fields[0];
                    output[7] = Squares[8].Fields[1];
                    output[8] = Squares[8].Fields[2];
                    break;
                case 7:
                    output[0] = Squares[6].Fields[3];
                    output[1] = Squares[6].Fields[4];
                    output[2] = Squares[6].Fields[5];
                    output[3] = Squares[7].Fields[3];
                    output[4] = Squares[7].Fields[4];
                    output[5] = Squares[7].Fields[5];
                    output[6] = Squares[8].Fields[3];
                    output[7] = Squares[8].Fields[4];
                    output[8] = Squares[8].Fields[5];
                    break;
                case 8:
                    output[0] = Squares[6].Fields[6];
                    output[1] = Squares[6].Fields[7];
                    output[2] = Squares[6].Fields[8];
                    output[3] = Squares[7].Fields[6];
                    output[4] = Squares[7].Fields[7];
                    output[5] = Squares[7].Fields[8];
                    output[6] = Squares[8].Fields[6];
                    output[7] = Squares[8].Fields[7];
                    output[8] = Squares[8].Fields[8];
                    break;

                default:
                    throw new IndexOutOfRangeException();
            }

            return output;
        }



        public int GetField(int row, int colummn)
        {
            int[,] array = GetFields();
            return array[row, colummn];
        }

        public int[,] GetFields()
        {
            int[,] output = new int[9, 9];


            for (int row = 0; row < 9; row++)
            {
                int[] array = GetRow(row);

                for (int column = 0; column < array.Length; column++)
                {
                    output[row, column] = array[column];
                }
            }

            return output;
        }
    }
}
