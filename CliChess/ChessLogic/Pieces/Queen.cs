using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Queen : ChessPiece
    {
        public Queen(PieceColor color) 
        {
            Name = "Queen";
            Abbreviation = "Q";
            Color = color;
        }
    }
}
