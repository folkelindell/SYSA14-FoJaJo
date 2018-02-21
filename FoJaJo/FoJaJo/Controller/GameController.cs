using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoJaJo.Model;
using FoJaJo.DAL;
using FoJaJo.GUI;

namespace FoJaJo.Controller
{
    public class GameController
    {
        MsSqlGameDAO GameDAO;
        public GameControl View { get; set; }

        public void makeMove(object sender, System.EventArgs e)
        {
            Console.WriteLine(((SquareControl)sender).XPos);
        }

        public GameController(GameControl view)
        {
            GameDAO = new MsSqlGameDAO();
            View = view;
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
