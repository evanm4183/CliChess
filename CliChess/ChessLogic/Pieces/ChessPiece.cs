using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class ChessPiece
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Color { get; set; }

        public virtual List<string> CalcUnobstructedMoves(string square)
        {
            throw new NotImplementedException();
        }
    }
}
