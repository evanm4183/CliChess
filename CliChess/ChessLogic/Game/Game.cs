using ChessLogic.Board;
using ChessLogic.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Game
{
    public class Game
    {
        public int MoveNumber { get; set; }
        public string MoveHistory { get; set; }
        public List<ChessPiece> WhitesCapturedPieces { get; set; }
        public List<ChessPiece> BlacksCapturedPieces { get; set; }
        public bool IsWhitesTurn { get; set; } = true;
        public bool IsCheckmate { get; set; } = false;
        public ChessBoard Board { get; set; }

        public void GetMove(string move)
        {
            throw new NotImplementedException();
        }
    }
}
