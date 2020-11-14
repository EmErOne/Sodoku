using System;
using System.Collections.Generic;
using System.Text;

namespace Sodoku.Core.Exceptions
{
    public class NoMoreSolution : Exception
    {

        public NoMoreSolution() : base("No solution could be found.")
        {

        }

        public NoMoreSolution(string message) : base(message)
        {
        }

        public NoMoreSolution(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
