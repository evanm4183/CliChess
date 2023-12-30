using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class ChessPiece
    {
        public string Name { get; protected set; }
        public string Abbreviation { get; protected set; }
        public PieceColor Color { get; protected set; }

        public virtual List<string> CalcUnobstructedMoves(string square)
        {
            throw new NotImplementedException();
        }
    }
}
