using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoJaJo.Model
{
    public class GameBoardState
    {
        public delegate void gameBoardStateChangedEvent();
        public gameBoardStateChangedEvent GameBoardChanged { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player Winner { get; set; }
        public Player CurrentPlayer
        {
            get
            {
                if ((StartedPlayer + Moves) % 2 == 0) return PlayerOne;
                else return PlayerTwo;
            }
        }
        public Square[,] BoardValues { get; set; }
        public int XDim { get; set; }
        public int YDim { get; set; }
        public int StartedPlayer { get; set; }
        public int Moves { get; set; }

        public GameBoardState(Player p1, Player p2, int x, int y)
        {
            PlayerOne = p1;
            PlayerTwo = p2;
            BoardValues = new Square[x, y];
            XDim = x;
            YDim = y;
            for (int a = 0; a < XDim; a++)
            {
                for (int b = 0; b < YDim; b++)
                {
                    BoardValues[a, b] = new Square();
                }
            }
            Random rand = new Random();
            StartedPlayer = rand.Next(0, 2);
        }

        public void SetValue(int x, int y)
        {
            if ((StartedPlayer + Moves) % 2 == 0) BoardValues[x, y].SquareValue = -1;
            else BoardValues[x, y].SquareValue = 1;
        }
        public void NextTurn()
        {
            Moves++;
            GameBoardChanged();
        }
        public bool WinCheck(int x, int y)
        {
            int checkValue = BoardValues[x, y].SquareValue;
            int NWtoSE = Deeper(x, y, checkValue, -1, -1, Deeper(x, y, checkValue, 1, 1, 1));
            int SWtoNE = Deeper(x, y, checkValue, -1, 1, Deeper(x, y, checkValue, 1, -1, 1));
            int NtoS = Deeper(x, y, checkValue, 0, -1, Deeper(x, y, checkValue, 0, 1, 1));
            int WtoE = Deeper(x, y, checkValue, -1, 0, Deeper(x, y, checkValue, 1, 0, 1));
            if (NWtoSE >= 5 || SWtoNE >= 5 || NtoS >= 5 || WtoE >= 5)
            {
                Winner = CurrentPlayer;
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Deeper(int xpos, int ypos, int checkValue, int xdir, int ydir, int value)
        {
            int newXPos = xpos + xdir;
            int newYPos = ypos + ydir;
            if (value >= 5)
            {
                return value;
            }
            if (InBoard(newXPos, newYPos))
            {
                if (BoardValues[newXPos, newYPos].SquareValue == checkValue)
                {
                    return Deeper(newXPos, newYPos, checkValue, xdir, ydir, value + 1);
                }
                return value;
            }
            return value;
        }

        private Boolean InBoard(int x, int y)
        {
            return (x >= 0 && x < XDim && y >= 0 && y < YDim);
        }

    }
}
