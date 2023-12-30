using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook : ChessPiece
    {
        public Rook(PieceColor color)
        {
            Name = "Rook";
            Abbreviation = "R";
            Color = color;
        }
    }
}
