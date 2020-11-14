using Sodoku.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sodoku.Core.Service
{
    public class MatchfieldStoreService
    {
        public string Path { get; }

        public MatchfieldStoreService(string path)
        {
            Path = path;
        }

        public void SaveMatchfield(Matchfield matchfield)
        {
            if (!File.Exists(Path))
            {
                using StreamWriter sw = File.CreateText(Path);
                sw.WriteLine(Serialize(matchfield));
            }
            else
            {
                using StreamWriter sw = File.AppendText(Path);
                sw.WriteLine(Serialize(matchfield));
            }
        }

        public Matchfield GetRandomMatchfield()
        {
            Matchfield[] matchfields = LoadMatchfields();
            Matchfield output;

            if (matchfields.Length == 0)
            {
                Square[] squares = MatchfieldCreatorService.GetSquares();
                output = new Matchfield(squares);
            }
            else if (matchfields.Length == 1)
            {
                output = matchfields[0];
            }
            else
            {
                Random random = new Random();
                int index = random.Next(0, matchfields.Length);
                output = matchfields[index];
            }

            return output;
        }

        public Matchfield[] LoadMatchfields()
        {

            string[] lines = File.ReadAllLines(Path);
            List<Matchfield> output = new List<Matchfield>();

            foreach (var line in lines)
            {
                Square[] squares = Deserialize(line);
                output.Add(new Matchfield(squares));
            }

            return output.ToArray();
        }

        private string Serialize(Matchfield matchfield)
        {
            string output = string.Empty;

            foreach (var square in matchfield.Squares)
            {
                foreach (int field in square.Fields)
                {
                    output += field.ToString();
                }
            }

            return output;
        }

        private Square[] Deserialize(string matchfieldString)
        {
            Square[] output = new Square[9];

            int squaresCouter = 0;

            for (int i = 0; i < matchfieldString.Length; i += 9)
            {
                string squareString = matchfieldString.Substring(i, 9);

                int[] fields = new int[9];
                for (int i1 = 0; i1 < squareString.Length; i1++)
                {
                    fields[i1] = int.Parse(squareString.Substring(i1, 1));
                }

                output[squaresCouter] = new Square(fields);

                squaresCouter++;
            }

            return output;
        }
    }
}
