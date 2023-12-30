using ChessLogic.Pieces;
using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    public static class Sandbox
    {
        public static void Run()
        {
            var whitePawn = new Pawn(PieceColor.White);

            if (whitePawn.Color == PieceColor.White)
            {
                Console.WriteLine("the color is white");
            }
        }
    }
}
