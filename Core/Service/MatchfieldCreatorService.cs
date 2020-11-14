using Sodoku.Core.Exceptions;
using Sodoku.Core.Helper;
using Sodoku.Core.Models;

namespace Sodoku.Core.Service
{
    public static class MatchfieldCreatorService
    {

        public static Square[] GetSquares()
        {
            Square squareI = new Square();

            Square[] output = new Square[9];

            while (!squareI.IsCorrectly())
            {
                try
                {
                    Square squareA = SquareHelper.GenerateInitSqare();
                    output[0] = squareA;

                    Square[] squares = new Square[] { squareA };
                    Square squareB = SquareHelper.GenerateMatchfieldRow1(squares);
                    output[1] = squareB;
                    Square squareD = SquareHelper.GenerateMatchfieldColumn1(squares);
                    output[3] = squareD;

                    squares = new Square[] { squareA, squareB };
                    Square squareC = SquareHelper.GenerateMatchfieldRow1(squares);
                    output[2] = squareC;

                    squares = new Square[] { squareA, squareD };
                    Square squareG = SquareHelper.GenerateMatchfieldColumn1(squares);
                    output[6] = squareG;

                    Square[] rows = new Square[] { squareD };
                    Square[] columns = new Square[] { squareB };
                    Square squareE = SquareHelper.GenerateSqare(rows, columns);
                    output[4] = squareE;

                    rows = new Square[] { squareD, squareE };
                    columns = new Square[] { squareC };
                    Square squareF = SquareHelper.GenerateSqare(rows, columns);
                    output[5] = squareF;

                    rows = new Square[] { squareG };
                    columns = new Square[] { squareB, squareE };
                    Square squareH = SquareHelper.GenerateSqare(rows, columns);
                    output[7] = squareH;

                    rows = new Square[] { squareG, squareH };
                    columns = new Square[] { squareC, squareF };
                    squareI = SquareHelper.GenerateSqare(rows, columns);
                    output[8] = squareI;

                }
                catch (NoMoreSolution)
                {
                    squareI.Set(new int[9]);
                    output = new Square[9];
                }
            }

            return output;
        }

        public static Square[] GetSquares(int[,] array)
        {
            Square[] output = new Square[9];

            for (int i = 0; i < 9; i += 3)
            {
                int rowNumber = i / 3;
                output[0] = new Square();
                output[1] = new Square();
                output[2] = new Square();

                output[1].Fields[i] = array[rowNumber, 0];
                output[1].Fields[i + 1] = array[rowNumber, 1];
                output[1].Fields[i + 2] = array[rowNumber, 2];


                output[2].Fields[i] = array[rowNumber, 3];
                output[2].Fields[i + 1] = array[rowNumber, 4];
                output[2].Fields[i + 2] = array[rowNumber, 5];


                output[3].Fields[i] = array[rowNumber, 6];
                output[3].Fields[i + 1] = array[rowNumber, 7];
                output[3].Fields[i + 2] = array[rowNumber, 8];
            }



            return output;
        }
    }
}
