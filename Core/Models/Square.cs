using System;
using System.Collections.Generic;
using System.Linq;

namespace Sodoku.Core.Models
{
    public class Square
    {
        public int[] Fields { get; set; } = new int[9];

        // A | B | C
        // D | E | F
        // G | H | I

        public Square()
        {
            Set(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }

        public Square(int[] fields)
        {
            Set(fields);
        }


        public void Set(int[] value)
        {
            if (value.Length != 9)
            {
                throw new ArgumentException("Falscher Anzahl an Werten.", nameof(value));
            }

            Fields[0] = value[0];
            Fields[1] = value[1];
            Fields[2] = value[2];
            Fields[3] = value[3];
            Fields[4] = value[4];
            Fields[5] = value[5];
            Fields[6] = value[6];
            Fields[7] = value[7];
            Fields[8] = value[8];
        }

        public void Set(SquarePlace place, int value)
        {
            if (value < 1 && value > 9)
            {
                throw new ArgumentException("Falscher wert", nameof(value));
            }

            switch (place)
            {
                case SquarePlace.A:
                    Fields[0] = value;
                    break;
                case SquarePlace.B:
                    Fields[1] = value;
                    break;
                case SquarePlace.C:
                    Fields[2] = value;
                    break;
                case SquarePlace.D:
                    Fields[3] = value;
                    break;
                case SquarePlace.E:
                    Fields[4] = value;
                    break;
                case SquarePlace.F:
                    Fields[5] = value;
                    break;
                case SquarePlace.G:
                    Fields[6] = value;
                    break;
                case SquarePlace.H:
                    Fields[7] = value;
                    break;
                case SquarePlace.I:
                    Fields[8] = value;
                    break;
                default:
                    throw new ArgumentException("SquarePlace ist nicht vergeben", nameof(place));
            }
        }

        public int Get(SquarePlace place)
        {
            var output = place switch
            {
                SquarePlace.A => Fields[0],
                SquarePlace.B => Fields[1],
                SquarePlace.C => Fields[2],
                SquarePlace.D => Fields[3],
                SquarePlace.E => Fields[4],
                SquarePlace.F => Fields[5],
                SquarePlace.G => Fields[6],
                SquarePlace.H => Fields[7],
                SquarePlace.I => Fields[8],
                _ => throw new ArgumentException("SquarePlace ist nicht vergeben", nameof(place)),
            };
            return output;
        }

        public bool IsCorrectly()
        {
            List<int> mFields = new List<int>(Fields);
            bool output = true;

            foreach (int field in Fields)
            {
                int count = (mFields.Where(f => f == field)).Count();

                if (count != 1)
                {
                    output = false;
                }
            }

            return output;
        }

        public int[] GetRowNumbers(SquareRow squareRow)
        {
            int[] output = new int[3];

            switch (squareRow)
            {
                case SquareRow.Row1:
                    output = new int[] { Get(SquarePlace.A), Get(SquarePlace.B), Get(SquarePlace.C) };
                    break;
                case SquareRow.Row2:
                    output = new int[] { Get(SquarePlace.D), Get(SquarePlace.E), Get(SquarePlace.F) };
                    break;
                case SquareRow.Row3:
                    output = new int[] { Get(SquarePlace.G), Get(SquarePlace.H), Get(SquarePlace.I) };
                    break;
            }

            return output;
        }

        public int[] GetColumnNumbers(SquareColumn squareColumn)
        {
            int[] output = new int[3];

            switch (squareColumn)
            {
                case SquareColumn.Column1:
                    output = new int[] { Get(SquarePlace.A), Get(SquarePlace.D), Get(SquarePlace.G) };
                    break;
                case SquareColumn.Column2:
                    output = new int[] { Get(SquarePlace.B), Get(SquarePlace.E), Get(SquarePlace.H) };
                    break;
                case SquareColumn.Column3:
                    output = new int[] { Get(SquarePlace.C), Get(SquarePlace.F), Get(SquarePlace.I) };
                    break;
            }

            return output;
        }
    }
}
