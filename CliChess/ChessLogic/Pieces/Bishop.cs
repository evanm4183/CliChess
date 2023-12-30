using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop : ChessPiece
    {
        public Bishop(PieceColor color) 
        {
            Name = "Bishop";
            Abbreviation = "Abbreviation";
            Color = color;
        }
    }
}
