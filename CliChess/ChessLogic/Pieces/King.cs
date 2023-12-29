﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class King : ChessPiece
    {
        public King(string color)
        {
            Name = "King";
            Abbreviation = "K";
            Color = color;
        }
    }
}
