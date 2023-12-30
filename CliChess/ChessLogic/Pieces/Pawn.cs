using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Pawn : ChessPiece
    {
        public Pawn(PieceColor color) 
        {
            Name = "Pawn";
            Abbreviation = "P";
            Color = color;
        }
    }
}
