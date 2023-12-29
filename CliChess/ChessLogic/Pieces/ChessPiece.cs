using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class ChessPiece
    {
        protected string Name { get; set; }
        protected string Abbreviation { get; set; }
        protected string Color { get; set; }

        protected virtual List<string> CalcUnobstructedMoves(string square)
        {
            return null;
        }
    }
}
