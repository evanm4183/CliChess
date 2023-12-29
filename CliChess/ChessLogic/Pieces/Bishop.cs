using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop : ChessPiece
    {
        public Bishop(string color) 
        {
            Name = "Bishop";
            Abbreviation = "Abbreviation";
            Color = color;
        }
    }
}
