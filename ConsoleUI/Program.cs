using Sodoku.Core.Models;
using Sodoku.Core.Service;
using System;

namespace Sodoku.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            Console.WriteLine($"{squareA.Get(SquarePlace.A)} {squareA.Get(SquarePlace.B)} {squareA.Get(SquarePlace.C)} | {squareB.Get(SquarePlace.A)} {squareB.Get(SquarePlace.B)} {squareB.Get(SquarePlace.C)} | {squareC.Get(SquarePlace.A)} {squareC.Get(SquarePlace.B)} {squareC.Get(SquarePlace.C)}");
            Console.WriteLine($"{squareA.Get(SquarePlace.D)} {squareA.Get(SquarePlace.E)} {squareA.Get(SquarePlace.F)} | {squareB.Get(SquarePlace.D)} {squareB.Get(SquarePlace.E)} {squareB.Get(SquarePlace.F)} | {squareC.Get(SquarePlace.D)} {squareC.Get(SquarePlace.E)} {squareC.Get(SquarePlace.F)}");
            Console.WriteLine($"{squareA.Get(SquarePlace.G)} {squareA.Get(SquarePlace.H)} {squareA.Get(SquarePlace.I)} | {squareB.Get(SquarePlace.G)} {squareB.Get(SquarePlace.H)} {squareB.Get(SquarePlace.I)} | {squareC.Get(SquarePlace.G)} {squareC.Get(SquarePlace.H)} {squareC.Get(SquarePlace.I)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"{squareD.Get(SquarePlace.A)} {squareD.Get(SquarePlace.B)} {squareD.Get(SquarePlace.C)} | {squareE.Get(SquarePlace.A)} {squareE.Get(SquarePlace.B)} {squareE.Get(SquarePlace.C)} | {squareF.Get(SquarePlace.A)} {squareF.Get(SquarePlace.B)} {squareF.Get(SquarePlace.C)}");
            Console.WriteLine($"{squareD.Get(SquarePlace.D)} {squareD.Get(SquarePlace.E)} {squareD.Get(SquarePlace.F)} | {squareE.Get(SquarePlace.D)} {squareE.Get(SquarePlace.E)} {squareE.Get(SquarePlace.F)} | {squareF.Get(SquarePlace.D)} {squareF.Get(SquarePlace.E)} {squareF.Get(SquarePlace.F)}");
            Console.WriteLine($"{squareD.Get(SquarePlace.G)} {squareD.Get(SquarePlace.H)} {squareD.Get(SquarePlace.I)} | {squareE.Get(SquarePlace.G)} {squareE.Get(SquarePlace.H)} {squareE.Get(SquarePlace.I)} | {squareF.Get(SquarePlace.G)} {squareF.Get(SquarePlace.H)} {squareF.Get(SquarePlace.I)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"{squareG.Get(SquarePlace.A)} {squareG.Get(SquarePlace.B)} {squareG.Get(SquarePlace.C)} | {squareH.Get(SquarePlace.A)} {squareH.Get(SquarePlace.B)} {squareH.Get(SquarePlace.C)} | {squareI.Get(SquarePlace.A)} {squareI.Get(SquarePlace.B)} {squareI.Get(SquarePlace.C)}");
            Console.WriteLine($"{squareG.Get(SquarePlace.D)} {squareG.Get(SquarePlace.E)} {squareG.Get(SquarePlace.F)} | {squareH.Get(SquarePlace.D)} {squareH.Get(SquarePlace.E)} {squareH.Get(SquarePlace.F)} | {squareI.Get(SquarePlace.D)} {squareI.Get(SquarePlace.E)} {squareI.Get(SquarePlace.F)}");
            Console.WriteLine($"{squareG.Get(SquarePlace.G)} {squareG.Get(SquarePlace.H)} {squareG.Get(SquarePlace.I)} | {squareH.Get(SquarePlace.G)} {squareH.Get(SquarePlace.H)} {squareH.Get(SquarePlace.I)} | {squareI.Get(SquarePlace.G)} {squareI.Get(SquarePlace.H)} {squareI.Get(SquarePlace.I)}");

            Console.ReadLine();
        }
    }
}
