using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.DAL;

namespace FoJaJo.Controller
{
    public class GameController
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

        MsSqlGameDAO GameDAO;
        public GameController()
        {
            GameDAO = new MsSqlGameDAO();
        }
        public void CreateGame(string gameID, Player player, int maxNumberOfPlayers, string boardDimension, Result result)
        {
            try
            {
                Game game = new Game(gameID, player, maxNumberOfPlayers, boardDimension, result);
                GameDAO.CreateGame(game);
            }
            catch
            {

            } 
        }
        public Game GetGame(int gameID)
        {
            try
            {
                Game game = GameDAO.GetGame(gameID);
                return game;
            }
            catch
            {
                return null;
            }
        }
    }
}
