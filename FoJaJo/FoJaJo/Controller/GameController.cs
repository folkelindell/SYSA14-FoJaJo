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
        public delegate void gameStartEvent();
        public delegate void gameWonEvent();
        public PlayerController PlayerController { get; set; }
        public GameBoardState BoardState { get; set; }
        public GameBoardControl BoardView { get; set; }
        public gameStartEvent GameStarted { get; set; }
        public gameWonEvent GameWon { get; set; }

        public GameController()
        {
            GameDAO = new MsSqlGameDAO();
            PlayerController = new PlayerController();
        }

        public void MakeMove(int x, int y)
        {
            if (BoardState.BoardValues[x, y].SquareValue == 0)
            {
                BoardState.SetValue(x, y);
                if (BoardState.WinCheck(x, y) {
                    GameWon();
                    GameDAO.CreateGame()
                }
                else BoardState.NextTurn();
            }
        }

        public Player LogInPlayer(String usr, String pw)
        {
            return PlayerController.LogInPlayer(usr, pw);
        }

        public Boolean LogOutPlayer()
        {
            if(BoardState != null && BoardState.Winner != null)
            {
                return true;
            }
            return false;
        }

        public void NewGame(Player p1, Player p2, int x, int y)
        {
            if (p1 != null && p2 != null)
            {
                if (!p1.Username.Equals(p2.Username))
                {
                    BoardState = new GameBoardState(p1, p2, x, y);
                    GameStarted();
                }
            }

        }
        public void CreateGame(Player player, int maxNumberOfPlayers, string boardDimension, Result result)
        {
            try
            {
                Game game = new Game(player, maxNumberOfPlayers, boardDimension, result);
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
