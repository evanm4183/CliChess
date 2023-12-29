using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook : ChessPiece
    {
        public Rook(string color)
        {
            Name = "Rook";
            Abbreviation = "R";
            Color = color;
        }
    }
}
