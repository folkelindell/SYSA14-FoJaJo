using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;

namespace FoJaJo.Controller
{
    class GameController
    {
        private int[,] board;
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public GameController(int x, int y, Player a, Player b)
        {
            board = new int[x, y];
            PlayerOne = a;
            PlayerTwo = b;
        }

        public int makeMove(int x, int y, int player)
        {
            return 0;
        }
    }
}
