using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Knight : ChessPiece
    {
        public Knight(string color)
        {
            Name = "Knight";
            Abbreviation = "N";
            Color = color;
        }
    }
}
